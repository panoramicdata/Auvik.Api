using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The type-specific properties of the statistics object returned
	/// </summary>
	[DataContract]
	public class ServiceStatisticsAttributes
	{
		/// <summary>
		/// Endpoints checked by a cloud ping check service
		/// </summary>
		/// <value>Endpoints checked by a cloud ping check service</value>
		[DataMember(Name="endpoints", EmitDefaultValue=false)]
		public List<EndpointStats> Endpoints { get; set; }

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
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ServiceStatisticsAttributes {\n");
			sb.Append("  Endpoints: ").Append(Endpoints).Append("\n");
			sb.Append("  Interval: ").Append(Interval).Append("\n");
			sb.Append("  ReportPeriod: ").Append(ReportPeriod).Append("\n");
			sb.Append("  StatType: ").Append(StatType).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
