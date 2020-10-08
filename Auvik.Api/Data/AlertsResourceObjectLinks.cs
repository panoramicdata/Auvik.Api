using System.Runtime.Serialization;
using System.Text;

namespace Auvik.Api.Data
{
	/// <summary>
	/// List of links relating to this alert
	/// </summary>
	[DataContract]
	public class AlertsResourceObjectLinks
	{
		/// <summary>
		/// Link to this alert's dashboard in the Auvik UI
		/// </summary>
		/// <value>Link to this alert's dashboard in the Auvik UI</value>
		[DataMember(Name = "dashboard", EmitDefaultValue = false)]
		public string Dashboard { get; set; }

		/// <summary>
		/// Link to this alert
		/// </summary>
		/// <value>Link to this alert</value>
		[DataMember(Name = "self", EmitDefaultValue = false)]
		public string Self { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AlertsResourceObjectLinks {\n");
			sb.Append("  Dashboard: ").Append(Dashboard).Append("\n");
			sb.Append("  Self: ").Append(Self).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}