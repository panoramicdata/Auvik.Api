using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Auvik.Api.Data
{
	/// <summary>
	/// Root level object per the json-api spec
	/// </summary>
	[DataContract]
	public class ClientUsageRead
	{
		/// <summary>
		/// Gets or Sets Data
		/// </summary>
		[DataMember(Name = "data", EmitDefaultValue = false)]
		public List<ClientUsageResourceObject> Data { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ClientUsageRead {\n");
			sb.Append("  Data: ").Append(Data).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}