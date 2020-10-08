using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The template for a resource object representing an Auvik tenant
	/// </summary>
	[DataContract]
	public class TenantsResourceObject
	{
		/// <summary>
		/// The type of object in the API.
		/// </summary>
		/// <value>The type of object in the API.</value>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum TypeEnum
		{

			/// <summary>
			/// Enum Tenant for "tenant"
			/// </summary>
			[EnumMember(Value = "tenant")]
			Tenant
		}

		/// <summary>
		/// The type of object in the API.
		/// </summary>
		/// <value>The type of object in the API.</value>
		[DataMember(Name="type", EmitDefaultValue=false)]
		public TypeEnum? Type { get; set; }

		/// <summary>
		/// Gets or Sets Attributes
		/// </summary>
		[DataMember(Name="attributes", EmitDefaultValue=false)]
		public TenantAttributes Attributes { get; set; }

		/// <summary>
		/// The unique identifier for a tenant
		/// </summary>
		/// <value>The unique identifier for a tenant</value>
		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		/// <summary>
		/// Gets or Sets Relationships
		/// </summary>
		[DataMember(Name="relationships", EmitDefaultValue=false)]
		public TenantsResourceObjectRelationships Relationships { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TenantsResourceObject {\n");
			sb.Append("  Attributes: ").Append(Attributes).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Relationships: ").Append(Relationships).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
