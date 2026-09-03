#nullable disable

using System.Text;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

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
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class DeviceDetailsRelationships {\n");
		sb.Append("  Components: ").Append(Components).Append("\n");
		sb.Append("  Configurations: ").Append(Configurations).Append("\n");
		sb.Append("  ConnectedDevices: ").Append(ConnectedDevices).Append("\n");
		sb.Append("  Interfaces: ").Append(Interfaces).Append("\n");
		sb.Append("  Tenant: ").Append(Tenant).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
