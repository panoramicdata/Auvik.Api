using System.Runtime.Serialization;
using System.Text;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The average billable device days for this client and all of its children across the usage period, separate by devices' owning client type
	/// </summary>
	[DataContract]
	public class ClientUsageAttributesDeviceUsageAverageDaysByClientType
	{
		/// <summary>
		/// Average billable devices days for devices on a client set to Essentials
		/// </summary>
		/// <value>Average billable devices days for devices on a client set to Essentials</value>
		[DataMember(Name = "essentials", EmitDefaultValue = false)]
		public decimal? Essentials { get; set; }

		/// <summary>
		/// Average billable devices days for devices on a client with no set client type
		/// </summary>
		/// <value>Average billable devices days for devices on a client with no set client type</value>
		[DataMember(Name = "notier", EmitDefaultValue = false)]
		public decimal? Notier { get; set; }

		/// <summary>
		/// Average billable devices days for devices on a client set to Performance
		/// </summary>
		/// <value>Average billable devices days for devices on a client set to Performance</value>
		[DataMember(Name = "performance", EmitDefaultValue = false)]
		public decimal? Performance { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ClientUsageAttributesDeviceUsageAverageDaysByClientType {\n");
			sb.Append("  Essentials: ").Append(Essentials).Append("\n");
			sb.Append("  Notier: ").Append(Notier).Append("\n");
			sb.Append("  Performance: ").Append(Performance).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}