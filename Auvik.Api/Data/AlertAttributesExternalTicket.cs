using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
using System.Text;

namespace Auvik.Api.Data
{
	/// <summary>
	/// AlertAttributesExternalTicket
	/// </summary>
	[DataContract]
	public class AlertAttributesExternalTicket
	{
		/// <summary>
		/// The system of external ticket
		/// </summary>
		/// <value>The system of external ticket</value>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum SystemEnum
		{

			/// <summary>
			/// Enum AllUserEmail for "All_User_Email"
			/// </summary>
			[EnumMember(Value = "All_User_Email")]
			AllUserEmail,

			/// <summary>
			/// Enum SingleUserEmail for "Single_User_Email"
			/// </summary>
			[EnumMember(Value = "Single_User_Email")]
			SingleUserEmail,

			/// <summary>
			/// Enum CustomEmail for "Custom_Email"
			/// </summary>
			[EnumMember(Value = "Custom_Email")]
			CustomEmail,

			/// <summary>
			/// Enum Slack for "Slack"
			/// </summary>
			[EnumMember(Value = "Slack")]
			Slack,

			/// <summary>
			/// Enum ConnectwiseCloud for "Connectwise_Cloud"
			/// </summary>
			[EnumMember(Value = "Connectwise_Cloud")]
			ConnectwiseCloud,

			/// <summary>
			/// Enum ConnectwisePremise for "Connectwise_Premise"
			/// </summary>
			[EnumMember(Value = "Connectwise_Premise")]
			ConnectwisePremise,

			/// <summary>
			/// Enum Freshdesk for "Freshdesk"
			/// </summary>
			[EnumMember(Value = "Freshdesk")]
			Freshdesk,

			/// <summary>
			/// Enum Autotask for "Autotask"
			/// </summary>
			[EnumMember(Value = "Autotask")]
			Autotask,

			/// <summary>
			/// Enum Map for "Map"
			/// </summary>
			[EnumMember(Value = "Map")]
			Map,

			/// <summary>
			/// Enum CustomEmailGroup for "Custom_Email_Group"
			/// </summary>
			[EnumMember(Value = "Custom_Email_Group")]
			CustomEmailGroup,

			/// <summary>
			/// Enum Webhook for "Webhook"
			/// </summary>
			[EnumMember(Value = "Webhook")]
			Webhook,

			/// <summary>
			/// Enum MicrosoftTeams for "Microsoft_Teams"
			/// </summary>
			[EnumMember(Value = "Microsoft_Teams")]
			MicrosoftTeams,

			/// <summary>
			/// Enum Continum for "Continum"
			/// </summary>
			[EnumMember(Value = "Continum")]
			Continum,

			/// <summary>
			/// Enum ConnectwiserestCloud for "Connectwise_rest_Cloud"
			/// </summary>
			[EnumMember(Value = "Connectwise_rest_Cloud")]
			ConnectwiserestCloud,

			/// <summary>
			/// Enum Servicenow for "Servicenow"
			/// </summary>
			[EnumMember(Value = "Servicenow")]
			Servicenow
		}

		/// <summary>
		/// The system of external ticket
		/// </summary>
		/// <value>The system of external ticket</value>
		[DataMember(Name = "system", EmitDefaultValue = false)]
		public SystemEnum? System { get; set; }

		/// <summary>
		/// The unique identifier for the external ticket
		/// </summary>
		/// <value>The unique identifier for the external ticket</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AlertAttributesExternalTicket {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  System: ").Append(System).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}