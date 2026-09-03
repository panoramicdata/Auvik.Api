#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// The template for a resource object representing an Auvik tenant
/// </summary>
[DataContract]
public class TenantData
{
	/// <summary>
	/// The type of object in the API.
	/// </summary>
	/// <value>The type of object in the API.</value>
	[JsonConverter(typeof(EnumMemberJsonConverter))]
	public enum TypeEnum
	{

		/// <summary>
		/// Enum Tenant for "tenant"
		/// </summary>
		[EnumMember(Value = "tenant")]
		Tenant
	}

	/// <summary>
	/// The type of object in the API.
	/// </summary>
	/// <value>The type of object in the API.</value>
	[DataMember(Name="type", EmitDefaultValue=false)]
	[JsonPropertyName("type")]
	public TypeEnum? Type { get; set; }

	/// <summary>
	/// Gets or Sets Attributes
	/// </summary>
	[DataMember(Name="attributes", EmitDefaultValue=false)]
	[JsonPropertyName("attributes")]
	public TenantDataAttributes Attributes { get; set; }

	/// <summary>
	/// The unique identifier for a tenant
	/// </summary>
	/// <value>The unique identifier for a tenant</value>
	[DataMember(Name="id", EmitDefaultValue=false)]
	[JsonPropertyName("id")]
	public string Id { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
