#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// Service statistics object's relationships to other resources
/// </summary>
[DataContract]
public class ServiceStatisticsRelationships
{
	/// <summary>
	/// Gets or Sets Service
	/// </summary>
	[DataMember(Name="service", EmitDefaultValue=false)]
	[JsonPropertyName("service")]
	public ServiceStatisticsRelationshipsService Service { get; set; }

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
