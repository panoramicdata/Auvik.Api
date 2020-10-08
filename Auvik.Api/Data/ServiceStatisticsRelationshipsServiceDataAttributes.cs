using System.Text;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The type-specific properties of the service
	/// </summary>
	[DataContract]
	public class ServiceStatisticsRelationshipsServiceDataAttributes
	{
		/// <summary>
		/// A description of the service
		/// </summary>
		/// <value>A description of the service</value>
		[DataMember(Name="serviceName", EmitDefaultValue=false)]
		public string ServiceName { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ServiceStatisticsRelationshipsServiceDataAttributes {\n");
			sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
