#nullable disable

using System.IO;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// The type-specific properties of the tenant object returned
/// </summary>
[DataContract]
public class TenantDataAttributes
{
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
