using System.Runtime.Serialization;
using System.Text;

namespace Auvik.Api.Data
{
	/// <summary>
	/// Links relating to this component statistics
	/// </summary>
	[DataContract]
	public class ComponentStatisticsResourceObjectLinks
	{
		/// <summary>
		/// Link to this component's record in the Component Info API
		/// </summary>
		/// <value>Link to this component's record in the Component Info API</value>
		[DataMember(Name = "dashboard", EmitDefaultValue = false)]
		public string Dashboard { get; set; }

		/// <summary>
		/// Link used to get this result set
		/// </summary>
		/// <value>Link used to get this result set</value>
		[DataMember(Name = "self", EmitDefaultValue = false)]
		public string Self { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ComponentStatisticsResourceObjectLinks {\n");
			sb.Append("  Dashboard: ").Append(Dashboard).Append("\n");
			sb.Append("  Self: ").Append(Self).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}