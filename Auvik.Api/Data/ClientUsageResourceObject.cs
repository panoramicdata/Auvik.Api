using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
using System.Text;

namespace Auvik.Api.Data
{
	/// <summary>
	/// Client usage resource object
	/// </summary>
	[DataContract]
	public class ClientUsageResourceObject
	{
		/// <summary>
		/// The type of this resource object
		/// </summary>
		/// <value>The type of this resource object</value>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum TypeEnum
		{

			/// <summary>
			/// Enum ClientUsage for "clientUsage"
			/// </summary>
			[EnumMember(Value = "clientUsage")]
			ClientUsage
		}

		/// <summary>
		/// The type of this resource object
		/// </summary>
		/// <value>The type of this resource object</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }

		/// <summary>
		/// Gets or Sets Attributes
		/// </summary>
		[DataMember(Name = "attributes", EmitDefaultValue = false)]
		public ClientUsageAttributes Attributes { get; set; }

		/// <summary>
		/// Client tenant's ID
		/// </summary>
		/// <value>Client tenant's ID</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		/// Gets or Sets Links
		/// </summary>
		[DataMember(Name = "links", EmitDefaultValue = false)]
		public ClientUsageResourceObjectLinks Links { get; set; }

		/// <summary>
		/// Gets or Sets Relationships
		/// </summary>
		[DataMember(Name = "relationships", EmitDefaultValue = false)]
		public ClientUsageRelationships Relationships { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ClientUsageResourceObject {\n");
			sb.Append("  Attributes: ").Append(Attributes).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Links: ").Append(Links).Append("\n");
			sb.Append("  Relationships: ").Append(Relationships).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}