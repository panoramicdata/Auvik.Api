using System.Text;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The type specific relationship of the tenants object to other entities
	/// </summary>
	[DataContract]
	public class TenantsResourceObjectRelationships
	{
		/// <summary>
		/// Gets or Sets Parent
		/// </summary>
		[DataMember(Name="parent", EmitDefaultValue=false)]
		public TenantsResourceObjectRelationshipsParent Parent { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TenantsResourceObjectRelationships {\n");
			sb.Append("  Parent: ").Append(Parent).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
