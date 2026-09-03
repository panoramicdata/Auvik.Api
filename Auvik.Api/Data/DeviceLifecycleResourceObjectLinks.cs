#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// List of links relating to this device
/// </summary>
[DataContract]
public class DeviceLifecycleResourceObjectLinks
{
	/// <summary>
	/// Link to this device's dashboard in Auvik
	/// </summary>
	/// <value>Link to this device's dashboard in Auvik</value>
	[DataMember(Name="dashboard", EmitDefaultValue=false)]
	[JsonPropertyName("dashboard")]
	public string Dashboard { get; set; }

	/// <summary>
	/// Link to this device lifecyle record
	/// </summary>
	/// <value>Link to this device lifecyle record</value>
	[DataMember(Name="self", EmitDefaultValue=false)]
	[JsonPropertyName("self")]
	public string Self { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
