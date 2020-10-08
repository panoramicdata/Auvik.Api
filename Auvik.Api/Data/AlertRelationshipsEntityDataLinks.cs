using System.Runtime.Serialization;
using System.Text;

namespace Auvik.Api.Data
{
	/// <summary>
	/// Links relating to this entity
	/// </summary>
	[DataContract]
	public class AlertRelationshipsEntityDataLinks
	{
		/// <summary>
		/// Link to this interface's dashboard in the Auvik UI
		/// </summary>
		/// <value>Link to this interface's dashboard in the Auvik UI</value>
		[DataMember(Name = "dashboard", EmitDefaultValue = false)]
		public string Dashboard { get; set; }

		/// <summary>
		/// Link to this set of network info
		/// </summary>
		/// <value>Link to this set of network info</value>
		[DataMember(Name = "self", EmitDefaultValue = false)]
		public string Self { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AlertRelationshipsEntityDataLinks {\n");
			sb.Append("  Dashboard: ").Append(Dashboard).Append("\n");
			sb.Append("  Self: ").Append(Self).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}