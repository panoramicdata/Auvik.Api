using System.Runtime.Serialization;
using System.Text;

namespace Auvik.Api.Data
{
	/// <summary>
	/// This entity associated to the alert message
	/// </summary>
	[DataContract]
	public class AlertRelationshipsEntity
	{
		/// <summary>
		/// Gets or Sets Data
		/// </summary>
		[DataMember(Name = "data", EmitDefaultValue = false)]
		public AlertRelationshipsEntityData Data { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AlertRelationshipsEntity {\n");
			sb.Append("  Data: ").Append(Data).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}