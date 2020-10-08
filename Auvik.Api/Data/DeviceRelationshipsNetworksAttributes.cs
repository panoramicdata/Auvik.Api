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
	public class DeviceRelationshipsNetworksAttributes
	{
		/// <summary>
		/// Identifier of the network, usually an IP/subnet or an SSID
		/// </summary>
		/// <value>Identifier of the network, usually an IP/subnet or an SSID</value>
		[DataMember(Name="networkName", EmitDefaultValue=false)]
		public string NetworkName { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceRelationshipsNetworksAttributes {\n");
			sb.Append("  NetworkName: ").Append(NetworkName).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
