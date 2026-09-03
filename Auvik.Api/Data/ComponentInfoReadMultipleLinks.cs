#nullable disable

using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Auvik.Api.Data;

/// <summary>
/// Pagination related links
/// </summary>
[DataContract]
public class ComponentInfoReadMultipleLinks
{
	/// <summary>
	/// First page in the data set
	/// </summary>
	/// <value>First page in the data set</value>
	[DataMember(Name = "first", EmitDefaultValue = false)]
	[JsonPropertyName("first")]
	public string First { get; set; }

	/// <summary>
	/// Last page in the data set
	/// </summary>
	/// <value>Last page in the data set</value>
	[DataMember(Name = "last", EmitDefaultValue = false)]
	[JsonPropertyName("last")]
	public string Last { get; set; }

	/// <summary>
	/// Next page in the data set
	/// </summary>
	/// <value>Next page in the data set</value>
	[DataMember(Name = "next", EmitDefaultValue = false)]
	[JsonPropertyName("next")]
	public string Next { get; set; }

	/// <summary>
	/// Previous page in the data set
	/// </summary>
	/// <value>Previous page in the data set</value>
	[DataMember(Name = "prev", EmitDefaultValue = false)]
	[JsonPropertyName("prev")]
	public string Prev { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class ComponentInfoReadMultipleLinks {\n");
		sb.Append("  First: ").Append(First).Append("\n");
		sb.Append("  Last: ").Append(Last).Append("\n");
		sb.Append("  Next: ").Append(Next).Append("\n");
		sb.Append("  Prev: ").Append(Prev).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}