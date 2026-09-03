using Auvik.Api.Data;
using AwesomeAssertions;
using Xunit;

namespace Auvik.Api.Test;

/// <summary>
/// Pins the string presentation of the data objects, which is now produced by one shared helper
/// rather than by a hand-written block in each class.
/// </summary>
public class ToStringTests
{
	/// <summary>
	/// Properties are listed one per line, in name order, with unset ones shown as blank.
	/// </summary>
	[Fact]
	public void ToString_ListsEveryPropertyInNameOrder()
	{
		var links = new AlertHistoryInfoReadMultipleLinks
		{
			First = "first-page",
			Last = "last-page",
			Next = "next-page"
		};

		links.ToString().Should().Be(
			"class AlertHistoryInfoReadMultipleLinks {\n"
			+ "  First: first-page\n"
			+ "  Last: last-page\n"
			+ "  Next: next-page\n"
			+ "  Prev: \n"
			+ "}\n");
	}

	/// <summary>
	/// Nested objects and enums are rendered through their own string presentation.
	/// </summary>
	[Fact]
	public void ToString_RendersNestedObjectsAndEnums()
	{
		var data = new TenantData
		{
			Id = "123",
			Type = TenantData.TypeEnum.Tenant
		};

		data.ToString().Should().Be(
			"class TenantData {\n"
			+ "  Attributes: \n"
			+ "  Id: 123\n"
			+ "  Type: Tenant\n"
			+ "}\n");
	}
}
