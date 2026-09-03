#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;
using Auvik.Api.Serialization;

namespace Auvik.Api.Data;

/// <summary>
/// The device extended details resource object, shared by every extended detail type.
/// </summary>
[DataContract]
public abstract class DeviceExtendedDetailsResource
{
	/// <summary>
	/// The type of object in the API
	/// </summary>
	/// <value>The type of object in the API</value>
	[JsonConverter(typeof(EnumMemberJsonConverter))]
	public enum TypeEnum
	{
		/// <summary>
		/// Enum DeviceExtendedDetail for "deviceExtendedDetail"
		/// </summary>
		[EnumMember(Value = "deviceExtendedDetail")]
		DeviceExtendedDetail
	}

	/// <summary>
	/// The type of object in the API
	/// </summary>
	/// <value>The type of object in the API</value>
	[DataMember(Name = "type", EmitDefaultValue = false)]
	[JsonPropertyName("type")]
	public TypeEnum? Type { get; set; }

	/// <summary>
	/// The unique identifier for a device
	/// </summary>
	/// <value>The unique identifier for a device</value>
	[DataMember(Name = "id", EmitDefaultValue = false)]
	[JsonPropertyName("id")]
	public string Id { get; set; }

	/// <summary>
	/// Gets or Sets Links
	/// </summary>
	[DataMember(Name = "links", EmitDefaultValue = false)]
	[JsonPropertyName("links")]
	public DeviceExtendedDetailsDeviceLinks Links { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
