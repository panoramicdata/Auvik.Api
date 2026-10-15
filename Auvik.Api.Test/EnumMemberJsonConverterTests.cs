using Auvik.Api;
using Auvik.Api.Data;
using Auvik.Api.Serialization;
using AwesomeAssertions;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Auvik.Api.Test;

/// <summary>
/// Tests the <see cref="EnumMemberJsonConverter"/> branches the happy-path tests do not reach:
/// the numeric input, unknown tokens, non-enum rejection and writing a value outside the members.
/// </summary>
public class EnumMemberJsonConverterTests
{
	/// <summary>
	/// An enum whose members carry no EnumMember attribute, so the wire name falls back to the member name.
	/// </summary>
	private enum PlainEnum { Alpha, Beta }

	private static JsonSerializerOptions Options => AuvikJsonSerializerOptions.Default;

	/// <summary>
	/// Only enum types are accepted.
	/// </summary>
	[Fact]
	public void CanConvert_OnlyEnums_AreAccepted()
	{
		new EnumMemberJsonConverter().CanConvert(typeof(PlainEnum)).Should().BeTrue();
		new EnumMemberJsonConverter().CanConvert(typeof(string)).Should().BeFalse();
		new EnumMemberJsonConverter().CanConvert(typeof(int)).Should().BeFalse();
	}

	/// <summary>
	/// A non-enum type cannot be converted.
	/// </summary>
	[Fact]
	public void CreateConverter_NonEnum_Throws()
	{
		Func<JsonConverter> act = () => new EnumMemberJsonConverter().CreateConverter(typeof(string), Options);

		act.Should().Throw<ArgumentException>().WithParameterName("typeToConvert");
	}

	/// <summary>
	/// The underlying number is accepted as input, matching the previous Newtonsoft behaviour.
	/// </summary>
	[Fact]
	public void Read_Number_BindsToMember()
	{
		var deserialized = JsonSerializer.Deserialize<DeviceTypeSchema>("2", Options);

		deserialized.Should().Be((DeviceTypeSchema)2);
	}

	/// <summary>
	/// A token that is neither a string nor a number is rejected.
	/// </summary>
	[Fact]
	public void Read_UnexpectedToken_Throws()
	{
		Func<DeviceTypeSchema> act = () => JsonSerializer.Deserialize<DeviceTypeSchema>("true", Options);

		act.Should().Throw<JsonException>();
	}

	/// <summary>
	/// A value outside the declared members has no wire name; write its number.
	/// </summary>
	[Fact]
	public void Write_UndefinedValue_WritesNumber()
	{
		var serialized = JsonSerializer.Serialize((DeviceTypeSchema)99, Options);

		serialized.Should().Be("99");
	}
}
