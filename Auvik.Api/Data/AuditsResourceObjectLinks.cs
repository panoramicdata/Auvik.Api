#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// List of links relating to this entity audit
/// </summary>
[DataContract]
public class AuditsResourceObjectLinks
{
	/// <summary>
	/// Link to this entity audit
	/// </summary>
	/// <value>Link to this entity audit</value>
	[DataMember(Name = "self", EmitDefaultValue = false)]
	[JsonPropertyName("self")]
	public string Self { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}