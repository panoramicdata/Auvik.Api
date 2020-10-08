using System.IO;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The type-specific properties of the interfaces object returned
	/// </summary>
	[DataContract]
	public class DeviceDetailsRelationshipsInterfacesAttributes
	{
		/// <summary>
		/// This interface's name
		/// </summary>
		/// <value>This interface's name</value>
		[DataMember(Name="interfaceName", EmitDefaultValue=false)]
		public string InterfaceName { get; set; }

		/// <summary>
		/// The MAC address of this interface
		/// </summary>
		/// <value>The MAC address of this interface</value>
		[DataMember(Name="macAddress", EmitDefaultValue=false)]
		public string MacAddress { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceDetailsRelationshipsInterfacesAttributes {\n");
			sb.Append("  InterfaceName: ").Append(InterfaceName).Append("\n");
			sb.Append("  MacAddress: ").Append(MacAddress).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
