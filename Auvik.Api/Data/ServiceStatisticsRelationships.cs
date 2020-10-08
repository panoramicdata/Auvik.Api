using System.Text;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// Service statistics object's relationships to other resources
	/// </summary>
	[DataContract]
	public class ServiceStatisticsRelationships
	{
		/// <summary>
		/// Gets or Sets Service
		/// </summary>
		[DataMember(Name="service", EmitDefaultValue=false)]
		public ServiceStatisticsRelationshipsService Service { get; set; }

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
			sb.Append("class ServiceStatisticsRelationships {\n");
			sb.Append("  Service: ").Append(Service).Append("\n");
			sb.Append("  Tenant: ").Append(Tenant).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
