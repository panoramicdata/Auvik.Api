using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Auvik.Api.Data
{
	/// <summary>
	/// InterfaceRelationshipsConnectedToData
	/// </summary>
	[DataContract]
	public class InterfaceRelationshipsConnectedToData
	{
		/// <summary>
		/// The type of the object
		/// </summary>
		/// <value>The type of the object</value>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum TypeEnum
		{

			/// <summary>
			/// Enum Interface for "interface"
			/// </summary>
			[EnumMember(Value = "interface")]
			Interface
		}

		/// <summary>
		/// The type of the object
		/// </summary>
		/// <value>The type of the object</value>
		[DataMember(Name="type", EmitDefaultValue=false)]
		public TypeEnum? Type { get; set; }

		/// <summary>
		/// This interface's ID
		/// </summary>
		/// <value>This interface's ID</value>
		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		/// <summary>
		/// Gets or Sets Links
		/// </summary>
		[DataMember(Name="links", EmitDefaultValue=false)]
		public InterfaceRelationshipsConnectedToLinks Links { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class InterfaceRelationshipsConnectedToData {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Links: ").Append(Links).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
