using System.Text;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// Client usage object's relationships to other resources
	/// </summary>
	[DataContract]
	public class DeviceUsageRelationships
	{
		/// <summary>
		/// Gets or Sets _Client
		/// </summary>
		[DataMember(Name="client", EmitDefaultValue=false)]
		public DeviceUsageRelationshipsClient _Client { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceUsageRelationships {\n");
			sb.Append("  _Client: ").Append(_Client).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
