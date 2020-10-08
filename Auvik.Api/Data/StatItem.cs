using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// StatItem
	/// </summary>
	[DataContract]
	public class StatItem
	{
		/// <summary>
		/// An list of rows of statistics data, as described by the legend
		/// </summary>
		/// <value>An list of rows of statistics data, as described by the legend</value>
		[DataMember(Name="data", EmitDefaultValue=false)]
		public List<List<decimal?>> Data { get; set; }

		/// <summary>
		/// Index for multi-part statistics
		/// </summary>
		/// <value>Index for multi-part statistics</value>
		[DataMember(Name="index", EmitDefaultValue=false)]
		public string Index { get; set; }

		/// <summary>
		/// A description of the stats data columns
		/// </summary>
		/// <value>A description of the stats data columns</value>
		[DataMember(Name="legend", EmitDefaultValue=false)]
		public List<string> Legend { get; set; }

		/// <summary>
		/// Name of the statistic
		/// </summary>
		/// <value>Name of the statistic</value>
		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }

		/// <summary>
		/// Unit type for each stats data column
		/// </summary>
		/// <value>Unit type for each stats data column</value>
		[DataMember(Name="unit", EmitDefaultValue=false)]
		public List<string> Unit { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class StatItem {\n");
			sb.Append("  Data: ").Append(Data).Append("\n");
			sb.Append("  Index: ").Append(Index).Append("\n");
			sb.Append("  Legend: ").Append(Legend).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Unit: ").Append(Unit).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
