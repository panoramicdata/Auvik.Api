#nullable disable

using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Auvik.Api.Data;

/// <summary>
/// The attribute of the related alert
/// </summary>
[DataContract]
public class AlertRelationshipsRelatedAlertDataAttributes
{
	/// <summary>
	/// The name of related alert
	/// </summary>
	/// <value>The name of related alert</value>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class AlertRelationshipsRelatedAlertDataAttributes {\n");
		sb.Append("  Name: ").Append(Name).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}