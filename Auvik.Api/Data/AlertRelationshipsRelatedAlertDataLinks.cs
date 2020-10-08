using System.Runtime.Serialization;
using System.Text;

namespace Auvik.Api.Data
{
	/// <summary>
	/// Links relating to this interface
	/// </summary>
	[DataContract]
	public class AlertRelationshipsRelatedAlertDataLinks
	{
		/// <summary>
		/// Link to this interface's dashboard in the Auvik UI
		/// </summary>
		/// <value>Link to this interface's dashboard in the Auvik UI</value>
		[DataMember(Name = "dashboard", EmitDefaultValue = false)]
		public string Dashboard { get; set; }

		/// <summary>
		/// Link to this alert info
		/// </summary>
		/// <value>Link to this alert info</value>
		[DataMember(Name = "self", EmitDefaultValue = false)]
		public string Self { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AlertRelationshipsRelatedAlertDataLinks {\n");
			sb.Append("  Dashboard: ").Append(Dashboard).Append("\n");
			sb.Append("  Self: ").Append(Self).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}