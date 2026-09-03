#nullable disable

using System.Text;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Serialization;

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
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class TenantDetailResourceObjectRelationshipsAuthorizationsData {\n");
		sb.Append("  Id: ").Append(Id).Append("\n");
		sb.Append("  Type: ").Append(Type).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
