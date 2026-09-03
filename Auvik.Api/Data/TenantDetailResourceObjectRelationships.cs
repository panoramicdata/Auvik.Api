#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// The type specific relationship of the legacy tenants object to other entities
/// </summary>
[DataContract]
public class TenantDetailResourceObjectRelationships
{
	/// <summary>
	/// Gets or Sets Authorizations
	/// </summary>
	[DataMember(Name="authorizations", EmitDefaultValue=false)]
	[JsonPropertyName("authorizations")]
	public TenantDetailResourceObjectRelationshipsAuthorizations Authorizations { get; set; }

	/// <summary>
	/// Gets or Sets Parent
	/// </summary>
	[DataMember(Name="parent", EmitDefaultValue=false)]
	[JsonPropertyName("parent")]
	public TenantDetailResourceObjectRelationshipsParent Parent { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
