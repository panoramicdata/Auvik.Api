#nullable disable

using System.IO;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// The type specific properties of the tenants object returned
/// </summary>
[DataContract]
public class TenantAttributes
{
	/// <summary>
	/// The type of tenant in Auvik. A finite list of enumerated string values
	/// </summary>
	/// <value>The type of tenant in Auvik. A finite list of enumerated string values</value>
	[JsonConverter(typeof(EnumMemberJsonConverter))]
	public enum TenantTypeEnum
	{

		/// <summary>
		/// Enum CorporateIt for "corporateIt"
		/// </summary>
		[EnumMember(Value = "corporateIt")]
		CorporateIt,

		/// <summary>
		/// Enum Client for "client"
		/// </summary>
		[EnumMember(Value = "client")]
		Client,

		/// <summary>
		/// Enum MultiClient for "multiClient"
		/// </summary>
		[EnumMember(Value = "multiClient")]
		MultiClient
	}

	/// <summary>
	/// The type of tenant in Auvik. A finite list of enumerated string values
	/// </summary>
	/// <value>The type of tenant in Auvik. A finite list of enumerated string values</value>
	[DataMember(Name="tenantType", EmitDefaultValue=false)]
	[JsonPropertyName("tenantType")]
	public TenantTypeEnum? TenantType { get; set; }

	/// <summary>
	/// The domain prefix of the tenant
	/// </summary>
	/// <value>The domain prefix of the tenant</value>
	[DataMember(Name="domainPrefix", EmitDefaultValue=false)]
	[JsonPropertyName("domainPrefix")]
	public string DomainPrefix { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
