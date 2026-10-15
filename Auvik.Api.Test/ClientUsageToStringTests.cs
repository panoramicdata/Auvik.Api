using Auvik.Api.Data;
using Auvik.Api.Serialization;
using AwesomeAssertions;
using System.Text.Json;
using Xunit;

namespace Auvik.Api.Test;

/// <summary>
/// Pins the string presentation of the client-usage data objects.
/// </summary>
public class ClientUsageToStringTests
{
	/// <summary>
	/// <see cref="ClientUsageAttributes"/> renders its five properties in name order.
	/// </summary>
	[Fact]
	public void ClientUsageAttributes_ToString_ListsEveryProperty()
	{
		var attributes = new ClientUsageAttributes { DomainPrefix = "p" };

		attributes.ToString().Should().Be(
			"class ClientUsageAttributes {\n"
			+ "  BillableDays: \n"
			+ "  ClientUsage: \n"
			+ "  DeviceUsage: \n"
			+ "  DomainPrefix: p\n"
			+ "  UsagePeriod: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ClientUsageAttributesClientUsage"/> renders both properties in name order.
	/// </summary>
	[Fact]
	public void ClientUsageAttributesClientUsage_ToString_ListsEveryProperty()
	{
		var usage = new ClientUsageAttributesClientUsage { AveragedDays = 1m, TotalDays = 2m };

		usage.ToString().Should().Be(
			"class ClientUsageAttributesClientUsage {\n"
			+ "  AveragedDays: 1\n"
			+ "  TotalDays: 2\n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ClientUsageAttributesDeviceUsage"/> renders its four properties in name order.
	/// </summary>
	[Fact]
	public void ClientUsageAttributesDeviceUsage_ToString_ListsEveryProperty()
	{
		var usage = new ClientUsageAttributesDeviceUsage { AverageDays = 1m, TotalDays = 2m };

		usage.ToString().Should().Be(
			"class ClientUsageAttributesDeviceUsage {\n"
			+ "  AverageDays: 1\n"
			+ "  AverageDaysByClientType: \n"
			+ "  TotalDays: 2\n"
			+ "  TotalDaysByClientType: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ClientUsageAttributesDeviceUsageAverageDaysByClientType"/> renders its three properties.
	/// </summary>
	[Fact]
	public void ClientUsageAttributesDeviceUsageAverageDaysByClientType_ToString_ListsEveryProperty()
	{
		new ClientUsageAttributesDeviceUsageAverageDaysByClientType().ToString().Should().Be(
			"class ClientUsageAttributesDeviceUsageAverageDaysByClientType {\n"
			+ "  Essentials: \n"
			+ "  Notier: \n"
			+ "  Performance: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ClientUsageAttributesDeviceUsageTotalDaysByClientType"/> renders its three properties.
	/// </summary>
	[Fact]
	public void ClientUsageAttributesDeviceUsageTotalDaysByClientType_ToString_ListsEveryProperty()
	{
		new ClientUsageAttributesDeviceUsageTotalDaysByClientType().ToString().Should().Be(
			"class ClientUsageAttributesDeviceUsageTotalDaysByClientType {\n"
			+ "  Essentials: \n"
			+ "  Notier: \n"
			+ "  Performance: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ClientUsageAttributesUsagePeriod"/> renders its three properties in name order.
	/// </summary>
	[Fact]
	public void ClientUsageAttributesUsagePeriod_ToString_ListsEveryProperty()
	{
		var period = new ClientUsageAttributesUsagePeriod
		{
			EndDate = "end",
			StartDate = "start",
			LengthInDays = 7m,
		};

		period.ToString().Should().Be(
			"class ClientUsageAttributesUsagePeriod {\n"
			+ "  EndDate: end\n"
			+ "  LengthInDays: 7\n"
			+ "  StartDate: start\n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ClientUsageRead"/> renders its single property.
	/// </summary>
	[Fact]
	public void ClientUsageRead_ToString_ListsEveryProperty()
	{
		new ClientUsageRead().ToString().Should().Be(
			"class ClientUsageRead {\n"
			+ "  Data: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ClientUsageRelationships"/> renders its two properties in name order.
	/// </summary>
	[Fact]
	public void ClientUsageRelationships_ToString_ListsEveryProperty()
	{
		new ClientUsageRelationships().ToString().Should().Be(
			"class ClientUsageRelationships {\n"
			+ "  Clients: \n"
			+ "  Devices: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ClientUsageRelationshipsClients"/> renders its single property.
	/// </summary>
	[Fact]
	public void ClientUsageRelationshipsClients_ToString_ListsEveryProperty()
	{
		new ClientUsageRelationshipsClients().ToString().Should().Be(
			"class ClientUsageRelationshipsClients {\n"
			+ "  Data: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ClientUsageRelationshipsClientsData"/> renders its four properties in name order.
	/// </summary>
	[Fact]
	public void ClientUsageRelationshipsClientsData_ToString_ListsEveryProperty()
	{
		var data = new ClientUsageRelationshipsClientsData
		{
			Type = ClientUsageRelationshipsClientsData.TypeEnum.ClientUsage,
			Id = "c-1",
		};

		data.ToString().Should().Be(
			"class ClientUsageRelationshipsClientsData {\n"
			+ "  Attributes: \n"
			+ "  Id: c-1\n"
			+ "  Links: \n"
			+ "  Type: ClientUsage\n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ClientUsageRelationshipsClientsAttributes"/> renders both properties in name order.
	/// </summary>
	[Fact]
	public void ClientUsageRelationshipsClientsAttributes_ToString_ListsEveryProperty()
	{
		new ClientUsageRelationshipsClientsAttributes { DomainPrefix = "p" }.ToString().Should().Be(
			"class ClientUsageRelationshipsClientsAttributes {\n"
			+ "  DomainPrefix: p\n"
			+ "  TotalBillableDays: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ClientUsageRelationshipsClientsLinks"/> renders its single property.
	/// </summary>
	[Fact]
	public void ClientUsageRelationshipsClientsLinks_ToString_ListsEveryProperty()
	{
		new ClientUsageRelationshipsClientsLinks().ToString().Should().Be(
			"class ClientUsageRelationshipsClientsLinks {\n"
			+ "  Self: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ClientUsageRelationshipsDevices"/> renders its single property.
	/// </summary>
	[Fact]
	public void ClientUsageRelationshipsDevices_ToString_ListsEveryProperty()
	{
		new ClientUsageRelationshipsDevices().ToString().Should().Be(
			"class ClientUsageRelationshipsDevices {\n"
			+ "  Data: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ClientUsageRelationshipsDevicesAttributes"/> renders its three properties in name order.
	/// </summary>
	[Fact]
	public void ClientUsageRelationshipsDevicesAttributes_ToString_ListsEveryProperty()
	{
		var attributes = new ClientUsageRelationshipsDevicesAttributes
		{
			ClientName = "c",
			Name = "n",
			TotalDays = 3m,
		};

		attributes.ToString().Should().Be(
			"class ClientUsageRelationshipsDevicesAttributes {\n"
			+ "  ClientName: c\n"
			+ "  Name: n\n"
			+ "  TotalDays: 3\n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ClientUsageRelationshipsDevicesData"/> renders its four properties in name order.
	/// </summary>
	[Fact]
	public void ClientUsageRelationshipsDevicesData_ToString_ListsEveryProperty()
	{
		var data = new ClientUsageRelationshipsDevicesData
		{
			Type = ClientUsageRelationshipsDevicesData.TypeEnum.DeviceUsage,
			Id = "d-1",
		};

		data.ToString().Should().Be(
			"class ClientUsageRelationshipsDevicesData {\n"
			+ "  Attributes: \n"
			+ "  Id: d-1\n"
			+ "  Links: \n"
			+ "  Type: DeviceUsage\n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ClientUsageRelationshipsDevicesLinks"/> renders both links in name order.
	/// </summary>
	[Fact]
	public void ClientUsageRelationshipsDevicesLinks_ToString_ListsEveryProperty()
	{
		new ClientUsageRelationshipsDevicesLinks().ToString().Should().Be(
			"class ClientUsageRelationshipsDevicesLinks {\n"
			+ "  DeviceRecord: \n"
			+ "  Self: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ClientUsageResourceObject"/> renders its five properties in name order.
	/// </summary>
	[Fact]
	public void ClientUsageResourceObject_ToString_ListsEveryProperty()
	{
		var obj = new ClientUsageResourceObject
		{
			Type = ClientUsageResourceObject.TypeEnum.ClientUsage,
			Id = "c-1",
		};

		obj.ToString().Should().Be(
			"class ClientUsageResourceObject {\n"
			+ "  Attributes: \n"
			+ "  Id: c-1\n"
			+ "  Links: \n"
			+ "  Relationships: \n"
			+ "  Type: ClientUsage\n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ClientUsageResourceObjectLinks"/> renders all three links in name order.
	/// </summary>
	[Fact]
	public void ClientUsageResourceObjectLinks_ToString_ListsEveryProperty()
	{
		new ClientUsageResourceObjectLinks().ToString().Should().Be(
			"class ClientUsageResourceObjectLinks {\n"
			+ "  Dashboard: \n"
			+ "  Self: \n"
			+ "  TenantRecord: \n"
			+ "}\n");
	}
}
