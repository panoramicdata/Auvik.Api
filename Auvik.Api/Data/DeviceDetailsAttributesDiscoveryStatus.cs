#nullable disable

using System.Text;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Serialization;

namespace Auvik.Api.Data;

/// <summary>
/// High level statuses of discovery services
/// </summary>
[DataContract]
public class DeviceDetailsAttributesDiscoveryStatus
{
	/// <summary>
	/// Gets or Sets Login
	/// </summary>
	[JsonConverter(typeof(EnumMemberJsonConverter))]
	public enum LoginEnum
	{

		/// <summary>
		/// Enum Disabled for "disabled"
		/// </summary>
		[EnumMember(Value = "disabled")]
		Disabled,

		/// <summary>
		/// Enum Determining for "determining"
		/// </summary>
		[EnumMember(Value = "determining")]
		Determining,

		/// <summary>
		/// Enum NotSupported for "notSupported"
		/// </summary>
		[EnumMember(Value = "notSupported")]
		NotSupported,

		/// <summary>
		/// Enum NotAuthorized for "notAuthorized"
		/// </summary>
		[EnumMember(Value = "notAuthorized")]
		NotAuthorized,

		/// <summary>
		/// Enum Authorizing for "authorizing"
		/// </summary>
		[EnumMember(Value = "authorizing")]
		Authorizing,

		/// <summary>
		/// Enum Authorized for "authorized"
		/// </summary>
		[EnumMember(Value = "authorized")]
		Authorized,

		/// <summary>
		/// Enum Privileged for "privileged"
		/// </summary>
		[EnumMember(Value = "privileged")]
		Privileged
	}

	/// <summary>
	/// Gets or Sets Snmp
	/// </summary>
	[JsonConverter(typeof(EnumMemberJsonConverter))]
	public enum SnmpEnum
	{

		/// <summary>
		/// Enum Disabled for "disabled"
		/// </summary>
		[EnumMember(Value = "disabled")]
		Disabled,

		/// <summary>
		/// Enum Determining for "determining"
		/// </summary>
		[EnumMember(Value = "determining")]
		Determining,

		/// <summary>
		/// Enum NotSupported for "notSupported"
		/// </summary>
		[EnumMember(Value = "notSupported")]
		NotSupported,

		/// <summary>
		/// Enum NotAuthorized for "notAuthorized"
		/// </summary>
		[EnumMember(Value = "notAuthorized")]
		NotAuthorized,

		/// <summary>
		/// Enum Authorizing for "authorizing"
		/// </summary>
		[EnumMember(Value = "authorizing")]
		Authorizing,

		/// <summary>
		/// Enum Authorized for "authorized"
		/// </summary>
		[EnumMember(Value = "authorized")]
		Authorized,

		/// <summary>
		/// Enum Privileged for "privileged"
		/// </summary>
		[EnumMember(Value = "privileged")]
		Privileged
	}

	/// <summary>
	/// Gets or Sets Vmware
	/// </summary>
	[JsonConverter(typeof(EnumMemberJsonConverter))]
	public enum VmwareEnum
	{

		/// <summary>
		/// Enum Disabled for "disabled"
		/// </summary>
		[EnumMember(Value = "disabled")]
		Disabled,

		/// <summary>
		/// Enum Determining for "determining"
		/// </summary>
		[EnumMember(Value = "determining")]
		Determining,

		/// <summary>
		/// Enum NotSupported for "notSupported"
		/// </summary>
		[EnumMember(Value = "notSupported")]
		NotSupported,

		/// <summary>
		/// Enum NotAuthorized for "notAuthorized"
		/// </summary>
		[EnumMember(Value = "notAuthorized")]
		NotAuthorized,

		/// <summary>
		/// Enum Authorizing for "authorizing"
		/// </summary>
		[EnumMember(Value = "authorizing")]
		Authorizing,

		/// <summary>
		/// Enum Authorized for "authorized"
		/// </summary>
		[EnumMember(Value = "authorized")]
		Authorized,

		/// <summary>
		/// Enum Privileged for "privileged"
		/// </summary>
		[EnumMember(Value = "privileged")]
		Privileged
	}

	/// <summary>
	/// Gets or Sets Wmi
	/// </summary>
	[JsonConverter(typeof(EnumMemberJsonConverter))]
	public enum WmiEnum
	{

		/// <summary>
		/// Enum Disabled for "disabled"
		/// </summary>
		[EnumMember(Value = "disabled")]
		Disabled,

		/// <summary>
		/// Enum Determining for "determining"
		/// </summary>
		[EnumMember(Value = "determining")]
		Determining,

		/// <summary>
		/// Enum NotSupported for "notSupported"
		/// </summary>
		[EnumMember(Value = "notSupported")]
		NotSupported,

		/// <summary>
		/// Enum NotAuthorized for "notAuthorized"
		/// </summary>
		[EnumMember(Value = "notAuthorized")]
		NotAuthorized,

		/// <summary>
		/// Enum Authorizing for "authorizing"
		/// </summary>
		[EnumMember(Value = "authorizing")]
		Authorizing,

		/// <summary>
		/// Enum Authorized for "authorized"
		/// </summary>
		[EnumMember(Value = "authorized")]
		Authorized,

		/// <summary>
		/// Enum Privileged for "privileged"
		/// </summary>
		[EnumMember(Value = "privileged")]
		Privileged
	}

	/// <summary>
	/// Gets or Sets Login
	/// </summary>
	[DataMember(Name="login", EmitDefaultValue=false)]
	[JsonPropertyName("login")]
	public LoginEnum? Login { get; set; }

	/// <summary>
	/// Gets or Sets Snmp
	/// </summary>
	[DataMember(Name="snmp", EmitDefaultValue=false)]
	[JsonPropertyName("snmp")]
	public SnmpEnum? Snmp { get; set; }

	/// <summary>
	/// Gets or Sets Vmware
	/// </summary>
	[DataMember(Name="vmware", EmitDefaultValue=false)]
	[JsonPropertyName("vmware")]
	public VmwareEnum? Vmware { get; set; }

	/// <summary>
	/// Gets or Sets Wmi
	/// </summary>
	[DataMember(Name="wmi", EmitDefaultValue=false)]
	[JsonPropertyName("wmi")]
	public WmiEnum? Wmi { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class DeviceDetailsAttributesDiscoveryStatus {\n");
		sb.Append("  Login: ").Append(Login).Append("\n");
		sb.Append("  Snmp: ").Append(Snmp).Append("\n");
		sb.Append("  Vmware: ").Append(Vmware).Append("\n");
		sb.Append("  Wmi: ").Append(Wmi).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
