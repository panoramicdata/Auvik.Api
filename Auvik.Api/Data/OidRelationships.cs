using System.Text;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// This OID's relationships to other resources
	/// </summary>
	[DataContract]
	public class OidRelationships
	{
		/// <summary>
		/// Gets or Sets Device
		/// </summary>
		[DataMember(Name="device", EmitDefaultValue=false)]
		public OidRelationshipsDevice Device { get; set; }

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
			sb.Append("class OidRelationships {\n");
			sb.Append("  Device: ").Append(Device).Append("\n");
			sb.Append("  Tenant: ").Append(Tenant).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
