#nullable disable

using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Auvik.Api.Data;

/// <summary>
/// This interface's networks
/// </summary>
[DataContract]
public class InterfaceRelationshipsNetworks
{
	/// <summary>
	/// An network resource object
	/// </summary>
	/// <value>An network resource object</value>
	[DataMember(Name="data", EmitDefaultValue=false)]
	[JsonPropertyName("data")]
	public List<InterfaceRelationshipsNetworksData> Data { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class InterfaceRelationshipsNetworks {\n");
		sb.Append("  Data: ").Append(Data).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
