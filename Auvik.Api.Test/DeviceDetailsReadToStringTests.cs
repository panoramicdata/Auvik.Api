using Auvik.Api.Data;
using Auvik.Api.Serialization;
using AwesomeAssertions;
using System.Text.Json;
using Xunit;

namespace Auvik.Api.Test;

/// <summary>
/// Pins the string presentation of the device-details root-level data objects.
/// </summary>
public class DeviceDetailsReadToStringTests
{
	/// <summary>
	/// <see cref="DeviceDetailsExtendedReadMultiple"/> renders its three properties in name order.
	/// </summary>
	[Fact]
	public void DeviceDetailsExtendedReadMultiple_ToString_ListsEveryProperty()
	{
		new DeviceDetailsExtendedReadMultiple().ToString().Should().Be(
			"class DeviceDetailsExtendedReadMultiple {\n"
			+ "  Data: \n"
			+ "  Links: \n"
			+ "  Meta: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="DeviceDetailsExtendedReadSingle"/> renders its single property.
	/// </summary>
	[Fact]
	public void DeviceDetailsExtendedReadSingle_ToString_ListsEveryProperty()
	{
		new DeviceDetailsExtendedReadSingle().ToString().Should().Be(
			"class DeviceDetailsExtendedReadSingle {\n"
			+ "  Data: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="DeviceDetailsReadMultiple"/> renders its three properties in name order.
	/// </summary>
	[Fact]
	public void DeviceDetailsReadMultiple_ToString_ListsEveryProperty()
	{
		new DeviceDetailsReadMultiple().ToString().Should().Be(
			"class DeviceDetailsReadMultiple {\n"
			+ "  Data: \n"
			+ "  Links: \n"
			+ "  Meta: \n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="DeviceDetailsReadSingle"/> renders its single property.
	/// </summary>
	[Fact]
	public void DeviceDetailsReadSingle_ToString_ListsEveryProperty()
	{
		new DeviceDetailsReadSingle().ToString().Should().Be(
			"class DeviceDetailsReadSingle {\n"
			+ "  Data: \n"
			+ "}\n");
	}
}
