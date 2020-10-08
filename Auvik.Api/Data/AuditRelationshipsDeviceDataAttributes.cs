using System.Runtime.Serialization;
using System.Text;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The type-specific properties of the device object returned
	/// </summary>
	[DataContract]
	public class AuditRelationshipsDeviceDataAttributes
	{
		/// <summary>
		/// Device's name
		/// </summary>
		/// <value>Device's name</value>
		[DataMember(Name = "deviceName", EmitDefaultValue = false)]
		public string DeviceName { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AuditRelationshipsDeviceDataAttributes {\n");
			sb.Append("  DeviceName: ").Append(DeviceName).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}