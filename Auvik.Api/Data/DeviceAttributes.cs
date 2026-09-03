#nullable disable

using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// The type-specific properties of the devices object returned
/// </summary>
[DataContract]
public class DeviceAttributes
{
	/// <summary>
	/// What type of device it is
	/// </summary>
	/// <value>What type of device it is</value>
	[JsonConverter(typeof(EnumMemberJsonConverter))]
	public enum DeviceTypeEnum
	{

		/// <summary>
		/// Enum Unknown for "unknown"
		/// </summary>
		[EnumMember(Value = "unknown")]
		Unknown,

		/// <summary>
		/// Enum Switch for "switch"
		/// </summary>
		[EnumMember(Value = "switch")]
		Switch,

		/// <summary>
		/// Enum L3Switch for "l3Switch"
		/// </summary>
		[EnumMember(Value = "l3Switch")]
		L3Switch,

		/// <summary>
		/// Enum Router for "router"
		/// </summary>
		[EnumMember(Value = "router")]
		Router,

		/// <summary>
		/// Enum AccessPoint for "accessPoint"
		/// </summary>
		[EnumMember(Value = "accessPoint")]
		AccessPoint,

		/// <summary>
		/// Enum Firewall for "firewall"
		/// </summary>
		[EnumMember(Value = "firewall")]
		Firewall,

		/// <summary>
		/// Enum Workstation for "workstation"
		/// </summary>
		[EnumMember(Value = "workstation")]
		Workstation,

		/// <summary>
		/// Enum Server for "server"
		/// </summary>
		[EnumMember(Value = "server")]
		Server,

		/// <summary>
		/// Enum Storage for "storage"
		/// </summary>
		[EnumMember(Value = "storage")]
		Storage,

		/// <summary>
		/// Enum Printer for "printer"
		/// </summary>
		[EnumMember(Value = "printer")]
		Printer,

		/// <summary>
		/// Enum Copier for "copier"
		/// </summary>
		[EnumMember(Value = "copier")]
		Copier,

		/// <summary>
		/// Enum Hypervisor for "hypervisor"
		/// </summary>
		[EnumMember(Value = "hypervisor")]
		Hypervisor,

		/// <summary>
		/// Enum Multimedia for "multimedia"
		/// </summary>
		[EnumMember(Value = "multimedia")]
		Multimedia,

		/// <summary>
		/// Enum Phone for "phone"
		/// </summary>
		[EnumMember(Value = "phone")]
		Phone,

		/// <summary>
		/// Enum Tablet for "tablet"
		/// </summary>
		[EnumMember(Value = "tablet")]
		Tablet,

		/// <summary>
		/// Enum Handheld for "handheld"
		/// </summary>
		[EnumMember(Value = "handheld")]
		Handheld,

		/// <summary>
		/// Enum VirtualAppliance for "virtualAppliance"
		/// </summary>
		[EnumMember(Value = "virtualAppliance")]
		VirtualAppliance,

		/// <summary>
		/// Enum Bridge for "bridge"
		/// </summary>
		[EnumMember(Value = "bridge")]
		Bridge,

		/// <summary>
		/// Enum Controller for "controller"
		/// </summary>
		[EnumMember(Value = "controller")]
		Controller,

		/// <summary>
		/// Enum Hub for "hub"
		/// </summary>
		[EnumMember(Value = "hub")]
		Hub,

		/// <summary>
		/// Enum Modem for "modem"
		/// </summary>
		[EnumMember(Value = "modem")]
		Modem,

		/// <summary>
		/// Enum Ups for "ups"
		/// </summary>
		[EnumMember(Value = "ups")]
		Ups,

		/// <summary>
		/// Enum Module for "module"
		/// </summary>
		[EnumMember(Value = "module")]
		Module,

		/// <summary>
		/// Enum LoadBalancer for "loadBalancer"
		/// </summary>
		[EnumMember(Value = "loadBalancer")]
		LoadBalancer,

		/// <summary>
		/// Enum Camera for "camera"
		/// </summary>
		[EnumMember(Value = "camera")]
		Camera,

		/// <summary>
		/// Enum Telecommunications for "telecommunications"
		/// </summary>
		[EnumMember(Value = "telecommunications")]
		Telecommunications,

		/// <summary>
		/// Enum PacketProcessor for "packetProcessor"
		/// </summary>
		[EnumMember(Value = "packetProcessor")]
		PacketProcessor,

		/// <summary>
		/// Enum Chassis for "chassis"
		/// </summary>
		[EnumMember(Value = "chassis")]
		Chassis,

		/// <summary>
		/// Enum AirConditioner for "airConditioner"
		/// </summary>
		[EnumMember(Value = "airConditioner")]
		AirConditioner,

		/// <summary>
		/// Enum VirtualMachine for "virtualMachine"
		/// </summary>
		[EnumMember(Value = "virtualMachine")]
		VirtualMachine,

		/// <summary>
		/// Enum Pdu for "pdu"
		/// </summary>
		[EnumMember(Value = "pdu")]
		Pdu,

		/// <summary>
		/// Enum IpPhone for "ipPhone"
		/// </summary>
		[EnumMember(Value = "ipPhone")]
		IpPhone,

		/// <summary>
		/// Enum Backhaul for "backhaul"
		/// </summary>
		[EnumMember(Value = "backhaul")]
		Backhaul,

		/// <summary>
		/// Enum InternetOfThings for "internetOfThings"
		/// </summary>
		[EnumMember(Value = "internetOfThings")]
		InternetOfThings,

