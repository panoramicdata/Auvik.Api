using System.Text;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The total billable device days for across the usage period, separate by this device's owning client type
	/// </summary>
	[DataContract]
	public class DeviceUsageAttributesTotalDaysByClientType
	{
		/// <summary>
		/// Billable devices days for the device when its client was set to Essentials
		/// </summary>
		/// <value>Billable devices days for the device when its client was set to Essentials</value>
		[DataMember(Name="essentials", EmitDefaultValue=false)]
		public decimal? Essentials { get; set; }

		/// <summary>
		/// Billable devices days for the device when its client had no set client type
		/// </summary>
		/// <value>Billable devices days for the device when its client had no set client type</value>
		[DataMember(Name="notier", EmitDefaultValue=false)]
		public decimal? Notier { get; set; }

		/// <summary>
		/// Billable devices days for the device when its client was set to Performance
		/// </summary>
		/// <value>Billable devices days for the device when its client was set to Performance</value>
		[DataMember(Name="performance", EmitDefaultValue=false)]
		public decimal? Performance { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceUsageAttributesTotalDaysByClientType {\n");
			sb.Append("  Essentials: ").Append(Essentials).Append("\n");
			sb.Append("  Notier: ").Append(Notier).Append("\n");
			sb.Append("  Performance: ").Append(Performance).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
