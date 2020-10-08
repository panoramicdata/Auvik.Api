using System.Text;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// List of links relating to this device
	/// </summary>
	[DataContract]
	public class DeviceExtendedDetailsDeviceLinks
	{
		/// <summary>
		/// Link to this device's device info
		/// </summary>
		/// <value>Link to this device's device info</value>
		[DataMember(Name="info", EmitDefaultValue=false)]
		public string Info { get; set; }

		/// <summary>
		/// Link to this device's extended details
		/// </summary>
		/// <value>Link to this device's extended details</value>
		[DataMember(Name="self", EmitDefaultValue=false)]
		public string Self { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceExtendedDetailsDeviceLinks {\n");
			sb.Append("  Info: ").Append(Info).Append("\n");
			sb.Append("  Self: ").Append(Self).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
