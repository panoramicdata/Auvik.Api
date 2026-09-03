#nullable disable

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// The type-specific properties of the statistics object returned
/// </summary>
[DataContract]
public class StatisticsAttributes
{
	/// <summary>
	/// Gets or Sets Interval
	/// </summary>
	[DataMember(Name="interval", EmitDefaultValue=false)]
	[JsonPropertyName("interval")]
	public Interval Interval { get; set; }

	/// <summary>
	/// Gets or Sets ReportPeriod
	/// </summary>
	[DataMember(Name="reportPeriod", EmitDefaultValue=false)]
	[JsonPropertyName("reportPeriod")]
	public ReportPeriod ReportPeriod { get; set; }

	/// <summary>
	/// Gets or Sets StatType
	/// </summary>
	[DataMember(Name="statType", EmitDefaultValue=false)]
	[JsonPropertyName("statType")]
	public StatType StatType { get; set; }

	/// <summary>
	/// The list of statistics reported for the entity
	/// </summary>
	/// <value>The list of statistics reported for the entity</value>
	[DataMember(Name="stats", EmitDefaultValue=false)]
	[JsonPropertyName("stats")]
	public List<StatItem> Stats { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
