using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The The authorization container object of the tenant selected
	/// </summary>
	[DataContract]
	public class TenantDetailResourceObjectRelationshipsAuthorizations
	{
		/// <summary>
		/// The list of authorization to the tenant selected
		/// </summary>
		/// <value>The list of authorization to the tenant selected</value>
		[DataMember(Name="data", EmitDefaultValue=false)]
		public List<TenantDetailResourceObjectRelationshipsAuthorizationsData> Data { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TenantDetailResourceObjectRelationshipsAuthorizations {\n");
			sb.Append("  Data: ").Append(Data).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
