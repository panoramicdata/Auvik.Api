using System.Text;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// List of links relating to this network
	/// </summary>
	[DataContract]
	public class NetworkDetailsResourceObjectLinks
	{
		/// <summary>
		/// Link to this network's dashboard in Auvik
		/// </summary>
		/// <value>Link to this network's dashboard in Auvik</value>
		[DataMember(Name="dashboard", EmitDefaultValue=false)]
		public string Dashboard { get; set; }

		/// <summary>
		/// Link to this set of network details
		/// </summary>
		/// <value>Link to this set of network details</value>
		[DataMember(Name="self", EmitDefaultValue=false)]
		public string Self { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class NetworkDetailsResourceObjectLinks {\n");
			sb.Append("  Dashboard: ").Append(Dashboard).Append("\n");
			sb.Append("  Self: ").Append(Self).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
