#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// A service resource object
/// </summary>
[DataContract]
public class ServiceStatisticsRelationshipsServiceData
{
	/// <summary>
	/// Gets or Sets Attributes
	/// </summary>
	[DataMember(Name="attributes", EmitDefaultValue=false)]
	[JsonPropertyName("attributes")]
	public ServiceStatisticsRelationshipsServiceDataAttributes Attributes { get; set; }

	/// <summary>
	/// Gets or Sets Links
	/// </summary>
	[DataMember(Name="links", EmitDefaultValue=false)]
	[JsonPropertyName("links")]
	public ServiceStatisticsRelationshipsServiceDataLinks Links { get; set; }

	/// <summary>
	/// The entity type for a service
	/// </summary>
	/// <value>The entity type for a service</value>
	[DataMember(Name="type", EmitDefaultValue=false)]
	[JsonPropertyName("type")]
	public string Type { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
