using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
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
		public Interval Interval { get; set; }

		/// <summary>
		/// Gets or Sets ReportPeriod
		/// </summary>
		[DataMember(Name="reportPeriod", EmitDefaultValue=false)]
		public ReportPeriod ReportPeriod { get; set; }

		/// <summary>
		/// Gets or Sets StatType
		/// </summary>
		[DataMember(Name="statType", EmitDefaultValue=false)]
		public StatType StatType { get; set; }

		/// <summary>
		/// The list of statistics reported for the entity
		/// </summary>
		/// <value>The list of statistics reported for the entity</value>
		[DataMember(Name="stats", EmitDefaultValue=false)]
		public List<StatItem> Stats { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class StatisticsAttributes {\n");
			sb.Append("  Interval: ").Append(Interval).Append("\n");
			sb.Append("  ReportPeriod: ").Append(ReportPeriod).Append("\n");
			sb.Append("  StatType: ").Append(StatType).Append("\n");
			sb.Append("  Stats: ").Append(Stats).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
