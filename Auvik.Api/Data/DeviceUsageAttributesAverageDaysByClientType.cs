using System.Text;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The average billable device days for all clients across the usage period, separate by devices' owning client type
	/// </summary>
	[DataContract]
	public class DeviceUsageAttributesAverageDaysByClientType
	{
		/// <summary>
		/// Average billable devices days for the device when its client was set to Essentials
		/// </summary>
		/// <value>Average billable devices days for the device when its client was set to Essentials</value>
		[DataMember(Name="essentials", EmitDefaultValue=false)]
		public decimal? Essentials { get; set; }

		/// <summary>
		/// Average billable devices days for the device when its client had no set client type
		/// </summary>
		/// <value>Average billable devices days for the device when its client had no set client type</value>
		[DataMember(Name="notier", EmitDefaultValue=false)]
		public decimal? Notier { get; set; }

		/// <summary>
		/// Average billable devices days for the device when its client was set to Performance
		/// </summary>
		/// <value>Average billable devices days for the device when its client was set to Performance</value>
		[DataMember(Name="performance", EmitDefaultValue=false)]
		public decimal? Performance { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceUsageAttributesAverageDaysByClientType {\n");
			sb.Append("  Essentials: ").Append(Essentials).Append("\n");
			sb.Append("  Notier: ").Append(Notier).Append("\n");
			sb.Append("  Performance: ").Append(Performance).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
