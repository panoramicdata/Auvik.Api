using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// Root level object per the json-api spec
	/// </summary>
	[DataContract]
	public class NetworkDetailsReadMultiple
	{
		/// <summary>
		/// Gets or Sets Data
		/// </summary>
		[DataMember(Name="data", EmitDefaultValue=false)]
		public List<NetworkDetailsResourceObject> Data { get; set; }

		/// <summary>
		/// Gets or Sets Links
		/// </summary>
		[DataMember(Name="links", EmitDefaultValue=false)]
		public NetworkDetailsReadMultipleLinks Links { get; set; }

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
			sb.Append("class NetworkDetailsReadMultiple {\n");
			sb.Append("  Data: ").Append(Data).Append("\n");
			sb.Append("  Links: ").Append(Links).Append("\n");
			sb.Append("  Meta: ").Append(Meta).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
