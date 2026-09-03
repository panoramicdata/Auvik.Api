#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// This device's relationships to other resources
/// </summary>
[DataContract]
public class DeviceDetailsRelationships
{
	/// <summary>
	/// Gets or Sets Components
	/// </summary>
	[DataMember(Name="components", EmitDefaultValue=false)]
	[JsonPropertyName("components")]
	public DeviceDetailsRelationshipsComponents Components { get; set; }

	/// <summary>
	/// Gets or Sets Configurations
	/// </summary>
	[DataMember(Name="configurations", EmitDefaultValue=false)]
	[JsonPropertyName("configurations")]
	public DeviceDetailsRelationshipsConfigurations Configurations { get; set; }

	/// <summary>
	/// Gets or Sets ConnectedDevices
	/// </summary>
	[DataMember(Name="connectedDevices", EmitDefaultValue=false)]
	[JsonPropertyName("connectedDevices")]
	public DeviceDetailsRelationshipsConnectedDevices ConnectedDevices { get; set; }

	/// <summary>
	/// Gets or Sets Interfaces
	/// </summary>
	[DataMember(Name="interfaces", EmitDefaultValue=false)]
	[JsonPropertyName("interfaces")]
	public DeviceDetailsRelationshipsInterfaces Interfaces { get; set; }

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
