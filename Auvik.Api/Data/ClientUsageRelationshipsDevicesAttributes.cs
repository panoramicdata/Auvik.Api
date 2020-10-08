using System.Runtime.Serialization;
using System.Text;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The type-specific properties of the device usage object returned
	/// </summary>
	[DataContract]
	public class ClientUsageRelationshipsDevicesAttributes
	{
		/// <summary>
		/// This device's owning client's name/domainPrefix
		/// </summary>
		/// <value>This device's owning client's name/domainPrefix</value>
		[DataMember(Name = "clientName", EmitDefaultValue = false)]
		public string ClientName { get; set; }

		/// <summary>
		/// Device's name
		/// </summary>
		/// <value>Device's name</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Total billable days for this device across the usage period
		/// </summary>
		/// <value>Total billable days for this device across the usage period</value>
		[DataMember(Name = "totalDays", EmitDefaultValue = false)]
		public decimal? TotalDays { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ClientUsageRelationshipsDevicesAttributes {\n");
			sb.Append("  ClientName: ").Append(ClientName).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  TotalDays: ").Append(TotalDays).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}