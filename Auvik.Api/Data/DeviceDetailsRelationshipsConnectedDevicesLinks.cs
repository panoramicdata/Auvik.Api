using System.Text;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// Links relating to this connected device
	/// </summary>
	[DataContract]
	public class DeviceDetailsRelationshipsConnectedDevicesLinks
	{
		/// <summary>
		/// Link to this connected device's dashboard in Auvik
		/// </summary>
		/// <value>Link to this connected device's dashboard in Auvik</value>
		[DataMember(Name="dashboard", EmitDefaultValue=false)]
		public string Dashboard { get; set; }

		/// <summary>
		/// Link to this connected device
		/// </summary>
		/// <value>Link to this connected device</value>
		[DataMember(Name="self", EmitDefaultValue=false)]
		public string Self { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceDetailsRelationshipsConnectedDevicesLinks {\n");
			sb.Append("  Dashboard: ").Append(Dashboard).Append("\n");
			sb.Append("  Self: ").Append(Self).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
