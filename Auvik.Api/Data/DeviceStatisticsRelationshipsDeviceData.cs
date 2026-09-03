#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// A device resource object
/// </summary>
[DataContract]
public class DeviceStatisticsRelationshipsDeviceData
{
	/// <summary>
	/// The name of the device
	/// </summary>
	/// <value>The name of the device</value>
	[DataMember(Name="deviceName", EmitDefaultValue=false)]
	[JsonPropertyName("deviceName")]
	public string DeviceName { get; set; }

	/// <summary>
	/// The type of the device
	/// </summary>
	/// <value>The type of the device</value>
	[DataMember(Name="deviceType", EmitDefaultValue=false)]
	[JsonPropertyName("deviceType")]
	public string DeviceType { get; set; }

	/// <summary>
	/// This device's ID
	/// </summary>
	/// <value>This device's ID</value>
	[DataMember(Name="id", EmitDefaultValue=false)]
	[JsonPropertyName("id")]
	public string Id { get; set; }

	/// <summary>
	/// Gets or Sets Links
	/// </summary>
	[DataMember(Name="links", EmitDefaultValue=false)]
	[JsonPropertyName("links")]
	public InterfaceRelationshipsParentDeviceDataLinks Links { get; set; }

	/// <summary>
	/// The type of the object
	/// </summary>
	/// <value>The type of the object</value>
	[DataMember(Name="type", EmitDefaultValue=false)]
	[JsonPropertyName("type")]
	public string Type { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
