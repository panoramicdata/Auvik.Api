#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// The type-specific properties of the device usage object returned
/// </summary>
[DataContract]
public class DeviceUsageRelationshipsClientDataAttributes
{
	/// <summary>
	/// Client tenant's domain prefix/name
	/// </summary>
	/// <value>Client tenant's domain prefix/name</value>
	[DataMember(Name="domainPrefix", EmitDefaultValue=false)]
	[JsonPropertyName("domainPrefix")]
	public string DomainPrefix { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
