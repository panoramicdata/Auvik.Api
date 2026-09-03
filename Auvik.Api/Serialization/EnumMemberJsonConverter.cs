using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using Auvik.Api.Serialization;

namespace Auvik.Api.Serialization;

/// <summary>
/// Serializes enums as the string given by their <see cref="EnumMemberAttribute"/>, falling back to
/// the member name where no attribute is present.
/// </summary>
/// <remarks>
/// System.Text.Json's built-in <see cref="JsonStringEnumConverter"/> does not read
/// <see cref="EnumMemberAttribute"/>, which is how every enum in this library declares its wire value.
/// </remarks>
public sealed class EnumMemberJsonConverter : JsonConverterFactory
{
	/// <inheritdoc />
	public override bool CanConvert(Type typeToConvert)
		=> typeToConvert is not null && typeToConvert.IsEnum;

	/// <inheritdoc />
	public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
	{
		if (!CanConvert(typeToConvert))
		{
			throw new ArgumentException($"{typeToConvert} is not an enum type.", nameof(typeToConvert));
		}

		return (JsonConverter)Activator.CreateInstance(
			typeof(EnumMemberJsonConverter<>).MakeGenericType(typeToConvert))!;
	}
}

/// <summary>
/// The <see cref="EnumMemberJsonConverter"/> implementation for a single enum type.
/// </summary>
/// <typeparam name="T">The enum type.</typeparam>
internal sealed class EnumMemberJsonConverter<T> : JsonConverter<T> where T : struct, Enum
{
	// Built once per closed generic type: reflecting over the enum's fields on every value would be
	// unreasonably slow for a converter that runs on every property of every response.
	private static readonly Dictionary<T, string> ValueToName = BuildValueToName();
	private static readonly Dictionary<string, T> NameToValue = BuildNameToValue();

	private static Dictionary<T, string> BuildValueToName()
	{
		var result = new Dictionary<T, string>();
		foreach (var field in typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static))
		{
			var value = (T)field.GetValue(null)!;
			// Aliases (two members with the same numeric value) keep the first declaration.
			if (!result.ContainsKey(value))
			{
				result[value] = field.GetCustomAttribute<EnumMemberAttribute>()?.Value ?? field.Name;
			}
		}

		return result;
	}

	private static Dictionary<string, T> BuildNameToValue()
	{
		var result = new Dictionary<string, T>(StringComparer.OrdinalIgnoreCase);
		foreach (var field in typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static))
		{
			var value = (T)field.GetValue(null)!;
			var wireName = field.GetCustomAttribute<EnumMemberAttribute>()?.Value;
			if (wireName is not null)
			{
				result[wireName] = value;
			}

			// The member name is also accepted, so payloads that spell the value out in C# form still bind.
			result[field.Name] = value;
		}

		return result;
	}

	public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		switch (reader.TokenType)
		{
			case JsonTokenType.String:
				var text = reader.GetString();
				if (text is not null && NameToValue.TryGetValue(text, out var value))
				{
					return value;
				}

				throw new JsonException($"'{text}' is not a recognised value for {typeof(T).Name}.");

			case JsonTokenType.Number:
				// Newtonsoft's StringEnumConverter accepted the underlying number, so this does too.
				if (reader.TryGetInt64(out var number))
				{
					return (T)Enum.ToObject(typeof(T), number);
				}

				throw new JsonException($"The number could not be read as {typeof(T).Name}.");

			default:
				throw new JsonException($"Unexpected token {reader.TokenType} when reading {typeof(T).Name}.");
		}
	}

	public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
	{
		if (ValueToName.TryGetValue(value, out var name))
		{
			writer.WriteStringValue(name);
			return;
		}

		// A value outside the declared members has no wire name; write the number rather than invent one.
		writer.WriteNumberValue(Convert.ToInt64(value, System.Globalization.CultureInfo.InvariantCulture));
	}
}
