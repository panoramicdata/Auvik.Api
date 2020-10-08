using System.Runtime.Serialization;
using System.Text;

namespace Auvik.Api.Data
{
	/// <summary>
	/// This configurations relationships to other resources
	/// </summary>
	[DataContract]
	public class ConfigRelationships
	{
		/// <summary>
		/// Gets or Sets Device
		/// </summary>
		[DataMember(Name = "device", EmitDefaultValue = false)]
		public DeviceLifecycleRelationshipsDevice Device { get; set; }

		/// <summary>
		/// Gets or Sets Tenant
		/// </summary>
		[DataMember(Name = "tenant", EmitDefaultValue = false)]
		public Tenant Tenant { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConfigRelationships {\n");
			sb.Append("  Device: ").Append(Device).Append("\n");
			sb.Append("  Tenant: ").Append(Tenant).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
