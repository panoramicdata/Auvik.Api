#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// Reporting period for the returned statistics
/// </summary>
[DataContract]
public class ReportPeriod
{
	/// <summary>
	/// Start timestamp for the statistics query
	/// </summary>
	/// <value>Start timestamp for the statistics query</value>
	[DataMember(Name="fromTime", EmitDefaultValue=false)]
	[JsonPropertyName("fromTime")]
	public string FromTime { get; set; }

	/// <summary>
	/// End timestamp for the statistics query
	/// </summary>
	/// <value>End timestamp for the statistics query</value>
	[DataMember(Name="thruTime", EmitDefaultValue=false)]
	[JsonPropertyName("thruTime")]
	public string ThruTime { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
