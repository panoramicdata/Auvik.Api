using System.Runtime.Serialization;
using System.Text;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The type-specific properties of the device usage object returned
	/// </summary>
	[DataContract]
	public class ClientUsageRelationshipsClientsAttributes
	{
		/// <summary>
		/// Client tenant's domain prefix/name
		/// </summary>
		/// <value>Client tenant's domain prefix/name</value>
		[DataMember(Name = "domainPrefix", EmitDefaultValue = false)]
		public string DomainPrefix { get; set; }

		/// <summary>
		/// Total billable days for this client across the usage period
		/// </summary>
		/// <value>Total billable days for this client across the usage period</value>
		[DataMember(Name = "totalBillableDays", EmitDefaultValue = false)]
		public decimal? TotalBillableDays { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ClientUsageRelationshipsClientsAttributes {\n");
			sb.Append("  DomainPrefix: ").Append(DomainPrefix).Append("\n");
			sb.Append("  TotalBillableDays: ").Append(TotalBillableDays).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}