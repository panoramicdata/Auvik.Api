using System.IO;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The type specific properties of the tenants object returned
	/// </summary>
	[DataContract]
	public class TenantAttributes
	{
		/// <summary>
		/// The type of tenant in Auvik. A finite list of enumerated string values
		/// </summary>
		/// <value>The type of tenant in Auvik. A finite list of enumerated string values</value>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum TenantTypeEnum
		{

			/// <summary>
			/// Enum CorporateIt for "corporateIt"
			/// </summary>
			[EnumMember(Value = "corporateIt")]
			CorporateIt,

			/// <summary>
			/// Enum Client for "client"
			/// </summary>
			[EnumMember(Value = "client")]
			Client,

			/// <summary>
			/// Enum MultiClient for "multiClient"
			/// </summary>
			[EnumMember(Value = "multiClient")]
			MultiClient
		}

		/// <summary>
		/// The type of tenant in Auvik. A finite list of enumerated string values
		/// </summary>
		/// <value>The type of tenant in Auvik. A finite list of enumerated string values</value>
		[DataMember(Name="tenantType", EmitDefaultValue=false)]
		public TenantTypeEnum? TenantType { get; set; }

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
			sb.Append("class TenantAttributes {\n");
			sb.Append("  DomainPrefix: ").Append(DomainPrefix).Append("\n");
			sb.Append("  TenantType: ").Append(TenantType).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
