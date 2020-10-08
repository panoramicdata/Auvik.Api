using System.Text;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// This network's relationships to other resources
	/// </summary>
	[DataContract]
	public class NetworkRelationships
	{
		/// <summary>
		/// Gets or Sets Devices
		/// </summary>
		[DataMember(Name="devices", EmitDefaultValue=false)]
		public NetworkRelationshipsDevices Devices { get; set; }

		/// <summary>
		/// Gets or Sets NetworkDetail
		/// </summary>
		[DataMember(Name="networkDetail", EmitDefaultValue=false)]
		public NetworkRelationshipsNetworkDetail NetworkDetail { get; set; }

		/// <summary>
		/// Gets or Sets Tenant
		/// </summary>
		[DataMember(Name="tenant", EmitDefaultValue=false)]
		public Tenant Tenant { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class NetworkRelationships {\n");
			sb.Append("  Devices: ").Append(Devices).Append("\n");
			sb.Append("  NetworkDetail: ").Append(NetworkDetail).Append("\n");
			sb.Append("  Tenant: ").Append(Tenant).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
