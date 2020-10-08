using System.Runtime.Serialization;
using System.Text;

namespace Auvik.Api.Data
{
	/// <summary>
	/// Roll up of device usage on this client (and its children if a multi-client)
	/// </summary>
	[DataContract]
	public class ClientUsageAttributesDeviceUsage
	{
		/// <summary>
		/// The average billable device days for this client and all of its children across the usage period
		/// </summary>
		/// <value>The average billable device days for this client and all of its children across the usage period</value>
		[DataMember(Name = "averageDays", EmitDefaultValue = false)]
		public decimal? AverageDays { get; set; }

		/// <summary>
		/// Gets or Sets AverageDaysByClientType
		/// </summary>
		[DataMember(Name = "averageDaysByClientType", EmitDefaultValue = false)]
		public ClientUsageAttributesDeviceUsageAverageDaysByClientType AverageDaysByClientType { get; set; }

		/// <summary>
		/// The total billable device days for this client and all of its children across the usage period
		/// </summary>
		/// <value>The total billable device days for this client and all of its children across the usage period</value>
		[DataMember(Name = "totalDays", EmitDefaultValue = false)]
		public decimal? TotalDays { get; set; }

		/// <summary>
		/// Gets or Sets TotalDaysByClientType
		/// </summary>
		[DataMember(Name = "totalDaysByClientType", EmitDefaultValue = false)]
		public ClientUsageAttributesDeviceUsageTotalDaysByClientType TotalDaysByClientType { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ClientUsageAttributesDeviceUsage {\n");
			sb.Append("  AverageDays: ").Append(AverageDays).Append("\n");
			sb.Append("  AverageDaysByClientType: ").Append(AverageDaysByClientType).Append("\n");
			sb.Append("  TotalDays: ").Append(TotalDays).Append("\n");
			sb.Append("  TotalDaysByClientType: ").Append(TotalDaysByClientType).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}