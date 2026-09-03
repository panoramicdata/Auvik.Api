#nullable disable

using System.Text;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Auvik.Api.Data;

/// <summary>
/// This interface the statistics are reported against
/// </summary>
[DataContract]
public class InterfaceStatisticsRelationshipsInterface
{
	/// <summary>
	/// Gets or Sets Data
	/// </summary>
	[DataMember(Name="data", EmitDefaultValue=false)]
	[JsonPropertyName("data")]
	public InterfaceStatisticsRelationshipsInterfaceData Data { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class InterfaceStatisticsRelationshipsInterface {\n");
		sb.Append("  Data: ").Append(Data).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
