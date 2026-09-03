#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// The meta object that contains non-standard meta-information
/// </summary>
[DataContract]
public class Meta
{
	/// <summary>
	/// Total page count.
	/// </summary>
	/// <value>Total page count.</value>
	[DataMember(Name="totalPages", EmitDefaultValue=false)]
	[JsonPropertyName("totalPages")]
	public decimal? TotalPages { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
