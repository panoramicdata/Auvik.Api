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
	public class TenantDetailAttributes
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
		/// Gets or Sets Address
		/// </summary>
		[DataMember(Name="address", EmitDefaultValue=false)]
		public TenantDetailAttributesAddress Address { get; set; }

		/// <summary>
		/// Display name used within Auvik
		/// </summary>
		/// <value>Display name used within Auvik</value>
		[DataMember(Name="displayName", EmitDefaultValue=false)]
		public string DisplayName { get; set; }

		/// <summary>
		/// The domain prefix of the tenant
		/// </summary>
		/// <value>The domain prefix of the tenant</value>
		[DataMember(Name="domainPrefix", EmitDefaultValue=false)]
		public string DomainPrefix { get; set; }

		/// <summary>
		/// Whether or not the tenant is enabled
		/// </summary>
		/// <value>Whether or not the tenant is enabled</value>
		[DataMember(Name="enabled", EmitDefaultValue=false)]
		public bool? Enabled { get; set; }

		/// <summary>
		/// Whether or not the tenant is running
		/// </summary>
		/// <value>Whether or not the tenant is running</value>
		[DataMember(Name="running", EmitDefaultValue=false)]
		public bool? Running { get; set; }

		/// <summary>
		/// Whether or not the tenant is subscribed
		/// </summary>
		/// <value>Whether or not the tenant is subscribed</value>
		[DataMember(Name="subscribed", EmitDefaultValue=false)]
		public bool? Subscribed { get; set; }

		/// <summary>
		/// The owner who subscribes the tenant
		/// </summary>
		/// <value>The owner who subscribes the tenant</value>
		[DataMember(Name="subscriptionOwner", EmitDefaultValue=false)]
		public string SubscriptionOwner { get; set; }

		/// <summary>
		/// Start date of trial
		/// </summary>
		/// <value>Start date of trial</value>
		[DataMember(Name="trialEndDate", EmitDefaultValue=false)]
		public string TrialEndDate { get; set; }

		/// <summary>
		/// Start date of trial
		/// </summary>
		/// <value>Start date of trial</value>
		[DataMember(Name="trialStartDate", EmitDefaultValue=false)]
		public string TrialStartDate { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TenantDetailAttributes {\n");
			sb.Append("  Address: ").Append(Address).Append("\n");
			sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
			sb.Append("  DomainPrefix: ").Append(DomainPrefix).Append("\n");
			sb.Append("  Enabled: ").Append(Enabled).Append("\n");
			sb.Append("  Running: ").Append(Running).Append("\n");
			sb.Append("  Subscribed: ").Append(Subscribed).Append("\n");
			sb.Append("  SubscriptionOwner: ").Append(SubscriptionOwner).Append("\n");
			sb.Append("  TenantType: ").Append(TenantType).Append("\n");
			sb.Append("  TrialEndDate: ").Append(TrialEndDate).Append("\n");
			sb.Append("  TrialStartDate: ").Append(TrialStartDate).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
