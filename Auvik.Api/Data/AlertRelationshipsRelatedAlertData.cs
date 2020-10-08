using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
using System.Text;

namespace Auvik.Api.Data
{
	/// <summary>
	/// This alert associated to the related alert
	/// </summary>
	[DataContract]
	public class AlertRelationshipsRelatedAlertData
	{
		/// <summary>
		/// The type of object in the api
		/// </summary>
		/// <value>The type of object in the api</value>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum TypeEnum
		{

			/// <summary>
			/// Enum Alert for "alert"
			/// </summary>
			[EnumMember(Value = "alert")]
			Alert
		}

		/// <summary>
		/// The type of object in the api
		/// </summary>
		/// <value>The type of object in the api</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }

		/// <summary>
		/// Gets or Sets Attributes
		/// </summary>
		[DataMember(Name = "attributes", EmitDefaultValue = false)]
		public AlertRelationshipsRelatedAlertDataAttributes Attributes { get; set; }

		/// <summary>
		/// The unique identifier for this alert
		/// </summary>
		/// <value>The unique identifier for this alert</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		/// Gets or Sets Links
		/// </summary>
		[DataMember(Name = "links", EmitDefaultValue = false)]
		public AlertRelationshipsRelatedAlertDataLinks Links { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AlertRelationshipsRelatedAlertData {\n");
			sb.Append("  Attributes: ").Append(Attributes).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Links: ").Append(Links).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}