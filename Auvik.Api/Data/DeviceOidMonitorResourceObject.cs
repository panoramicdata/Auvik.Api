using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The template for a resource object representing an Auvik device OID
	/// </summary>
	[DataContract]
	public class DeviceOidMonitorResourceObject
	{
		/// <summary>
		/// The type of object in the API
		/// </summary>
		/// <value>The type of object in the API</value>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum TypeEnum
		{

			/// <summary>
			/// Enum DeviceOidMonitor for "deviceOidMonitor"
			/// </summary>
			[EnumMember(Value = "deviceOidMonitor")]
			DeviceOidMonitor
		}

		/// <summary>
		/// The type of object in the API
		/// </summary>
		/// <value>The type of object in the API</value>
		[DataMember(Name="type", EmitDefaultValue=false)]
		public TypeEnum? Type { get; set; }

		/// <summary>
		/// Gets or Sets Attributes
		/// </summary>
		[DataMember(Name="attributes", EmitDefaultValue=false)]
		public OidAttributes Attributes { get; set; }

		/// <summary>
		/// The unique identifier for an OID
		/// </summary>
		/// <value>The unique identifier for an OID</value>
		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		/// <summary>
		/// Gets or Sets Links
		/// </summary>
		[DataMember(Name="links", EmitDefaultValue=false)]
		public DeviceOidMonitorResourceObjectLinks Links { get; set; }

		/// <summary>
		/// Gets or Sets Relationships
		/// </summary>
		[DataMember(Name="relationships", EmitDefaultValue=false)]
		public OidRelationships Relationships { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceOidMonitorResourceObject {\n");
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
