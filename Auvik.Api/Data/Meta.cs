using System.Text;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The meta object that contains non-standard meta-information
	/// </summary>
	[DataContract]
	public class Meta
	{
		/// <summary>
		/// Total page count.
		/// </summary>
		/// <value>Total page count.</value>
		[DataMember(Name="totalPages", EmitDefaultValue=false)]
		public decimal? TotalPages { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Meta {\n");
			sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
