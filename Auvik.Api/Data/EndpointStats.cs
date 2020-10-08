using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// EndpointStats
	/// </summary>
	[DataContract]
	public class EndpointStats
	{
		/// <summary>
		/// ID of the endpoint
		/// </summary>
		/// <value>ID of the endpoint</value>
		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		/// <summary>
		/// IP Address of the endpoint
		/// </summary>
		/// <value>IP Address of the endpoint</value>
		[DataMember(Name="ipAddress", EmitDefaultValue=false)]
		public string IpAddress { get; set; }

		/// <summary>
		/// The list of statistics reported for the endpoint
		/// </summary>
		/// <value>The list of statistics reported for the endpoint</value>
		[DataMember(Name="stats", EmitDefaultValue=false)]
		public List<StatItem> Stats { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class EndpointStats {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
			sb.Append("  Stats: ").Append(Stats).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
