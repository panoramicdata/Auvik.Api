using System.IO;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The type-specific properties of the connected device object returned
	/// </summary>
	[DataContract]
	public class DeviceDetailsRelationshipsConnectedDevicesAttributes
	{
		/// <summary>
		/// Connected device's name
		/// </summary>
		/// <value>Connected device's name</value>
		[DataMember(Name="deviceName", EmitDefaultValue=false)]
		public string DeviceName { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceDetailsRelationshipsConnectedDevicesAttributes {\n");
			sb.Append("  DeviceName: ").Append(DeviceName).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
