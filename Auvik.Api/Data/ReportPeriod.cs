using System.Text;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// Reporting period for the returned statistics
	/// </summary>
	[DataContract]
	public class ReportPeriod
	{
		/// <summary>
		/// Start timestamp for the statistics query
		/// </summary>
		/// <value>Start timestamp for the statistics query</value>
		[DataMember(Name="fromTime", EmitDefaultValue=false)]
		public string FromTime { get; set; }

		/// <summary>
		/// End timestamp for the statistics query
		/// </summary>
		/// <value>End timestamp for the statistics query</value>
		[DataMember(Name="thruTime", EmitDefaultValue=false)]
		public string ThruTime { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ReportPeriod {\n");
			sb.Append("  FromTime: ").Append(FromTime).Append("\n");
			sb.Append("  ThruTime: ").Append(ThruTime).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
