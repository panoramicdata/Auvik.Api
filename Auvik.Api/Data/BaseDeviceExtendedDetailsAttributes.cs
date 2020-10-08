using Newtonsoft.Json;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The type-specific properties of the devices object returned
	/// </summary>
	[DataContract]
	public class BaseDeviceExtendedDetailsAttributes
	{
		/// <summary>
		/// Device's name
		/// </summary>
		/// <value>Device's name</value>
		[DataMember(Name = "deviceName", EmitDefaultValue = false)]
		public string DeviceName { get; set; }

		/// <summary>
		/// When one of this device's attributes was last modified
		/// </summary>
		/// <value>When one of this device's attributes was last modified</value>
		[DataMember(Name = "lastModified", EmitDefaultValue = false)]
		public string LastModified { get; set; }

		/// <summary>
		/// Last seen online date/time of a device
		/// </summary>
		/// <value>Last seen online date/time of a device</value>
		[DataMember(Name = "lastSeenTime", EmitDefaultValue = false)]
		public string LastSeenTime { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class BaseDeviceExtendedDetailsAttributes {\n");
			sb.Append("  DeviceName: ").Append(DeviceName).Append("\n");
			sb.Append("  LastModified: ").Append(LastModified).Append("\n");
			sb.Append("  LastSeenTime: ").Append(LastSeenTime).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}