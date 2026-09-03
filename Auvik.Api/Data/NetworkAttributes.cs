#nullable disable

using System.IO;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// The type-specific properties of the networks object returned
/// </summary>
[DataContract]
public class NetworkAttributes
{
	/// <summary>
	/// This network's type
	/// </summary>
	/// <value>This network's type</value>
	[JsonConverter(typeof(EnumMemberJsonConverter))]
	public enum NetworkTypeEnum
	{

		/// <summary>
		/// Enum Routed for "routed"
		/// </summary>
		[EnumMember(Value = "routed")]
		Routed,

		/// <summary>
		/// Enum Vlan for "vlan"
		/// </summary>
		[EnumMember(Value = "vlan")]
		Vlan,

		/// <summary>
		/// Enum Wifi for "wifi"
		/// </summary>
		[EnumMember(Value = "wifi")]
		Wifi,

		/// <summary>
		/// Enum Loopback for "loopback"
		/// </summary>
		[EnumMember(Value = "loopback")]
		Loopback,

		/// <summary>
		/// Enum Network for "network"
		/// </summary>
		[EnumMember(Value = "network")]
		Network,

		/// <summary>
		/// Enum Layer2 for "layer2"
		/// </summary>
		[EnumMember(Value = "layer2")]
		Layer2,

		/// <summary>
		/// Enum Internet for "internet"
		/// </summary>
		[EnumMember(Value = "internet")]
		Internet
	}

	/// <summary>
	/// If this network is set to be scanned or not
	/// </summary>
	/// <value>If this network is set to be scanned or not</value>
	[JsonConverter(typeof(EnumMemberJsonConverter))]
	public enum ScanStatusEnum
	{

		/// <summary>
		/// Enum True for "true"
		/// </summary>
		[EnumMember(Value = "true")]
		True,

		/// <summary>
		/// Enum False for "false"
		/// </summary>
		[EnumMember(Value = "false")]
		False,

		/// <summary>
		/// Enum NotAllowed for "notAllowed"
		/// </summary>
		[EnumMember(Value = "notAllowed")]
		NotAllowed,

		/// <summary>
		/// Enum Unknown for "unknown"
		/// </summary>
		[EnumMember(Value = "unknown")]
		Unknown
	}

	/// <summary>
	/// This network's type
	/// </summary>
	/// <value>This network's type</value>
	[DataMember(Name="networkType", EmitDefaultValue=false)]
	[JsonPropertyName("networkType")]
	public NetworkTypeEnum? NetworkType { get; set; }

	/// <summary>
	/// If this network is set to be scanned or not
	/// </summary>
	/// <value>If this network is set to be scanned or not</value>
	[DataMember(Name="scanStatus", EmitDefaultValue=false)]
	[JsonPropertyName("scanStatus")]
	public ScanStatusEnum? ScanStatus { get; set; }

	/// <summary>
	/// Description of this network, also often an IP/subnet or an SSID
	/// </summary>
	/// <value>Description of this network, also often an IP/subnet or an SSID</value>
	[DataMember(Name="description", EmitDefaultValue=false)]
	[JsonPropertyName("description")]
	public string Description { get; set; }

	/// <summary>
	/// When one of this network's attributes was last modified
	/// </summary>
	/// <value>When one of this network's attributes was last modified</value>
	[DataMember(Name="lastModified", EmitDefaultValue=false)]
	[JsonPropertyName("lastModified")]
	public string LastModified { get; set; }

	/// <summary>
	/// Name of this network, usually an IP/subnet or an SSID
	/// </summary>
	/// <value>Name of this network, usually an IP/subnet or an SSID</value>
	[DataMember(Name="networkName", EmitDefaultValue=false)]
	[JsonPropertyName("networkName")]
	public string NetworkName { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
