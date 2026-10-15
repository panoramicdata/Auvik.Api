using Auvik.Api.Data;
using Auvik.Api.Serialization;
using AwesomeAssertions;
using System.Text.Json;
using Xunit;

namespace Auvik.Api.Test;

/// <summary>
/// Pins the string presentation of the alert relationships data objects.
/// </summary>
public class AlertRelationshipsTests
{
	/// <summary>
	/// <see cref="AlertRelationships"/> renders its three properties in name order.
	/// </summary>
	[Fact]
	public void AlertRelationships_ToString_ListsEveryProperty()
	{
		new AlertRelationships().ToString().Should().Be(
			"class AlertRelationships {\n"
			+ "  Entity: \n"
			+ "  RelatedAlert: \n"
			+ "  Tenant: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="AlertRelationshipsEntity"/> renders its single property.
	/// </summary>
	[Fact]
	public void AlertRelationshipsEntity_ToString_ListsEveryProperty()
	{
		new AlertRelationshipsEntity().ToString().Should().Be(
			"class AlertRelationshipsEntity {\n"
			+ "  Data: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="AlertRelationshipsEntityData"/> renders its three properties in name order.
	/// </summary>
	[Fact]
	public void AlertRelationshipsEntityData_ToString_ListsEveryProperty()
	{
		var data = new AlertRelationshipsEntityData
		{
			Type = AlertRelationshipsEntityData.TypeEnum.Interface,
			Id = "e-1",
		};

		data.ToString().Should().Be(
			"class AlertRelationshipsEntityData {\n"
			+ "  Id: e-1\n"
			+ "  Links: \n"
			+ "  Type: Interface\n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="AlertRelationshipsEntityDataLinks"/> renders both links in name order.
	/// </summary>
	[Fact]
	public void AlertRelationshipsEntityDataLinks_ToString_ListsEveryProperty()
	{
		new AlertRelationshipsEntityDataLinks().ToString().Should().Be(
			"class AlertRelationshipsEntityDataLinks {\n"
			+ "  Dashboard: \n"
			+ "  Self: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="AlertRelationshipsRelatedAlert"/> renders its single property.
	/// </summary>
	[Fact]
	public void AlertRelationshipsRelatedAlert_ToString_ListsEveryProperty()
	{
		new AlertRelationshipsRelatedAlert().ToString().Should().Be(
			"class AlertRelationshipsRelatedAlert {\n"
			+ "  Data: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="AlertRelationshipsRelatedAlertData"/> renders its four properties in name order.
	/// </summary>
	[Fact]
	public void AlertRelationshipsRelatedAlertData_ToString_ListsEveryProperty()
	{
		var data = new AlertRelationshipsRelatedAlertData
		{
			Type = AlertRelationshipsRelatedAlertData.TypeEnum.Alert,
			Id = "r-1",
		};

		data.ToString().Should().Be(
			"class AlertRelationshipsRelatedAlertData {\n"
			+ "  Attributes: \n"
			+ "  Id: r-1\n"
			+ "  Links: \n"
			+ "  Type: Alert\n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="AlertRelationshipsRelatedAlertDataAttributes"/> renders its single property.
	/// </summary>
	[Fact]
	public void AlertRelationshipsRelatedAlertDataAttributes_ToString_ListsEveryProperty()
	{
		var attributes = new AlertRelationshipsRelatedAlertDataAttributes { Name = "n" };

		attributes.ToString().Should().Be(
			"class AlertRelationshipsRelatedAlertDataAttributes {\n"
			+ "  Name: n\n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="AlertRelationshipsRelatedAlertDataLinks"/> renders both links in name order.
	/// </summary>
	[Fact]
	public void AlertRelationshipsRelatedAlertDataLinks_ToString_ListsEveryProperty()
	{
		new AlertRelationshipsRelatedAlertDataLinks().ToString().Should().Be(
			"class AlertRelationshipsRelatedAlertDataLinks {\n"
			+ "  Dashboard: \n"
			+ "  Self: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="AlertHistoryInfoReadSingle"/> renders its single property.
	/// </summary>
	[Fact]
	public void AlertHistoryInfoReadSingle_ToString_ListsEveryProperty()
	{
		new AlertHistoryInfoReadSingle().ToString().Should().Be(
			"class AlertHistoryInfoReadSingle {\n"
			+ "  Data: \n"
			+ "}\n");
	}
}
