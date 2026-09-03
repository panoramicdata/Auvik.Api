#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// The template for a resource object representing an audit log
/// </summary>
[DataContract]
public class AuditsResourceObject
{
	/// <summary>
	/// The type of object in the API
	/// </summary>
	/// <value>The type of object in the API</value>
	[JsonConverter(typeof(EnumMemberJsonConverter))]
	public enum TypeEnum
	{

		/// <summary>
		/// Enum EntityAudit for "entityAudit"
		/// </summary>
		[EnumMember(Value = "entityAudit")]
		EntityAudit
	}

	/// <summary>
	/// The type of object in the API
	/// </summary>
	/// <value>The type of object in the API</value>
	[DataMember(Name = "type", EmitDefaultValue = false)]
	[JsonPropertyName("type")]
	public TypeEnum? Type { get; set; }

	/// <summary>
	/// Gets or Sets Attributes
	/// </summary>
	[DataMember(Name = "attributes", EmitDefaultValue = false)]
	[JsonPropertyName("attributes")]
	public AuditAttributes Attributes { get; set; }

	/// <summary>
	/// The unique identifier for this audit
	/// </summary>
	/// <value>The unique identifier for this audit</value>
	[DataMember(Name = "id", EmitDefaultValue = false)]
	[JsonPropertyName("id")]
	public string Id { get; set; }

	/// <summary>
	/// Gets or Sets Links
	/// </summary>
	[DataMember(Name = "links", EmitDefaultValue = false)]
	[JsonPropertyName("links")]
	public AuditsResourceObjectLinks Links { get; set; }

	/// <summary>
	/// Gets or Sets Relationships
	/// </summary>
	[DataMember(Name = "relationships", EmitDefaultValue = false)]
	[JsonPropertyName("relationships")]
	public AuditRelationships Relationships { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}