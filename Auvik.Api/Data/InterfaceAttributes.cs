using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The type-specific properties of the interfaces object returned
	/// </summary>
	[DataContract]
	public class InterfaceAttributes
	{
		/// <summary>
		/// Duplex mode of this interface
		/// </summary>
		/// <value>Duplex mode of this interface</value>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum DuplexEnum
		{

			/// <summary>
			/// Enum Unknown for "unknown"
			/// </summary>
			[EnumMember(Value = "unknown")]
			Unknown,

			/// <summary>
			/// Enum Half for "half"
			/// </summary>
			[EnumMember(Value = "half")]
			Half,

			/// <summary>
			/// Enum Full for "full"
			/// </summary>
			[EnumMember(Value = "full")]
			Full
		}

		/// <summary>
		/// This interface's type
		/// </summary>
		/// <value>This interface's type</value>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum InterfaceTypeEnum
		{

			/// <summary>
			/// Enum Ethernet for "ethernet"
			/// </summary>
			[EnumMember(Value = "ethernet")]
			Ethernet,

			/// <summary>
			/// Enum Wifi for "wifi"
			/// </summary>
			[EnumMember(Value = "wifi")]
			Wifi,

			/// <summary>
			/// Enum Bluetooth for "bluetooth"
			/// </summary>
			[EnumMember(Value = "bluetooth")]
			Bluetooth,

			/// <summary>
			/// Enum Cdma for "cdma"
			/// </summary>
			[EnumMember(Value = "cdma")]
			Cdma,

			/// <summary>
			/// Enum Coax for "coax"
			/// </summary>
			[EnumMember(Value = "coax")]
			Coax,

			/// <summary>
			/// Enum Cpu for "cpu"
			/// </summary>
			[EnumMember(Value = "cpu")]
			Cpu,

			/// <summary>
			/// Enum DistributedVirtualSwitch for "distributedVirtualSwitch"
			/// </summary>
			[EnumMember(Value = "distributedVirtualSwitch")]
			DistributedVirtualSwitch,

			/// <summary>
			/// Enum Firewire for "firewire"
			/// </summary>
			[EnumMember(Value = "firewire")]
			Firewire,

			/// <summary>
			/// Enum Gsm for "gsm"
			/// </summary>
			[EnumMember(Value = "gsm")]
			Gsm,

			/// <summary>
			/// Enum Ieee8023AdLag for "ieee8023AdLag"
			/// </summary>
			[EnumMember(Value = "ieee8023AdLag")]
			Ieee8023AdLag,

			/// <summary>
			/// Enum InferredWired for "inferredWired"
			/// </summary>
			[EnumMember(Value = "inferredWired")]
			InferredWired,

			/// <summary>
			/// Enum InferredWireless for "inferredWireless"
			/// </summary>
			[EnumMember(Value = "inferredWireless")]
			InferredWireless,

			/// <summary>
			/// Enum Interface for "interface"
			/// </summary>
			[EnumMember(Value = "interface")]
			Interface,

			/// <summary>
			/// Enum LinkAggregation for "linkAggregation"
			/// </summary>
			[EnumMember(Value = "linkAggregation")]
			LinkAggregation,

			/// <summary>
			/// Enum Loopback for "loopback"
			/// </summary>
			[EnumMember(Value = "loopback")]
			Loopback,

			/// <summary>
			/// Enum Modem for "modem"
			/// </summary>
			[EnumMember(Value = "modem")]
			Modem,

			/// <summary>
			/// Enum Wimax for "wimax"
			/// </summary>
			[EnumMember(Value = "wimax")]
			Wimax,

			/// <summary>
			/// Enum Optical for "optical"
			/// </summary>
			[EnumMember(Value = "optical")]
			Optical,

			/// <summary>
			/// Enum Other for "other"
			/// </summary>
			[EnumMember(Value = "other")]
			Other,

			/// <summary>
			/// Enum Parallel for "parallel"
			/// </summary>
			[EnumMember(Value = "parallel")]
			Parallel,

			/// <summary>
			/// Enum Ppp for "ppp"
			/// </summary>
			[EnumMember(Value = "ppp")]
			Ppp,

			/// <summary>
			/// Enum Radiomac for "radiomac"
			/// </summary>
			[EnumMember(Value = "radiomac")]
			Radiomac,

			/// <summary>
			/// Enum Rs232 for "rs232"
			/// </summary>
			[EnumMember(Value = "rs232")]
			Rs232,

			/// <summary>
			/// Enum Tunnel for "tunnel"
			/// </summary>
			[EnumMember(Value = "tunnel")]
			Tunnel,

			/// <summary>
			/// Enum Unknown for "unknown"
			/// </summary>
			[EnumMember(Value = "unknown")]
			Unknown,

			/// <summary>
			/// Enum Usb for "usb"
			/// </summary>
			[EnumMember(Value = "usb")]
			Usb,

			/// <summary>
			/// Enum VirtualBridge for "virtualBridge"
			/// </summary>
			[EnumMember(Value = "virtualBridge")]
			VirtualBridge,

			/// <summary>
			/// Enum VirtualNic for "virtualNic"
			/// </summary>
			[EnumMember(Value = "virtualNic")]
			VirtualNic,

			/// <summary>
			/// Enum VirtualSwitch for "virtualSwitch"
			/// </summary>
			[EnumMember(Value = "virtualSwitch")]
			VirtualSwitch,

			/// <summary>
			/// Enum Vlan for "vlan"
			/// </summary>
			[EnumMember(Value = "vlan")]
			Vlan
		}

		/// <summary>
		/// This interface's operational status
		/// </summary>
		/// <value>This interface's operational status</value>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum OperationalStatusEnum
		{

			/// <summary>
			/// Enum Online for "online"
			/// </summary>
			[EnumMember(Value = "online")]
			Online,

			/// <summary>
			/// Enum Offline for "offline"
			/// </summary>
			[EnumMember(Value = "offline")]
			Offline,

			/// <summary>
			/// Enum Unreachable for "unreachable"
			/// </summary>
			[EnumMember(Value = "unreachable")]
			Unreachable,

			/// <summary>
			/// Enum Testing for "testing"
			/// </summary>
			[EnumMember(Value = "testing")]
			Testing,

			/// <summary>
			/// Enum Unknown for "unknown"
			/// </summary>
			[EnumMember(Value = "unknown")]
			Unknown,

			/// <summary>
			/// Enum Dormant for "dormant"
			/// </summary>
			[EnumMember(Value = "dormant")]
			Dormant,

			/// <summary>
			/// Enum NotPresent for "notPresent"
			/// </summary>
			[EnumMember(Value = "notPresent")]
			NotPresent,

			/// <summary>
			/// Enum LowerLayerDown for "lowerLayerDown"
			/// </summary>
			[EnumMember(Value = "lowerLayerDown")]
			LowerLayerDown
		}

		/// <summary>
		/// Duplex mode of this interface
		/// </summary>
		/// <value>Duplex mode of this interface</value>
		[DataMember(Name="duplex", EmitDefaultValue=false)]
		public DuplexEnum? Duplex { get; set; }

		/// <summary>
		/// This interface's type
		/// </summary>
		/// <value>This interface's type</value>
		[DataMember(Name="interfaceType", EmitDefaultValue=false)]
		public InterfaceTypeEnum? InterfaceType { get; set; }

		/// <summary>
		/// This interface's operational status
		/// </summary>
		/// <value>This interface's operational status</value>
		[DataMember(Name="operationalStatus", EmitDefaultValue=false)]
		public OperationalStatusEnum? OperationalStatus { get; set; }

		/// <summary>
		/// Whether this interface is enabled
		/// </summary>
		/// <value>Whether this interface is enabled</value>
		[DataMember(Name="adminStatus", EmitDefaultValue=false)]
		public bool? AdminStatus { get; set; }

		/// <summary>
		/// Whether this interface allows custom connections
		/// </summary>
		/// <value>Whether this interface allows custom connections</value>
		[DataMember(Name="customConnections", EmitDefaultValue=false)]
		public bool? CustomConnections { get; set; }

		/// <summary>
		/// This interface's name
		/// </summary>
		/// <value>This interface's name</value>
		[DataMember(Name="interfaceName", EmitDefaultValue=false)]
		public string InterfaceName { get; set; }

		/// <summary>
		/// This interface's IP addresses
		/// </summary>
		/// <value>This interface's IP addresses</value>
		[DataMember(Name="ipAddresses", EmitDefaultValue=false)]
		public List<string> IpAddresses { get; set; }

		/// <summary>
		/// When one of this interface's attributes was last modified
		/// </summary>
		/// <value>When one of this interface's attributes was last modified</value>
		[DataMember(Name="lastModified", EmitDefaultValue=false)]
		public string LastModified { get; set; }

		/// <summary>
		/// MAC address
		/// </summary>
		/// <value>MAC address</value>
		[DataMember(Name="macAddress", EmitDefaultValue=false)]
		public string MacAddress { get; set; }

		/// <summary>
		/// Negotiated speed
		/// </summary>
		/// <value>Negotiated speed</value>
		[DataMember(Name="negotiatedSpeed", EmitDefaultValue=false)]
		public string NegotiatedSpeed { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class InterfaceAttributes {\n");
			sb.Append("  AdminStatus: ").Append(AdminStatus).Append("\n");
			sb.Append("  CustomConnections: ").Append(CustomConnections).Append("\n");
			sb.Append("  Duplex: ").Append(Duplex).Append("\n");
			sb.Append("  InterfaceName: ").Append(InterfaceName).Append("\n");
			sb.Append("  InterfaceType: ").Append(InterfaceType).Append("\n");
			sb.Append("  IpAddresses: ").Append(IpAddresses).Append("\n");
			sb.Append("  LastModified: ").Append(LastModified).Append("\n");
			sb.Append("  MacAddress: ").Append(MacAddress).Append("\n");
			sb.Append("  NegotiatedSpeed: ").Append(NegotiatedSpeed).Append("\n");
			sb.Append("  OperationalStatus: ").Append(OperationalStatus).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
