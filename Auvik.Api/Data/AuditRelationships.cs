using System.Runtime.Serialization;
using System.Text;

namespace Auvik.Api.Data
{
	/// <summary>
	/// This entity audit's relationships to other resources
	/// </summary>
	[DataContract]
	public class AuditRelationships
	{
		/// <summary>
		/// Gets or Sets Device
		/// </summary>
		[DataMember(Name = "device", EmitDefaultValue = false)]
		public AuditRelationshipsDevice Device { get; set; }

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
			sb.Append("class AuditRelationships {\n");
			sb.Append("  Device: ").Append(Device).Append("\n");
			sb.Append("  Tenant: ").Append(Tenant).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}