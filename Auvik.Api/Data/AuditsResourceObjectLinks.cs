using System.Runtime.Serialization;
using System.Text;

namespace Auvik.Api.Data
{
	/// <summary>
	/// List of links relating to this entity audit
	/// </summary>
	[DataContract]
	public class AuditsResourceObjectLinks
	{
		/// <summary>
		/// Link to this entity audit
		/// </summary>
		/// <value>Link to this entity audit</value>
		[DataMember(Name = "self", EmitDefaultValue = false)]
		public string Self { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AuditsResourceObjectLinks {\n");
			sb.Append("  Self: ").Append(Self).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}