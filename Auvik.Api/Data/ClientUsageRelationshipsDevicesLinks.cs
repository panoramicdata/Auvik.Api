using System.Runtime.Serialization;
using System.Text;

namespace Auvik.Api.Data
{
	/// <summary>
	/// Links relating to this device's usage
	/// </summary>
	[DataContract]
	public class ClientUsageRelationshipsDevicesLinks
	{
		/// <summary>
		/// Link to this device's record in the Device Info API
		/// </summary>
		/// <value>Link to this device's record in the Device Info API</value>
		[DataMember(Name = "deviceRecord", EmitDefaultValue = false)]
		public string DeviceRecord { get; set; }

		/// <summary>
		/// Link to this device's usage in the Usage API
		/// </summary>
		/// <value>Link to this device's usage in the Usage API</value>
		[DataMember(Name = "self", EmitDefaultValue = false)]
		public string Self { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ClientUsageRelationshipsDevicesLinks {\n");
			sb.Append("  DeviceRecord: ").Append(DeviceRecord).Append("\n");
			sb.Append("  Self: ").Append(Self).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}