using System.Text;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// Interface statistics object's relationships to other resources
	/// </summary>
	[DataContract]
	public class InterfaceStatisticsRelationships
	{
		/// <summary>
		/// Gets or Sets _Interface
		/// </summary>
		[DataMember(Name="interface", EmitDefaultValue=false)]
		public InterfaceStatisticsRelationshipsInterface _Interface { get; set; }

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
			sb.Append("class InterfaceStatisticsRelationships {\n");
			sb.Append("  _Interface: ").Append(_Interface).Append("\n");
			sb.Append("  Tenant: ").Append(Tenant).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
