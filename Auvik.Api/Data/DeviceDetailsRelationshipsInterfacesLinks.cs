using System.Text;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// Links relating to this interface
	/// </summary>
	[DataContract]
	public class DeviceDetailsRelationshipsInterfacesLinks
	{
		/// <summary>
		/// Link to this interface's dashboard in Auvik
		/// </summary>
		/// <value>Link to this interface's dashboard in Auvik</value>
		[DataMember(Name="dashboard", EmitDefaultValue=false)]
		public string Dashboard { get; set; }

		/// <summary>
		/// Link to this interface
		/// </summary>
		/// <value>Link to this interface</value>
		[DataMember(Name="self", EmitDefaultValue=false)]
		public string Self { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceDetailsRelationshipsInterfacesLinks {\n");
			sb.Append("  Dashboard: ").Append(Dashboard).Append("\n");
			sb.Append("  Self: ").Append(Self).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
