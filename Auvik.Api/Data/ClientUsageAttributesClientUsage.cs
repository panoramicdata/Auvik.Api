using System.Runtime.Serialization;
using System.Text;

namespace Auvik.Api.Data
{
	/// <summary>
	/// Roll up of client usage for this client (and its children if a multi-client)
	/// </summary>
	[DataContract]
	public class ClientUsageAttributesClientUsage
	{
		/// <summary>
		/// Average billable client days for this client (and its children) across the usage period
		/// </summary>
		/// <value>Average billable client days for this client (and its children) across the usage period</value>
		[DataMember(Name = "averagedDays", EmitDefaultValue = false)]
		public decimal? AveragedDays { get; set; }

		/// <summary>
		/// Total billable client days for this client (and its children) across the usage period
		/// </summary>
		/// <value>Total billable client days for this client (and its children) across the usage period</value>
		[DataMember(Name = "totalDays", EmitDefaultValue = false)]
		public decimal? TotalDays { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ClientUsageAttributesClientUsage {\n");
			sb.Append("  AveragedDays: ").Append(AveragedDays).Append("\n");
			sb.Append("  TotalDays: ").Append(TotalDays).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}