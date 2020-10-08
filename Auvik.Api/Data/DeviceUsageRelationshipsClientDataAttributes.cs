using System.Text;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The type-specific properties of the device usage object returned
	/// </summary>
	[DataContract]
	public class DeviceUsageRelationshipsClientDataAttributes
	{
		/// <summary>
		/// Client tenant's domain prefix/name
		/// </summary>
		/// <value>Client tenant's domain prefix/name</value>
		[DataMember(Name="domainPrefix", EmitDefaultValue=false)]
		public string DomainPrefix { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceUsageRelationshipsClientDataAttributes {\n");
			sb.Append("  DomainPrefix: ").Append(DomainPrefix).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
