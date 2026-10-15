using Auvik.Api.Data;
using Auvik.Api.Serialization;
using AwesomeAssertions;
using System.Text.Json;
using Xunit;

namespace Auvik.Api.Test;

/// <summary>
/// Pins the string presentation of the configuration resource objects.
/// </summary>
public class ConfigResourceObjectToStringTests
{
	/// <summary>
	/// <see cref="ConfigResourceObject"/> renders its five properties in name order.
	/// </summary>
	[Fact]
	public void ConfigResourceObject_ToString_ListsEveryProperty()
	{
		var obj = new ConfigResourceObject
		{
			Type = ConfigResourceObject.TypeEnum.Configuration,
			Id = "c-1",
		};

		obj.ToString().Should().Be(
			"class ConfigResourceObject {\n"
			+ "  Attributes: \n"
			+ "  Id: c-1\n"
			+ "  Links: \n"
			+ "  Relationships: \n"
			+ "  Type: Configuration\n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ConfigResourceObjectLinks"/> renders both links in name order.
	/// </summary>
	[Fact]
	public void ConfigResourceObjectLinks_ToString_ListsEveryProperty()
	{
		new ConfigResourceObjectLinks().ToString().Should().Be(
			"class ConfigResourceObjectLinks {\n"
			+ "  Dashboard: \n"
			+ "  Self: \n"
			+ "}\n");
	}
}

/// <summary>
/// Pins the string presentation of the device-details data objects.
/// </summary>
public class DeviceDetailsToStringTests
{
	/// <summary>
	/// <see cref="DeviceDetailsAttributes"/> renders its three properties in name order.
	/// </summary>
	[Fact]
	public void DeviceDetailsAttributes_ToString_ListsEveryProperty()
	{
		var attributes = new DeviceDetailsAttributes
		{
			TrafficInsightsStatus = DeviceDetailsAttributes.TrafficInsightsStatusEnum.Approved,
			ManageStatus = true,
		};

		attributes.ToString().Should().Be(
			"class DeviceDetailsAttributes {\n"
			+ "  DiscoveryStatus: \n"
			+ "  ManageStatus: True\n"
			+ "  TrafficInsightsStatus: Approved\n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="DeviceDetailsAttributesDiscoveryStatus"/> renders its four properties in name order.
	/// </summary>
	[Fact]
	public void DeviceDetailsAttributesDiscoveryStatus_ToString_ListsEveryProperty()
	{
		var status = new DeviceDetailsAttributesDiscoveryStatus
		{
			Login = DeviceDetailsAttributesDiscoveryStatus.LoginEnum.Disabled,
			Snmp = DeviceDetailsAttributesDiscoveryStatus.SnmpEnum.Disabled,
			Vmware = DeviceDetailsAttributesDiscoveryStatus.VmwareEnum.Disabled,
			Wmi = DeviceDetailsAttributesDiscoveryStatus.WmiEnum.Disabled,
		};

		status.ToString().Should().Be(
			"class DeviceDetailsAttributesDiscoveryStatus {\n"
			+ "  Login: Disabled\n"
			+ "  Snmp: Disabled\n"
			+ "  Vmware: Disabled\n"
			+ "  Wmi: Disabled\n"
			+ "}\n");
	}
}
