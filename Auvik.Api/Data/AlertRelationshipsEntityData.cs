using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
using System.Text;

namespace Auvik.Api.Data
{
	/// <summary>
	/// An entity resource object
	/// </summary>
	[DataContract]
	public class AlertRelationshipsEntityData
	{
		/// <summary>
		/// The type of object in the api
		/// </summary>
		/// <value>The type of object in the api</value>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum TypeEnum
		{

			/// <summary>
			/// Enum Interface for "interface"
			/// </summary>
			[EnumMember(Value = "interface")]
			Interface,

			/// <summary>
			/// Enum Device for "device"
			/// </summary>
			[EnumMember(Value = "device")]
			Device,

			/// <summary>
			/// Enum Network for "network"
			/// </summary>
			[EnumMember(Value = "network")]
			Network
		}

		/// <summary>
		/// The type of object in the api
		/// </summary>
		/// <value>The type of object in the api</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }

		/// <summary>
		/// The unique identifier for this entity
		/// </summary>
		/// <value>The unique identifier for this entity</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		/// Gets or Sets Links
		/// </summary>
		[DataMember(Name = "links", EmitDefaultValue = false)]
		public AlertRelationshipsEntityDataLinks Links { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AlertRelationshipsEntityData {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Links: ").Append(Links).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}