		/// <summary>
		/// Enum VoipSwitch for "voipSwitch"
		/// </summary>
		[EnumMember(Value = "voipSwitch")]
		VoipSwitch,

		/// <summary>
		/// Enum Stack for "stack"
		/// </summary>
		[EnumMember(Value = "stack")]
		Stack,

		/// <summary>
		/// Enum BackupDevice for "backupDevice"
		/// </summary>
		[EnumMember(Value = "backupDevice")]
		BackupDevice,

		/// <summary>
		/// Enum TimeClock for "timeClock"
		/// </summary>
		[EnumMember(Value = "timeClock")]
		TimeClock,

		/// <summary>
		/// Enum LightingDevice for "lightingDevice"
		/// </summary>
		[EnumMember(Value = "lightingDevice")]
		LightingDevice,

		/// <summary>
		/// Enum AudioVisual for "audioVisual"
		/// </summary>
		[EnumMember(Value = "audioVisual")]
		AudioVisual,

		/// <summary>
		/// Enum SecurityAppliance for "securityAppliance"
		/// </summary>
		[EnumMember(Value = "securityAppliance")]
		SecurityAppliance,

		/// <summary>
		/// Enum Utm for "utm"
		/// </summary>
		[EnumMember(Value = "utm")]
		Utm,

		/// <summary>
		/// Enum Alarm for "alarm"
		/// </summary>
		[EnumMember(Value = "alarm")]
		Alarm,

		/// <summary>
		/// Enum BuildingManagement for "buildingManagement"
		/// </summary>
		[EnumMember(Value = "buildingManagement")]
		BuildingManagement,

		/// <summary>
		/// Enum Ipmi for "ipmi"
		/// </summary>
		[EnumMember(Value = "ipmi")]
		Ipmi,

		/// <summary>
		/// Enum ThinAccessPoint for "thinAccessPoint"
		/// </summary>
		[EnumMember(Value = "thinAccessPoint")]
		ThinAccessPoint,

		/// <summary>
		/// Enum ThinClient for "thinClient"
		/// </summary>
		[EnumMember(Value = "thinClient")]
		ThinClient
	}

	/// <summary>
	/// Device's online status
	/// </summary>
	/// <value>Device's online status</value>
	[JsonConverter(typeof(EnumMemberJsonConverter))]
	public enum OnlineStatusEnum
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
	/// What type of device it is
	/// </summary>
	/// <value>What type of device it is</value>
	[DataMember(Name="deviceType", EmitDefaultValue=false)]
	[JsonPropertyName("deviceType")]
	public DeviceTypeEnum? DeviceType { get; set; }

	/// <summary>
	/// Device's online status
	/// </summary>
	/// <value>Device's online status</value>
	[DataMember(Name="onlineStatus", EmitDefaultValue=false)]
	[JsonPropertyName("onlineStatus")]
	public OnlineStatusEnum? OnlineStatus { get; set; }

	/// <summary>
	/// Description
	/// </summary>
	/// <value>Description</value>
	[DataMember(Name="description", EmitDefaultValue=false)]
	[JsonPropertyName("description")]
	public string Description { get; set; }

	/// <summary>
	/// Device's name
	/// </summary>
	/// <value>Device's name</value>
	[DataMember(Name="deviceName", EmitDefaultValue=false)]
	[JsonPropertyName("deviceName")]
	public string DeviceName { get; set; }

	/// <summary>
	/// Device's firmware version
	/// </summary>
	/// <value>Device's firmware version</value>
	[DataMember(Name="firmwareVersion", EmitDefaultValue=false)]
	[JsonPropertyName("firmwareVersion")]
	public string FirmwareVersion { get; set; }

	/// <summary>
	/// Device's local IP addresses
	/// </summary>
	/// <value>Device's local IP addresses</value>
	[DataMember(Name="ipAddresses", EmitDefaultValue=false)]
	[JsonPropertyName("ipAddresses")]
	public List<string> IpAddresses { get; set; }

	/// <summary>
	/// When one of this device's attributes was last modified
	/// </summary>
	/// <value>When one of this device's attributes was last modified</value>
	[DataMember(Name="lastModified", EmitDefaultValue=false)]
	[JsonPropertyName("lastModified")]
	public string LastModified { get; set; }

	/// <summary>
	/// Last seen online date/time of a device
	/// </summary>
	/// <value>Last seen online date/time of a device</value>
	[DataMember(Name="lastSeenTime", EmitDefaultValue=false)]
	[JsonPropertyName("lastSeenTime")]
	public string LastSeenTime { get; set; }

	/// <summary>
	/// Make and model of this device
	/// </summary>
	/// <value>Make and model of this device</value>
	[DataMember(Name="makeModel", EmitDefaultValue=false)]
	[JsonPropertyName("makeModel")]
	public string MakeModel { get; set; }

	/// <summary>
	/// Device's serial number
	/// </summary>
	/// <value>Device's serial number</value>
	[DataMember(Name="serialNumber", EmitDefaultValue=false)]
	[JsonPropertyName("serialNumber")]
	public string SerialNumber { get; set; }

	/// <summary>
	/// Devices software version, if known
	/// </summary>
	/// <value>Devices software version, if known</value>
	[DataMember(Name="softwareVersion", EmitDefaultValue=false)]
	[JsonPropertyName("softwareVersion")]
	public string SoftwareVersion { get; set; }

	/// <summary>
	/// Vendor name for this device
	/// </summary>
	/// <value>Vendor name for this device</value>
	[DataMember(Name="vendorName", EmitDefaultValue=false)]
	[JsonPropertyName("vendorName")]
	public string VendorName { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
