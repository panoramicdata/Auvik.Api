using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The components of a device
	/// </summary>
	[DataContract]
	public class DeviceDetailsRelationshipsComponents
	{
		/// <summary>
		/// A component resource object
		/// </summary>
		/// <value>A component resource object</value>
		[DataMember(Name="data", EmitDefaultValue=false)]
		public List<DeviceDetailsRelationshipsComponentsData> Data { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceDetailsRelationshipsComponents {\n");
			sb.Append("  Data: ").Append(Data).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
