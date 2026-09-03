#nullable disable

using System.Text;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Auvik.Api.Data;

/// <summary>
/// Links relating to this device details
/// </summary>
[DataContract]
public class DeviceRelationshipsDeviceDetailDataLinks
{
	/// <summary>
	/// Link to this device's dashboard in Auvik
	/// </summary>
	/// <value>Link to this device's dashboard in Auvik</value>
	[DataMember(Name="dashboard", EmitDefaultValue=false)]
	[JsonPropertyName("dashboard")]
	public string Dashboard { get; set; }

	/// <summary>
	/// Link to this device detail
	/// </summary>
	/// <value>Link to this device detail</value>
	[DataMember(Name="self", EmitDefaultValue=false)]
	[JsonPropertyName("self")]
	public string Self { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class DeviceRelationshipsDeviceDetailDataLinks {\n");
		sb.Append("  Dashboard: ").Append(Dashboard).Append("\n");
		sb.Append("  Self: ").Append(Self).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
