using System.Text;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// Pagination related links
	/// </summary>
	[DataContract]
	public class DeviceInfoReadMultipleLinks
	{
		/// <summary>
		/// First page in the data set
		/// </summary>
		/// <value>First page in the data set</value>
		[DataMember(Name="first", EmitDefaultValue=false)]
		public string First { get; set; }

		/// <summary>
		/// Last page in the data set
		/// </summary>
		/// <value>Last page in the data set</value>
		[DataMember(Name="last", EmitDefaultValue=false)]
		public string Last { get; set; }

		/// <summary>
		/// Next page in the data set
		/// </summary>
		/// <value>Next page in the data set</value>
		[DataMember(Name="next", EmitDefaultValue=false)]
		public string Next { get; set; }

		/// <summary>
		/// Previous page in the data set
		/// </summary>
		/// <value>Previous page in the data set</value>
		[DataMember(Name="prev", EmitDefaultValue=false)]
		public string Prev { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceInfoReadMultipleLinks {\n");
			sb.Append("  First: ").Append(First).Append("\n");
			sb.Append("  Last: ").Append(Last).Append("\n");
			sb.Append("  Next: ").Append(Next).Append("\n");
			sb.Append("  Prev: ").Append(Prev).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
