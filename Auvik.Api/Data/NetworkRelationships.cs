#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// This network's relationships to other resources
/// </summary>
[DataContract]
public class NetworkRelationships
{
	/// <summary>
	/// Gets or Sets Devices
	/// </summary>
	[DataMember(Name="devices", EmitDefaultValue=false)]
	[JsonPropertyName("devices")]
	public NetworkRelationshipsDevices Devices { get; set; }

	/// <summary>
	/// Gets or Sets NetworkDetail
	/// </summary>
	[DataMember(Name="networkDetail", EmitDefaultValue=false)]
	[JsonPropertyName("networkDetail")]
	public NetworkRelationshipsNetworkDetail NetworkDetail { get; set; }

	/// <summary>
	/// Gets or Sets Tenant
	/// </summary>
	[DataMember(Name="tenant", EmitDefaultValue=false)]
	[JsonPropertyName("tenant")]
	public Tenant Tenant { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
