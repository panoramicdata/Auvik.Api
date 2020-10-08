using System.Runtime.Serialization;
using System.Text;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The type-specific properties of the client usage object returned
	/// </summary>
	[DataContract]
	public class ClientUsageAttributes
	{
		/// <summary>
		/// Days this client (and only this client) was billable for across the usage period.
		/// </summary>
		/// <value>Days this client (and only this client) was billable for across the usage period.</value>
		[DataMember(Name = "billableDays", EmitDefaultValue = false)]
		public decimal? BillableDays { get; set; }

		/// <summary>
		/// Gets or Sets ClientUsage
		/// </summary>
		[DataMember(Name = "clientUsage", EmitDefaultValue = false)]
		public ClientUsageAttributesClientUsage ClientUsage { get; set; }

		/// <summary>
		/// Gets or Sets DeviceUsage
		/// </summary>
		[DataMember(Name = "deviceUsage", EmitDefaultValue = false)]
		public ClientUsageAttributesDeviceUsage DeviceUsage { get; set; }

		/// <summary>
		/// Client tenant's domain prefix/name
		/// </summary>
		/// <value>Client tenant's domain prefix/name</value>
		[DataMember(Name = "domainPrefix", EmitDefaultValue = false)]
		public string DomainPrefix { get; set; }

		/// <summary>
		/// Gets or Sets UsagePeriod
		/// </summary>
		[DataMember(Name = "usagePeriod", EmitDefaultValue = false)]
		public ClientUsageAttributesUsagePeriod UsagePeriod { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ClientUsageAttributes {\n");
			sb.Append("  BillableDays: ").Append(BillableDays).Append("\n");
			sb.Append("  ClientUsage: ").Append(ClientUsage).Append("\n");
			sb.Append("  DeviceUsage: ").Append(DeviceUsage).Append("\n");
			sb.Append("  DomainPrefix: ").Append(DomainPrefix).Append("\n");
			sb.Append("  UsagePeriod: ").Append(UsagePeriod).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}