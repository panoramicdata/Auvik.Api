#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// Links relating to this client's usage
/// </summary>
[DataContract]
public class DeviceUsageResourceObjectLinks
{
	/// <summary>
	/// Link to this device's record in the Device Info API
	/// </summary>
	/// <value>Link to this device's record in the Device Info API</value>
	[DataMember(Name="deviceRecord", EmitDefaultValue=false)]
	[JsonPropertyName("deviceRecord")]
	public string DeviceRecord { get; set; }

	/// <summary>
	/// Link to this device's usage in the Usage API
	/// </summary>
	/// <value>Link to this device's usage in the Usage API</value>
	[DataMember(Name="self", EmitDefaultValue=false)]
	[JsonPropertyName("self")]
	public string Self { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
