#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// The type-specific properties of the service
/// </summary>
[DataContract]
public class ServiceStatisticsRelationshipsServiceDataAttributes
{
	/// <summary>
	/// A description of the service
	/// </summary>
	/// <value>A description of the service</value>
	[DataMember(Name="serviceName", EmitDefaultValue=false)]
	[JsonPropertyName("serviceName")]
	public string ServiceName { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
