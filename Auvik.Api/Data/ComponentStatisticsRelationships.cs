using System.Runtime.Serialization;
using System.Text;

namespace Auvik.Api.Data
{
	/// <summary>
	/// Component statistics object's relationships to other resources
	/// </summary>
	[DataContract]
	public class ComponentStatisticsRelationships
	{
		/// <summary>
		/// Gets or Sets Component
		/// </summary>
		[DataMember(Name = "component", EmitDefaultValue = false)]
		public ComponentStatisticsRelationshipsComponent Component { get; set; }

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
			sb.Append("class ComponentStatisticsRelationships {\n");
			sb.Append("  Component: ").Append(Component).Append("\n");
			sb.Append("  Tenant: ").Append(Tenant).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}