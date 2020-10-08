using System.Runtime.Serialization;
using System.Text;

namespace Auvik.Api.Data
{
	/// <summary>
	/// Links relating to this component
	/// </summary>
	[DataContract]
	public class ComponentStatisticsRelationshipsComponentDataLinks
	{
		/// <summary>
		/// Link to this component's dashboard in Auvik
		/// </summary>
		/// <value>Link to this component's dashboard in Auvik</value>
		[DataMember(Name = "dashboard", EmitDefaultValue = false)]
		public string Dashboard { get; set; }

		/// <summary>
		/// Link to this component's parent device dashboard in Auvik
		/// </summary>
		/// <value>Link to this component's parent device dashboard in Auvik</value>
		[DataMember(Name = "parentDevice", EmitDefaultValue = false)]
		public string ParentDevice { get; set; }

		/// <summary>
		/// Link to this set of component info
		/// </summary>
		/// <value>Link to this set of component info</value>
		[DataMember(Name = "self", EmitDefaultValue = false)]
		public string Self { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ComponentStatisticsRelationshipsComponentDataLinks {\n");
			sb.Append("  Dashboard: ").Append(Dashboard).Append("\n");
			sb.Append("  ParentDevice: ").Append(ParentDevice).Append("\n");
			sb.Append("  Self: ").Append(Self).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}