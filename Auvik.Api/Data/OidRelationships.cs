#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// This OID's relationships to other resources
/// </summary>
[DataContract]
public class OidRelationships
{
	/// <summary>
	/// Gets or Sets Device
	/// </summary>
	[DataMember(Name="device", EmitDefaultValue=false)]
	[JsonPropertyName("device")]
	public OidRelationshipsDevice Device { get; set; }

	/// <summary>
	/// Gets or Sets Tenant
	/// </summary>
	[DataMember(Name="tenant", EmitDefaultValue=false)]
	[JsonPropertyName("tenant")]
	public Tenant Tenant { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
