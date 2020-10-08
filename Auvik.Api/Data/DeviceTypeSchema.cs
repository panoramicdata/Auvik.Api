using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Auvik.Api.Data
{
	/// <summary>
	/// Defines DeviceTypeSchema
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DeviceTypeSchema
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
}
