using System.Text;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// This device's relationships to other resources
	/// </summary>
	[DataContract]
	public class DeviceRelationships
	{
		/// <summary>
		/// Gets or Sets DeviceDetail
		/// </summary>
		[DataMember(Name="deviceDetail", EmitDefaultValue=false)]
		public DeviceRelationshipsDeviceDetail DeviceDetail { get; set; }

		/// <summary>
		/// Gets or Sets Networks
		/// </summary>
		[DataMember(Name="networks", EmitDefaultValue=false)]
		public DeviceRelationshipsNetworks Networks { get; set; }

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
			sb.Append("class DeviceRelationships {\n");
			sb.Append("  DeviceDetail: ").Append(DeviceDetail).Append("\n");
			sb.Append("  Networks: ").Append(Networks).Append("\n");
			sb.Append("  Tenant: ").Append(Tenant).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
