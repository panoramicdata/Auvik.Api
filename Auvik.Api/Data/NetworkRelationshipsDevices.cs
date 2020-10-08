using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// This network's devices
	/// </summary>
	[DataContract]
	public class NetworkRelationshipsDevices
	{
		/// <summary>
		/// A device resource object
		/// </summary>
		/// <value>A device resource object</value>
		[DataMember(Name="data", EmitDefaultValue=false)]
		public List<NetworkRelationshipsDevicesData> Data { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class NetworkRelationshipsDevices {\n");
			sb.Append("  Data: ").Append(Data).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
