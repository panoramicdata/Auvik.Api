using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The reporting interval for the statistics
	/// </summary>
	[DataContract]
	public class Interval
	{
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Interval {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
