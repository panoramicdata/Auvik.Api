#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// Links relating to this device
/// </summary>
[DataContract]
public class InterfaceRelationshipsParentDeviceDataLinks
{
	/// <summary>
	/// Link to this device's dashboard in Auvik
	/// </summary>
	/// <value>Link to this device's dashboard in Auvik</value>
	[DataMember(Name="dashboard", EmitDefaultValue=false)]
	[JsonPropertyName("dashboard")]
	public string Dashboard { get; set; }

	/// <summary>
	/// Link to this set of device info
	/// </summary>
	/// <value>Link to this set of device info</value>
	[DataMember(Name="self", EmitDefaultValue=false)]
	[JsonPropertyName("self")]
	public string Self { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
