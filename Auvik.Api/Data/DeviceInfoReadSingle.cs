using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// Root level object per the json-api spec
	/// </summary>
	[DataContract]
	public class DeviceInfoReadSingle
	{
		/// <summary>
		/// Gets or Sets Data
		/// </summary>
		[DataMember(Name="data", EmitDefaultValue=false)]
		public DevicesResourceObject Data { get; set; }

		/// <summary>
		/// Gets or Sets Included
		/// </summary>
		[DataMember(Name="included", EmitDefaultValue=false)]
		public List<DeviceDetailsResourceObject> Included { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceInfoReadSingle {\n");
			sb.Append("  Data: ").Append(Data).Append("\n");
			sb.Append("  Included: ").Append(Included).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
