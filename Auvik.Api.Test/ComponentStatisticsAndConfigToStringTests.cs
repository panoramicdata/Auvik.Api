using Auvik.Api.Data;
using Auvik.Api.Serialization;
using AwesomeAssertions;
using System.Text.Json;
using Xunit;

namespace Auvik.Api.Test;

/// <summary>
/// Pins the string presentation of the component-statistics and configuration data objects.
/// </summary>
public class ComponentStatisticsAndConfigToStringTests
{
	/// <summary>
	/// <see cref="ComponentStatisticsRelationshipsComponent"/> renders its single property.
	/// </summary>
	[Fact]
	public void ComponentStatisticsRelationshipsComponent_ToString_ListsEveryProperty()
	{
		new ComponentStatisticsRelationshipsComponent().ToString().Should().Be(
			"class ComponentStatisticsRelationshipsComponent {\n"
			+ "  Data: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ComponentStatisticsRelationshipsComponentData"/> renders its six properties in name order.
	/// </summary>
	[Fact]
	public void ComponentStatisticsRelationshipsComponentData_ToString_ListsEveryProperty()
	{
		var data = new ComponentStatisticsRelationshipsComponentData
		{
			ComponentName = "n",
			ComponentType = "t",
			Id = "c-1",
			ParentDevice = "p",
			Type = "ty",
		};

		data.ToString().Should().Be(
			"class ComponentStatisticsRelationshipsComponentData {\n"
			+ "  ComponentName: n\n"
			+ "  ComponentType: t\n"
			+ "  Id: c-1\n"
			+ "  Links: \n"
			+ "  ParentDevice: p\n"
			+ "  Type: ty\n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ComponentStatisticsRelationshipsComponentDataLinks"/> renders its three links in name order.
	/// </summary>
	[Fact]
	public void ComponentStatisticsRelationshipsComponentDataLinks_ToString_ListsEveryProperty()
	{
		new ComponentStatisticsRelationshipsComponentDataLinks().ToString().Should().Be(
			"class ComponentStatisticsRelationshipsComponentDataLinks {\n"
			+ "  Dashboard: \n"
			+ "  ParentDevice: \n"
			+ "  Self: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ComponentStatisticsResourceObject"/> renders its five properties in name order.
	/// </summary>
	[Fact]
	public void ComponentStatisticsResourceObject_ToString_ListsEveryProperty()
	{
		var obj = new ComponentStatisticsResourceObject
		{
			Type = ComponentStatisticsResourceObject.TypeEnum.ComponentStatistics,
			Id = "c-1",
		};

		obj.ToString().Should().Be(
			"class ComponentStatisticsResourceObject {\n"
			+ "  Attributes: \n"
			+ "  Id: c-1\n"
			+ "  Links: \n"
			+ "  Relationships: \n"
			+ "  Type: ComponentStatistics\n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ComponentStatisticsResourceObjectLinks"/> renders both links in name order.
	/// </summary>
	[Fact]
	public void ComponentStatisticsResourceObjectLinks_ToString_ListsEveryProperty()
	{
		new ComponentStatisticsResourceObjectLinks().ToString().Should().Be(
			"class ComponentStatisticsResourceObjectLinks {\n"
			+ "  Dashboard: \n"
			+ "  Self: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ConfigAttributes"/> renders both properties in name order.
	/// </summary>
	[Fact]
	public void ConfigAttributes_ToString_ListsEveryProperty()
	{
		var attributes = new ConfigAttributes { BackupTime = "b", IsRunning = true };

		attributes.ToString().Should().Be(
			"class ConfigAttributes {\n"
			+ "  BackupTime: b\n"
			+ "  IsRunning: True\n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ConfigReadMultiple"/> renders its three properties in name order.
	/// </summary>
	[Fact]
	public void ConfigReadMultiple_ToString_ListsEveryProperty()
	{
		new ConfigReadMultiple().ToString().Should().Be(
			"class ConfigReadMultiple {\n"
			+ "  Data: \n"
			+ "  Links: \n"
			+ "  Meta: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ConfigReadSingle"/> renders its single property.
	/// </summary>
	[Fact]
	public void ConfigReadSingle_ToString_ListsEveryProperty()
	{
		new ConfigReadSingle().ToString().Should().Be(
			"class ConfigReadSingle {\n"
			+ "  Data: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ConfigRelationships"/> renders its two properties in name order.
	/// </summary>
	[Fact]
	public void ConfigRelationships_ToString_ListsEveryProperty()
	{
		new ConfigRelationships().ToString().Should().Be(
			"class ConfigRelationships {\n"
			+ "  Device: \n"
			+ "  Tenant: \n"
			+ "}\n");
	}
}
