using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// Root level object per the json-api spec
	/// </summary>
	[DataContract]
	public class NetworkInfoReadMultiple
	{
		/// <summary>
		/// Gets or Sets Data
		/// </summary>
		[DataMember(Name="data", EmitDefaultValue=false)]
		public List<NetworksResourceObject> Data { get; set; }

		/// <summary>
		/// Gets or Sets Included
		/// </summary>
		[DataMember(Name="included", EmitDefaultValue=false)]
		public List<NetworkDetailsResourceObject> Included { get; set; }

		/// <summary>
		/// Gets or Sets Links
		/// </summary>
		[DataMember(Name="links", EmitDefaultValue=false)]
		public NetworkInfoReadMultipleLinks Links { get; set; }

		/// <summary>
		/// Gets or Sets Meta
		/// </summary>
		[DataMember(Name="meta", EmitDefaultValue=false)]
		public Meta Meta { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class NetworkInfoReadMultiple {\n");
			sb.Append("  Data: ").Append(Data).Append("\n");
			sb.Append("  Included: ").Append(Included).Append("\n");
			sb.Append("  Links: ").Append(Links).Append("\n");
			sb.Append("  Meta: ").Append(Meta).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
