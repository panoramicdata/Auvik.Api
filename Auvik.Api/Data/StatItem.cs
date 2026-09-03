#nullable disable

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// StatItem
/// </summary>
[DataContract]
public class StatItem
{
	/// <summary>
	/// An list of rows of statistics data, as described by the legend
	/// </summary>
	/// <value>An list of rows of statistics data, as described by the legend</value>
	[DataMember(Name="data", EmitDefaultValue=false)]
	[JsonPropertyName("data")]
	public List<List<decimal?>> Data { get; set; }

	/// <summary>
	/// Index for multi-part statistics
	/// </summary>
	/// <value>Index for multi-part statistics</value>
	[DataMember(Name="index", EmitDefaultValue=false)]
	[JsonPropertyName("index")]
	public string Index { get; set; }

	/// <summary>
	/// A description of the stats data columns
	/// </summary>
	/// <value>A description of the stats data columns</value>
	[DataMember(Name="legend", EmitDefaultValue=false)]
	[JsonPropertyName("legend")]
	public List<string> Legend { get; set; }

	/// <summary>
	/// Name of the statistic
	/// </summary>
	/// <value>Name of the statistic</value>
	[DataMember(Name="name", EmitDefaultValue=false)]
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// Unit type for each stats data column
	/// </summary>
	/// <value>Unit type for each stats data column</value>
	[DataMember(Name="unit", EmitDefaultValue=false)]
	[JsonPropertyName("unit")]
	public List<string> Unit { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
