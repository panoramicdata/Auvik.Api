using System.Runtime.Serialization;
using System.Text;

namespace Auvik.Api.Data
{
	/// <summary>
	/// Client usage object's relationships to other resources
	/// </summary>
	[DataContract]
	public class ClientUsageRelationships
	{
		/// <summary>
		/// Gets or Sets Clients
		/// </summary>
		[DataMember(Name = "clients", EmitDefaultValue = false)]
		public ClientUsageRelationshipsClients Clients { get; set; }

		/// <summary>
		/// Gets or Sets Devices
		/// </summary>
		[DataMember(Name = "devices", EmitDefaultValue = false)]
		public ClientUsageRelationshipsDevices Devices { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ClientUsageRelationships {\n");
			sb.Append("  Clients: ").Append(Clients).Append("\n");
			sb.Append("  Devices: ").Append(Devices).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}