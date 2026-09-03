#nullable disable

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Auvik.Api.Data;

/// <summary>
/// BasicError
/// </summary>
[DataContract]
public class BasicError
{
	/// <summary>
	/// Array of error objects
	/// </summary>
	/// <value>Array of error objects</value>
	[DataMember(Name = "errors", EmitDefaultValue = false)]
	[JsonPropertyName("errors")]
	public List<object> Errors { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class BasicError {\n");
		sb.Append("  Errors: ").Append(Errors).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}