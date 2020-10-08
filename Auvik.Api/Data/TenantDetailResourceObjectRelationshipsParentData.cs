using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The parent tenant data object of the tenant selected
	/// </summary>
	[DataContract]
	public class TenantDetailResourceObjectRelationshipsParentData
	{
		/// <summary>
		/// The type of object in the API.
		/// </summary>
		/// <value>The type of object in the API.</value>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum TypeEnum
		{

			/// <summary>
			/// Enum Tenants for "tenants"
			/// </summary>
			[EnumMember(Value = "tenants")]
			Tenants
		}

		/// <summary>
		/// The type of object in the API.
		/// </summary>
		/// <value>The type of object in the API.</value>
		[DataMember(Name="type", EmitDefaultValue=false)]
		public TypeEnum? Type { get; set; }

		/// <summary>
		/// The unique identifier for a tenant
		/// </summary>
		/// <value>The unique identifier for a tenant</value>
		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TenantDetailResourceObjectRelationshipsParentData {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
