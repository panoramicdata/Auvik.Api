#nullable disable

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

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
	public override string ToString() => ObjectDescription.Describe(this);
}