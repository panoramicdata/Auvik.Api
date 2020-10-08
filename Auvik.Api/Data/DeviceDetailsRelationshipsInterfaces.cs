using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// This device's interfaces
	/// </summary>
	[DataContract]
	public class DeviceDetailsRelationshipsInterfaces
	{
		/// <summary>
		/// An interface resource object
		/// </summary>
		/// <value>An interface resource object</value>
		[DataMember(Name="data", EmitDefaultValue=false)]
		public List<DeviceDetailsRelationshipsInterfacesData> Data { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceDetailsRelationshipsInterfaces {\n");
			sb.Append("  Data: ").Append(Data).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
