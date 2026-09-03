#nullable disable

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// The The authorization container object of the tenant selected
/// </summary>
[DataContract]
public class TenantDetailResourceObjectRelationshipsAuthorizations
{
	/// <summary>
	/// The list of authorization to the tenant selected
	/// </summary>
	/// <value>The list of authorization to the tenant selected</value>
	[DataMember(Name="data", EmitDefaultValue=false)]
	[JsonPropertyName("data")]
	public List<TenantDetailResourceObjectRelationshipsAuthorizationsData> Data { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
