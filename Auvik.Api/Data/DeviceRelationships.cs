#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// This device's relationships to other resources
/// </summary>
[DataContract]
public class DeviceRelationships
{
	/// <summary>
	/// Gets or Sets DeviceDetail
	/// </summary>
	[DataMember(Name="deviceDetail", EmitDefaultValue=false)]
	[JsonPropertyName("deviceDetail")]
	public DeviceRelationshipsDeviceDetail DeviceDetail { get; set; }

	/// <summary>
	/// Gets or Sets Networks
	/// </summary>
	[DataMember(Name="networks", EmitDefaultValue=false)]
	[JsonPropertyName("networks")]
	public DeviceRelationshipsNetworks Networks { get; set; }

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
