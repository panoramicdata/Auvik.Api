using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Auvik.Api.Data
{
	/// <summary>
	/// List of billable device usage under this client
	/// </summary>
	[DataContract]
	public class ClientUsageRelationshipsDevices
	{
		/// <summary>
		/// A device's usage for the given usage period
		/// </summary>
		/// <value>A device's usage for the given usage period</value>
		[DataMember(Name = "data", EmitDefaultValue = false)]
		public List<ClientUsageRelationshipsDevicesData> Data { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ClientUsageRelationshipsDevices {\n");
			sb.Append("  Data: ").Append(Data).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}