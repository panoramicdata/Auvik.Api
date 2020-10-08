using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// Root level object per the json-api spec
	/// </summary>
	[DataContract]
	public class DeviceOidMonitorRead
	{
		/// <summary>
		/// Gets or Sets Data
		/// </summary>
		[DataMember(Name="data", EmitDefaultValue=false)]
		public List<DeviceOidMonitorResourceObject> Data { get; set; }

		/// <summary>
		/// Gets or Sets Links
		/// </summary>
		[DataMember(Name="links", EmitDefaultValue=false)]
		public DeviceOidMonitorReadLinks Links { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceOidMonitorRead {\n");
			sb.Append("  Data: ").Append(Data).Append("\n");
			sb.Append("  Links: ").Append(Links).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
