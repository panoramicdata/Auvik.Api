#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// TenantDetailResourceObjectRelationshipsAuthorizationsData
/// </summary>
[DataContract]
public class TenantDetailResourceObjectRelationshipsAuthorizationsData
{
	/// <summary>
	/// The type of authorizations
	/// </summary>
	/// <value>The type of authorizations</value>
	[JsonConverter(typeof(EnumMemberJsonConverter))]
	public enum TypeEnum
	{

		/// <summary>
		/// Enum Authorizations for "authorizations"
		/// </summary>
		[EnumMember(Value = "authorizations")]
		Authorizations
	}

	/// <summary>
	/// The type of authorizations
	/// </summary>
	/// <value>The type of authorizations</value>
	[DataMember(Name="type", EmitDefaultValue=false)]
	[JsonPropertyName("type")]
	public TypeEnum? Type { get; set; }

	/// <summary>
	/// The id is granted for authorization
	/// </summary>
	/// <value>The id is granted for authorization</value>
	[DataMember(Name="id", EmitDefaultValue=false)]
	[JsonPropertyName("id")]
	public string Id { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
