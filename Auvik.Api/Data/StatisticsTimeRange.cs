#nullable disable

using Refit;

namespace Auvik.Api.Data;

/// <summary>
/// The time range and reporting interval of a statistics query
/// </summary>
public class StatisticsTimeRange
{
	/// <summary>Timestamp from which you want to query</summary>
	[AliasAs("filter[fromTime]")]
	public string FromTime { get; set; }

	/// <summary>Statistics reporting interval</summary>
	[AliasAs("filter[interval]")]
	public string Interval { get; set; }

	/// <summary>Timestamp to which you want to query (defaults to current time) (optional)</summary>
	[AliasAs("filter[thruTime]")]
	public string ThruTime { get; set; }
}
