#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// This interface's relationships to other resources
/// </summary>
[DataContract]
public class AlertRelationships
{
	/// <summary>
	/// Gets or Sets Entity
	/// </summary>
	[DataMember(Name = "entity", EmitDefaultValue = false)]
	[JsonPropertyName("entity")]
	public AlertRelationshipsEntity Entity { get; set; }

	/// <summary>
	/// Gets or Sets RelatedAlert
	/// </summary>
	[DataMember(Name = "relatedAlert", EmitDefaultValue = false)]
	[JsonPropertyName("relatedAlert")]
	public AlertRelationshipsRelatedAlert RelatedAlert { get; set; }

	/// <summary>
	/// Gets or Sets Tenant
	/// </summary>
	[DataMember(Name = "tenant", EmitDefaultValue = false)]
	[JsonPropertyName("tenant")]
	public Tenant Tenant { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}