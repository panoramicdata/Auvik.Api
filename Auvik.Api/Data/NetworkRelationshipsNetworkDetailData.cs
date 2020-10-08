using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Auvik.Api.Data
{
	/// <summary>
	/// A network detail object
	/// </summary>
	[DataContract]
	public class NetworkRelationshipsNetworkDetailData
	{
		/// <summary>
		/// The type of object in the API
		/// </summary>
		/// <value>The type of object in the API</value>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum TypeEnum
		{

			/// <summary>
			/// Enum NetworkDetail for "networkDetail"
			/// </summary>
			[EnumMember(Value = "networkDetail")]
			NetworkDetail
		}

		/// <summary>
		/// The type of object in the API
		/// </summary>
		/// <value>The type of object in the API</value>
		[DataMember(Name="type", EmitDefaultValue=false)]
		public TypeEnum? Type { get; set; }

		/// <summary>
		/// The unique identifier for this network
		/// </summary>
		/// <value>The unique identifier for this network</value>
		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		/// <summary>
		/// Gets or Sets Links
		/// </summary>
		[DataMember(Name="links", EmitDefaultValue=false)]
		public NetworkRelationshipsNetworkDetailDataLinks Links { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class NetworkRelationshipsNetworkDetailData {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Links: ").Append(Links).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
