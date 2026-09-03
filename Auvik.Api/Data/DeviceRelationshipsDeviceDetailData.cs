#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// A device detail object
/// </summary>
[DataContract]
public class DeviceRelationshipsDeviceDetailData
{
	/// <summary>
	/// The type of object in the API
	/// </summary>
	/// <value>The type of object in the API</value>
	[JsonConverter(typeof(EnumMemberJsonConverter))]
	public enum TypeEnum
	{

		/// <summary>
		/// Enum DeviceDetail for "deviceDetail"
		/// </summary>
		[EnumMember(Value = "deviceDetail")]
		DeviceDetail
	}

	/// <summary>
	/// The type of object in the API
	/// </summary>
	/// <value>The type of object in the API</value>
	[DataMember(Name="type", EmitDefaultValue=false)]
	[JsonPropertyName("type")]
	public TypeEnum? Type { get; set; }

	/// <summary>
	/// The unique identifier for this device
	/// </summary>
	/// <value>The unique identifier for this device</value>
	[DataMember(Name="id", EmitDefaultValue=false)]
	[JsonPropertyName("id")]
	public string Id { get; set; }

	/// <summary>
	/// Gets or Sets Links
	/// </summary>
	[DataMember(Name="links", EmitDefaultValue=false)]
	[JsonPropertyName("links")]
	public DeviceRelationshipsDeviceDetailDataLinks Links { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
