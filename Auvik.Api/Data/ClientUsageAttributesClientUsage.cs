#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// Roll up of client usage for this client (and its children if a multi-client)
/// </summary>
[DataContract]
public class ClientUsageAttributesClientUsage
{
	/// <summary>
	/// Average billable client days for this client (and its children) across the usage period
	/// </summary>
	/// <value>Average billable client days for this client (and its children) across the usage period</value>
	[DataMember(Name = "averagedDays", EmitDefaultValue = false)]
	[JsonPropertyName("averagedDays")]
	public decimal? AveragedDays { get; set; }

	/// <summary>
	/// Total billable client days for this client (and its children) across the usage period
	/// </summary>
	/// <value>Total billable client days for this client (and its children) across the usage period</value>
	[DataMember(Name = "totalDays", EmitDefaultValue = false)]
	[JsonPropertyName("totalDays")]
	public decimal? TotalDays { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}