using Auvik.Api.Data;
using Auvik.Api.Serialization;
using AwesomeAssertions;
using System.Text.Json;
using Xunit;

namespace Auvik.Api.Test;

/// <summary>
/// Pins the string presentation of the component data objects.
/// </summary>
public class ComponentToStringTests
{
	/// <summary>
	/// <see cref="ComponentAttributes"/> renders its four properties in name order.
	/// </summary>
	[Fact]
	public void ComponentAttributes_ToString_ListsEveryProperty()
	{
		var attributes = new ComponentAttributes
		{
			ComponentType = ComponentAttributes.ComponentTypeEnum.Cpu,
			CurrentStatus = ComponentAttributes.CurrentStatusEnum.Ok,
			ComponentName = "c",
			LastModified = "m",
		};

		attributes.ToString().Should().Be(
			"class ComponentAttributes {\n"
			+ "  ComponentName: c\n"
			+ "  ComponentType: Cpu\n"
			+ "  CurrentStatus: Ok\n"
			+ "  LastModified: m\n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ComponentInfoReadMultiple"/> renders its three properties in name order.
	/// </summary>
	[Fact]
	public void ComponentInfoReadMultiple_ToString_ListsEveryProperty()
	{
		new ComponentInfoReadMultiple().ToString().Should().Be(
			"class ComponentInfoReadMultiple {\n"
			+ "  Data: \n"
			+ "  Links: \n"
			+ "  Meta: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ComponentInfoReadSingle"/> renders its single property.
	/// </summary>
	[Fact]
	public void ComponentInfoReadSingle_ToString_ListsEveryProperty()
	{
		new ComponentInfoReadSingle().ToString().Should().Be(
			"class ComponentInfoReadSingle {\n"
			+ "  Data: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ComponentRelationships"/> renders its two properties in name order.
	/// </summary>
	[Fact]
	public void ComponentRelationships_ToString_ListsEveryProperty()
	{
		new ComponentRelationships().ToString().Should().Be(
			"class ComponentRelationships {\n"
			+ "  ParentDevice: \n"
			+ "  Tenant: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ComponentRelationshipsParentDevice"/> renders its single property.
	/// </summary>
	[Fact]
	public void ComponentRelationshipsParentDevice_ToString_ListsEveryProperty()
	{
		new ComponentRelationshipsParentDevice().ToString().Should().Be(
			"class ComponentRelationshipsParentDevice {\n"
			+ "  Data: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ComponentsResourceObject"/> renders its five properties in name order.
	/// </summary>
	[Fact]
	public void ComponentsResourceObject_ToString_ListsEveryProperty()
	{
		var obj = new ComponentsResourceObject
		{
			Type = ComponentsResourceObject.TypeEnum.Component,
			Id = "c-1",
		};

		obj.ToString().Should().Be(
			"class ComponentsResourceObject {\n"
			+ "  Attributes: \n"
			+ "  Id: c-1\n"
			+ "  Links: \n"
			+ "  Relationships: \n"
			+ "  Type: Component\n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ComponentsResourceObjectLinks"/> renders both links in name order.
	/// </summary>
	[Fact]
	public void ComponentsResourceObjectLinks_ToString_ListsEveryProperty()
	{
		new ComponentsResourceObjectLinks().ToString().Should().Be(
			"class ComponentsResourceObjectLinks {\n"
			+ "  Dashboard: \n"
			+ "  Self: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ComponentStatisticsRead"/> renders its single property.
	/// </summary>
	[Fact]
	public void ComponentStatisticsRead_ToString_ListsEveryProperty()
	{
		new ComponentStatisticsRead().ToString().Should().Be(
			"class ComponentStatisticsRead {\n"
			+ "  Data: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="ComponentStatisticsRelationships"/> renders its two properties in name order.
	/// </summary>
	[Fact]
	public void ComponentStatisticsRelationships_ToString_ListsEveryProperty()
	{
		new ComponentStatisticsRelationships().ToString().Should().Be(
			"class ComponentStatisticsRelationships {\n"
			+ "  Component: \n"
			+ "  Tenant: \n"
			+ "}\n");
	}
}
