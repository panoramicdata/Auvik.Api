#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// ClientUsageRelationshipsClientsData
/// </summary>
[DataContract]
public class ClientUsageRelationshipsClientsData
{
	/// <summary>
	/// The type of this resource object
	/// </summary>
	/// <value>The type of this resource object</value>
	[JsonConverter(typeof(EnumMemberJsonConverter))]
	public enum TypeEnum
	{

		/// <summary>
		/// Enum ClientUsage for "clientUsage"
		/// </summary>
		[EnumMember(Value = "clientUsage")]
		ClientUsage
	}

	/// <summary>
	/// The type of this resource object
	/// </summary>
	/// <value>The type of this resource object</value>
	[DataMember(Name = "type", EmitDefaultValue = false)]
	[JsonPropertyName("type")]
	public TypeEnum? Type { get; set; }

	/// <summary>
	/// Gets or Sets Attributes
	/// </summary>
	[DataMember(Name = "attributes", EmitDefaultValue = false)]
	[JsonPropertyName("attributes")]
	public ClientUsageRelationshipsClientsAttributes Attributes { get; set; }

	/// <summary>
	/// Client's ID
	/// </summary>
	/// <value>Client's ID</value>
	[DataMember(Name = "id", EmitDefaultValue = false)]
	[JsonPropertyName("id")]
	public string Id { get; set; }

	/// <summary>
	/// Gets or Sets Links
	/// </summary>
	[DataMember(Name = "links", EmitDefaultValue = false)]
	[JsonPropertyName("links")]
	public ClientUsageRelationshipsClientsLinks Links { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}