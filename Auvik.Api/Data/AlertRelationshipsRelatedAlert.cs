using System.Runtime.Serialization;
using System.Text;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The related alert linked to the current one
	/// </summary>
	[DataContract]
	public class AlertRelationshipsRelatedAlert
	{
		/// <summary>
		/// Gets or Sets Data
		/// </summary>
		[DataMember(Name = "data", EmitDefaultValue = false)]
		public AlertRelationshipsRelatedAlertData Data { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AlertRelationshipsRelatedAlert {\n");
			sb.Append("  Data: ").Append(Data).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}