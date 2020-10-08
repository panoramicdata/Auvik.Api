using System.Text;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// A service resource object
	/// </summary>
	[DataContract]
	public class ServiceStatisticsRelationshipsServiceData
	{
		/// <summary>
		/// Gets or Sets Attributes
		/// </summary>
		[DataMember(Name="attributes", EmitDefaultValue=false)]
		public ServiceStatisticsRelationshipsServiceDataAttributes Attributes { get; set; }

		/// <summary>
		/// Gets or Sets Links
		/// </summary>
		[DataMember(Name="links", EmitDefaultValue=false)]
		public ServiceStatisticsRelationshipsServiceDataLinks Links { get; set; }

		/// <summary>
		/// The entity type for a service
		/// </summary>
		/// <value>The entity type for a service</value>
		[DataMember(Name="type", EmitDefaultValue=false)]
		public string Type { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ServiceStatisticsRelationshipsServiceData {\n");
			sb.Append("  Attributes: ").Append(Attributes).Append("\n");
			sb.Append("  Links: ").Append(Links).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
