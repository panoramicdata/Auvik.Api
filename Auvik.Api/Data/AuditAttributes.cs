#nullable disable

using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using Auvik.Api.Serialization;

namespace Auvik.Api.Data;

/// <summary>
/// The type-specific properties of the audit object returned
/// </summary>
[DataContract]
public class AuditAttributes
{
	/// <summary>
	/// What action is being performed
	/// </summary>
	/// <value>What action is being performed</value>
	[JsonConverter(typeof(EnumMemberJsonConverter))]
	public enum ActionEnum
	{

		/// <summary>
		/// Enum Unknown for "unknown"
		/// </summary>
		[EnumMember(Value = "unknown")]
		Unknown,

		/// <summary>
		/// Enum Create for "create"
		/// </summary>
		[EnumMember(Value = "create")]
		Create
	}

	/// <summary>
	/// What service is taking/took this audited action
	/// </summary>
	/// <value>What service is taking/took this audited action</value>
	[JsonConverter(typeof(EnumMemberJsonConverter))]
	public enum CategoryEnum
	{

		/// <summary>
		/// Enum Unknown for "unknown"
		/// </summary>
		[EnumMember(Value = "unknown")]
		Unknown,

		/// <summary>
		/// Enum Tunnel for "tunnel"
		/// </summary>
		[EnumMember(Value = "tunnel")]
		Tunnel,

		/// <summary>
		/// Enum Terminal for "terminal"
		/// </summary>
		[EnumMember(Value = "terminal")]
		Terminal,

		/// <summary>
		/// Enum RemoteBrowser for "remoteBrowser"
		/// </summary>
		[EnumMember(Value = "remoteBrowser")]
		RemoteBrowser
	}

	/// <summary>
	/// Whether is request is being made into or out of the entity's client
	/// </summary>
	/// <value>Whether is request is being made into or out of the entity's client</value>
	[JsonConverter(typeof(EnumMemberJsonConverter))]
	public enum DirectionEnum
	{

		/// <summary>
		/// Enum Unknown for "unknown"
		/// </summary>
		[EnumMember(Value = "unknown")]
		Unknown,

		/// <summary>
		/// Enum Inbound for "inbound"
		/// </summary>
		[EnumMember(Value = "inbound")]
		Inbound,

		/// <summary>
		/// Enum Outbound for "outbound"
		/// </summary>
		[EnumMember(Value = "outbound")]
		Outbound
	}

	/// <summary>
	/// State of the audited action
	/// </summary>
	/// <value>State of the audited action</value>
	[JsonConverter(typeof(EnumMemberJsonConverter))]
	public enum StatusEnum
	{

		/// <summary>
		/// Enum Unknown for "unknown"
		/// </summary>
		[EnumMember(Value = "unknown")]
		Unknown,

		/// <summary>
		/// Enum Initiated for "initiated"
		/// </summary>
		[EnumMember(Value = "initiated")]
		Initiated,

		/// <summary>
		/// Enum Created for "created"
		/// </summary>
		[EnumMember(Value = "created")]
		Created,

		/// <summary>
		/// Enum Closed for "closed"
		/// </summary>
		[EnumMember(Value = "closed")]
		Closed,

		/// <summary>
		/// Enum Failed for "failed"
		/// </summary>
		[EnumMember(Value = "failed")]
		Failed
	}

	/// <summary>
	/// What action is being performed
	/// </summary>
	/// <value>What action is being performed</value>
	[DataMember(Name = "action", EmitDefaultValue = false)]
	[JsonPropertyName("action")]
	public ActionEnum? Action { get; set; }

	/// <summary>
	/// What service is taking/took this audited action
	/// </summary>
	/// <value>What service is taking/took this audited action</value>
	[DataMember(Name = "category", EmitDefaultValue = false)]
	[JsonPropertyName("category")]
	public CategoryEnum? Category { get; set; }

	/// <summary>
	/// Whether is request is being made into or out of the entity's client
	/// </summary>
	/// <value>Whether is request is being made into or out of the entity's client</value>
	[DataMember(Name = "direction", EmitDefaultValue = false)]
	[JsonPropertyName("direction")]
	public DirectionEnum? Direction { get; set; }

	/// <summary>
	/// State of the audited action
	/// </summary>
	/// <value>State of the audited action</value>
	[DataMember(Name = "status", EmitDefaultValue = false)]
	[JsonPropertyName("status")]
	public StatusEnum? Status { get; set; }

	/// <summary>
	/// Reason the audited action is in its current state
	/// </summary>
	/// <value>Reason the audited action is in its current state</value>
	[DataMember(Name = "cause", EmitDefaultValue = false)]
	[JsonPropertyName("cause")]
	public string Cause { get; set; }

	/// <summary>
	/// Tertiary data related to the audited action
	/// </summary>
	/// <value>Tertiary data related to the audited action</value>
	[DataMember(Name = "data", EmitDefaultValue = false)]
	[JsonPropertyName("data")]
	public string Data { get; set; }

	/// <summary>
	/// When this audited action was started
	/// </summary>
	/// <value>When this audited action was started</value>
	[DataMember(Name = "dateStarted", EmitDefaultValue = false)]
	[JsonPropertyName("dateStarted")]
	public string DateStarted { get; set; }

	/// <summary>
	/// When this audited action was last active
	/// </summary>
	/// <value>When this audited action was last active</value>
	[DataMember(Name = "lastActive", EmitDefaultValue = false)]
	[JsonPropertyName("lastActive")]
	public string LastActive { get; set; }

	/// <summary>
	/// The user name associated to this audit log
	/// </summary>
	/// <value>The user name associated to this audit log</value>
	[DataMember(Name = "user", EmitDefaultValue = false)]
	[JsonPropertyName("user")]
	public string User { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class AuditAttributes {\n");
		sb.Append("  Action: ").Append(Action).Append("\n");
		sb.Append("  Category: ").Append(Category).Append("\n");
		sb.Append("  Cause: ").Append(Cause).Append("\n");
		sb.Append("  Data: ").Append(Data).Append("\n");
		sb.Append("  DateStarted: ").Append(DateStarted).Append("\n");
		sb.Append("  Direction: ").Append(Direction).Append("\n");
		sb.Append("  LastActive: ").Append(LastActive).Append("\n");
		sb.Append("  Status: ").Append(Status).Append("\n");
		sb.Append("  User: ").Append(User).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}