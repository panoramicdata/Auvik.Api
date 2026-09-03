#nullable disable

using System.Text;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Auvik.Api.Data;

/// <summary>
/// Links relating to the service statistics
/// </summary>
[DataContract]
public class ServiceStatisticsResourceObjectLinks
{
	/// <summary>
	/// Link to this service's record in the Service Info API
	/// </summary>
	/// <value>Link to this service's record in the Service Info API</value>
	[DataMember(Name="dashboard", EmitDefaultValue=false)]
	[JsonPropertyName("dashboard")]
	public string Dashboard { get; set; }

	/// <summary>
	/// Link used to get this result set
	/// </summary>
	/// <value>Link used to get this result set</value>
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
		sb.Append("class ServiceStatisticsResourceObjectLinks {\n");
		sb.Append("  Dashboard: ").Append(Dashboard).Append("\n");
		sb.Append("  Self: ").Append(Self).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
