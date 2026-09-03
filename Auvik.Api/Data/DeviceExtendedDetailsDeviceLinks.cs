#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// List of links relating to this device
/// </summary>
[DataContract]
public class DeviceExtendedDetailsDeviceLinks
{
	/// <summary>
	/// Link to this device's device info
	/// </summary>
	/// <value>Link to this device's device info</value>
	[DataMember(Name="info", EmitDefaultValue=false)]
	[JsonPropertyName("info")]
	public string Info { get; set; }

	/// <summary>
	/// Link to this device's extended details
	/// </summary>
	/// <value>Link to this device's extended details</value>
	[DataMember(Name="self", EmitDefaultValue=false)]
	[JsonPropertyName("self")]
	public string Self { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
