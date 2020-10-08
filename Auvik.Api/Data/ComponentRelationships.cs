using System.Runtime.Serialization;
using System.Text;

namespace Auvik.Api.Data
{
	/// <summary>
	/// This component's relationships to other resources
	/// </summary>
	[DataContract]
	public class ComponentRelationships
	{
		/// <summary>
		/// Gets or Sets ParentDevice
		/// </summary>
		[DataMember(Name = "parentDevice", EmitDefaultValue = false)]
		public ComponentRelationshipsParentDevice ParentDevice { get; set; }

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
			sb.Append("class ComponentRelationships {\n");
			sb.Append("  ParentDevice: ").Append(ParentDevice).Append("\n");
			sb.Append("  Tenant: ").Append(Tenant).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}