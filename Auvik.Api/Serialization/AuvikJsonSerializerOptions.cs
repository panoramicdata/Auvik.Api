using System.Text.Json;
using System.Text.Json.Serialization;
using Auvik.Api.Serialization;

namespace Auvik.Api.Serialization;

/// <summary>
/// The JSON options the client uses to talk to the Auvik API.
/// </summary>
public static class AuvikJsonSerializerOptions
{
	/// <summary>
	/// The options used for every request and response.
	/// </summary>
	/// <remarks>
	/// Property names come from the <see cref="JsonPropertyNameAttribute"/> on each member, so no naming
	/// policy is applied. Default values are omitted when writing, matching the API's optional fields.
	/// </remarks>
	public static JsonSerializerOptions Default { get; } = Create();

	private static JsonSerializerOptions Create()
	{
		var options = new JsonSerializerOptions
		{
			PropertyNameCaseInsensitive = true,
			DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
			NumberHandling = JsonNumberHandling.AllowReadingFromString
		};
		options.Converters.Add(new EnumMemberJsonConverter());
		// Locks the instance so callers cannot mutate the shared options; the reflection-based
		// resolver is populated at the same time.
		options.MakeReadOnly(populateMissingResolver: true);
		return options;
	}
}
