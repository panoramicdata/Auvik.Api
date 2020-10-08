using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The type of statistic that was returned
	/// </summary>
	[DataContract]
	public class StatType
	{
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class StatType {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
