using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The type-specific properties of the alerts object returned
	/// </summary>
	[DataContract]
	public class AlertAttributes
	{
		/// <summary>
		/// This severity of the alert message
		/// </summary>
		/// <value>This severity of the alert message</value>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum SeverityEnum
		{

			/// <summary>
			/// Enum Unknown for "unknown"
			/// </summary>
			[EnumMember(Value = "unknown")]
			Unknown,

			/// <summary>
			/// Enum Emergency for "emergency"
			/// </summary>
			[EnumMember(Value = "emergency")]
			Emergency,

			/// <summary>
			/// Enum Critical for "critical"
			/// </summary>
			[EnumMember(Value = "critical")]
			Critical,

			/// <summary>
			/// Enum Warning for "warning"
			/// </summary>
			[EnumMember(Value = "warning")]
			Warning,

			/// <summary>
			/// Enum Info for "info"
			/// </summary>
			[EnumMember(Value = "info")]
			Info
		}

		/// <summary>
		/// High level description of this alert's status
		/// </summary>
		/// <value>High level description of this alert's status</value>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum StatusEnum
		{

			/// <summary>
			/// Enum Created for "created"
			/// </summary>
			[EnumMember(Value = "created")]
			Created,

			/// <summary>
			/// Enum Resolved for "resolved"
			/// </summary>
			[EnumMember(Value = "resolved")]
			Resolved,

			/// <summary>
			/// Enum Paused for "paused"
			/// </summary>
			[EnumMember(Value = "paused")]
			Paused,

			/// <summary>
			/// Enum Unpaused for "unpaused"
			/// </summary>
			[EnumMember(Value = "unpaused")]
			Unpaused
		}

		/// <summary>
		/// This severity of the alert message
		/// </summary>
		/// <value>This severity of the alert message</value>
		[DataMember(Name = "severity", EmitDefaultValue = false)]
		public SeverityEnum? Severity { get; set; }

		/// <summary>
		/// High level description of this alert's status
		/// </summary>
		/// <value>High level description of this alert's status</value>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public StatusEnum? Status { get; set; }

		/// <summary>
		/// This description of the alert
		/// </summary>
		/// <value>This description of the alert</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// The date time of the alert's message was detected
		/// </summary>
		/// <value>The date time of the alert's message was detected</value>
		[DataMember(Name = "detectedOn", EmitDefaultValue = false)]
		public string DetectedOn { get; set; }

		/// <summary>
		/// Whether the alert has been dismissed or not
		/// </summary>
		/// <value>Whether the alert has been dismissed or not</value>
		[DataMember(Name = "dismissed", EmitDefaultValue = false)]
		public bool? Dismissed { get; set; }

		/// <summary>
		/// Whether the alert has been dispatched or not
		/// </summary>
		/// <value>Whether the alert has been dispatched or not</value>
		[DataMember(Name = "dispatched", EmitDefaultValue = false)]
		public bool? Dispatched { get; set; }

		/// <summary>
		/// The external ticket list associated to current alert message
		/// </summary>
		/// <value>The external ticket list associated to current alert message</value>
		[DataMember(Name = "externalTicket", EmitDefaultValue = false)]
		public List<AlertAttributesExternalTicket> ExternalTicket { get; set; }

		/// <summary>
		/// This alert's name
		/// </summary>
		/// <value>This alert's name</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Specification ID linked to Alert type
		/// </summary>
		/// <value>Specification ID linked to Alert type</value>
		[DataMember(Name = "specificationId", EmitDefaultValue = false)]
		public string SpecificationId { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AlertAttributes {\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  DetectedOn: ").Append(DetectedOn).Append("\n");
			sb.Append("  Dismissed: ").Append(Dismissed).Append("\n");
			sb.Append("  Dispatched: ").Append(Dispatched).Append("\n");
			sb.Append("  ExternalTicket: ").Append(ExternalTicket).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Severity: ").Append(Severity).Append("\n");
			sb.Append("  SpecificationId: ").Append(SpecificationId).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}