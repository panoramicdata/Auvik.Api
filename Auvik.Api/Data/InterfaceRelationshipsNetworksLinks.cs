#nullable disable

using System.Text;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Auvik.Api.Data;

/// <summary>
/// Links relating to this network
/// </summary>
[DataContract]
public class InterfaceRelationshipsNetworksLinks
{
	/// <summary>
	/// Link to this network's dashboard in Auvik
	/// </summary>
	/// <value>Link to this network's dashboard in Auvik</value>
	[DataMember(Name="dashboard", EmitDefaultValue=false)]
	[JsonPropertyName("dashboard")]
	public string Dashboard { get; set; }

	/// <summary>
	/// Link to this set of network info
	/// </summary>
	/// <value>Link to this set of network info</value>
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
		sb.Append("class InterfaceRelationshipsNetworksLinks {\n");
		sb.Append("  Dashboard: ").Append(Dashboard).Append("\n");
		sb.Append("  Self: ").Append(Self).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
