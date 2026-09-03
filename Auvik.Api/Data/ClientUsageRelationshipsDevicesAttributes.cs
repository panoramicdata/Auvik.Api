#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// The type-specific properties of the device usage object returned
/// </summary>
[DataContract]
public class ClientUsageRelationshipsDevicesAttributes
{
	/// <summary>
	/// This device's owning client's name/domainPrefix
	/// </summary>
	/// <value>This device's owning client's name/domainPrefix</value>
	[DataMember(Name = "clientName", EmitDefaultValue = false)]
	[JsonPropertyName("clientName")]
	public string ClientName { get; set; }

	/// <summary>
	/// Device's name
	/// </summary>
	/// <value>Device's name</value>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// Total billable days for this device across the usage period
	/// </summary>
	/// <value>Total billable days for this device across the usage period</value>
	[DataMember(Name = "totalDays", EmitDefaultValue = false)]
	[JsonPropertyName("totalDays")]
	public decimal? TotalDays { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}