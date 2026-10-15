using Auvik.Api.Data;
using Auvik.Api.Serialization;
using AwesomeAssertions;
using System.Collections.Generic;
using System.Text.Json;
using Xunit;

namespace Auvik.Api.Test;

/// <summary>
/// Pins the string presentation of the audit log and related data objects.
/// </summary>
public class AuditModelToStringTests
{
	/// <summary>
	/// <see cref="AuditAttributes"/> renders its nine properties in ordinal name order.
	/// </summary>
	[Fact]
	public void AuditAttributes_ToString_ListsEveryProperty()
	{
		var attributes = new AuditAttributes
		{
			Action = AuditAttributes.ActionEnum.Create,
			Category = AuditAttributes.CategoryEnum.Tunnel,
			Direction = AuditAttributes.DirectionEnum.Inbound,
			Status = AuditAttributes.StatusEnum.Initiated,
			Cause = "cause",
			Data = "data",
			DateStarted = "start",
			LastActive = "last",
			User = "u",
		};

		attributes.ToString().Should().Be(
			"class AuditAttributes {\n"
			+ "  Action: Create\n"
			+ "  Category: Tunnel\n"
			+ "  Cause: cause\n"
			+ "  Data: data\n"
			+ "  DateStarted: start\n"
			+ "  Direction: Inbound\n"
			+ "  LastActive: last\n"
			+ "  Status: Initiated\n"
			+ "  User: u\n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="AuditRelationships"/> renders its two properties in name order.
	/// </summary>
	[Fact]
	public void AuditRelationships_ToString_ListsEveryProperty()
	{
		new AuditRelationships().ToString().Should().Be(
			"class AuditRelationships {\n"
			+ "  Device: \n"
			+ "  Tenant: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="AuditRelationshipsDevice"/> renders its single property.
	/// </summary>
	[Fact]
	public void AuditRelationshipsDevice_ToString_ListsEveryProperty()
	{
		new AuditRelationshipsDevice().ToString().Should().Be(
			"class AuditRelationshipsDevice {\n"
			+ "  Data: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="AuditRelationshipsDeviceData"/> renders its three properties in name order.
	/// </summary>
	[Fact]
	public void AuditRelationshipsDeviceData_ToString_ListsEveryProperty()
	{
		var data = new AuditRelationshipsDeviceData
		{
			Type = AuditRelationshipsDeviceData.TypeEnum.Device,
			Id = "d-1",
		};

		data.ToString().Should().Be(
			"class AuditRelationshipsDeviceData {\n"
			+ "  Attributes: \n"
			+ "  Id: d-1\n"
			+ "  Type: Device\n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="AuditRelationshipsDeviceDataAttributes"/> renders its single property.
	/// </summary>
	[Fact]
	public void AuditRelationshipsDeviceDataAttributes_ToString_ListsEveryProperty()
	{
		new AuditRelationshipsDeviceDataAttributes { DeviceName = "n" }.ToString().Should().Be(
			"class AuditRelationshipsDeviceDataAttributes {\n"
			+ "  DeviceName: n\n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="AuditsResourceObject"/> renders its five properties in name order.
	/// </summary>
	[Fact]
	public void AuditsResourceObject_ToString_ListsEveryProperty()
	{
		var obj = new AuditsResourceObject
		{
			Type = AuditsResourceObject.TypeEnum.EntityAudit,
			Id = "a-1",
		};

		obj.ToString().Should().Be(
			"class AuditsResourceObject {\n"
			+ "  Attributes: \n"
			+ "  Id: a-1\n"
			+ "  Links: \n"
			+ "  Relationships: \n"
			+ "  Type: EntityAudit\n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="AuditsResourceObjectLinks"/> renders its single property.
	/// </summary>
	[Fact]
	public void AuditsResourceObjectLinks_ToString_ListsEveryProperty()
	{
		new AuditsResourceObjectLinks().ToString().Should().Be(
			"class AuditsResourceObjectLinks {\n"
			+ "  Self: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="AlertsResourceObjectLinks"/> renders both links in name order.
	/// </summary>
	[Fact]
	public void AlertsResourceObjectLinks_ToString_ListsEveryProperty()
	{
		new AlertsResourceObjectLinks().ToString().Should().Be(
			"class AlertsResourceObjectLinks {\n"
			+ "  Dashboard: \n"
			+ "  Self: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="BaseDeviceExtendedDetailsAttributes"/> renders all three properties in name order.
	/// </summary>
	[Fact]
	public void BaseDeviceExtendedDetailsAttributes_ToString_ListsEveryProperty()
	{
		var attributes = new BaseDeviceExtendedDetailsAttributes
		{
			DeviceName = "n",
			LastModified = "mod",
			LastSeenTime = "seen",
		};

		attributes.ToString().Should().Be(
			"class BaseDeviceExtendedDetailsAttributes {\n"
			+ "  DeviceName: n\n"
			+ "  LastModified: mod\n"
			+ "  LastSeenTime: seen\n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="BasicError"/> renders its single property.
	/// </summary>
	[Fact]
	public void BasicError_ToString_ListsEveryProperty()
	{
		new BasicError().ToString().Should().Be(
			"class BasicError {\n"
			+ "  Errors: \n"
			+ "}\n");
	}
}
