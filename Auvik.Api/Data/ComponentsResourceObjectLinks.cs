using System.Runtime.Serialization;
using System.Text;

namespace Auvik.Api.Data
{
	/// <summary>
	/// List of links relating to this component
	/// </summary>
	[DataContract]
	public class ComponentsResourceObjectLinks
	{
		/// <summary>
		/// Link to this component's dashboard in Auvik
		/// </summary>
		/// <value>Link to this component's dashboard in Auvik</value>
		[DataMember(Name = "dashboard", EmitDefaultValue = false)]
		public string Dashboard { get; set; }

		/// <summary>
		/// Link to this component
		/// </summary>
		/// <value>Link to this component</value>
		[DataMember(Name = "self", EmitDefaultValue = false)]
		public string Self { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ComponentsResourceObjectLinks {\n");
			sb.Append("  Dashboard: ").Append(Dashboard).Append("\n");
			sb.Append("  Self: ").Append(Self).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}