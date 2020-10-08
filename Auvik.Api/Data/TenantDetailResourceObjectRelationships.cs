using System.Text;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The type specific relationship of the legacy tenants object to other entities
	/// </summary>
	[DataContract]
	public class TenantDetailResourceObjectRelationships
	{
		/// <summary>
		/// Gets or Sets Authorizations
		/// </summary>
		[DataMember(Name="authorizations", EmitDefaultValue=false)]
		public TenantDetailResourceObjectRelationshipsAuthorizations Authorizations { get; set; }

		/// <summary>
		/// Gets or Sets Parent
		/// </summary>
		[DataMember(Name="parent", EmitDefaultValue=false)]
		public TenantDetailResourceObjectRelationshipsParent Parent { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TenantDetailResourceObjectRelationships {\n");
			sb.Append("  Authorizations: ").Append(Authorizations).Append("\n");
			sb.Append("  Parent: ").Append(Parent).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
