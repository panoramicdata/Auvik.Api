using System.IO;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The type-specific properties of the tenant object returned
	/// </summary>
	[DataContract]
	public class TenantDataAttributes
	{
		/// <summary>
		/// The domain prefix of the tenant
		/// </summary>
		/// <value>The domain prefix of the tenant</value>
		[DataMember(Name="domainPrefix", EmitDefaultValue=false)]
		public string DomainPrefix { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TenantDataAttributes {\n");
			sb.Append("  DomainPrefix: ").Append(DomainPrefix).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
