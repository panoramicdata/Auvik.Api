using Auvik.Api.Data;
using AwesomeAssertions;
using System;
using Xunit;

namespace Auvik.Api.Test;

/// <summary>
/// Pins the hand-written string presentation of <see cref="TenantDetailAttributesAddress"/>.
/// </summary>
public class TenantDetailAttributesAddressTests
{
	/// <summary>
	/// Every property is listed one per line with its value, in the order the class declares them.
	/// </summary>
	[Fact]
	public void ToString_ListsEveryPropertyWithValue()
	{
		var address = new TenantDetailAttributesAddress
		{
			StateProvince = "Dorset",
			ZIPPostalCode = "BH1 1AA",
			Address1 = "1 High Street",
			Address2 = "Suite 2",
			City = "Bournemouth",
			Country = "United Kingdom",
		};

		address.ToString().Should().Be(
			"class TenantDetailAttributesAddress {\n"
			+ "  StateProvince: Dorset\n"
			+ "  ZIPPostalCode: BH1 1AA\n"
			+ "  Address1: 1 High Street\n"
			+ "  Address2: Suite 2\n"
			+ "  City: Bournemouth\n"
			+ "  Country: United Kingdom\n"
			+ "}\n");
	}

	/// <summary>
	/// Unset properties render as an empty value rather than being omitted.
	/// </summary>
	[Fact]
	public void ToString_UnsetProperties_RenderAsEmpty()
	{
		var address = new TenantDetailAttributesAddress
		{
			City = "Bournemouth",
		};

		address.ToString().Should().Contain("  City: Bournemouth\n").And.Contain("  StateProvince: \n");
	}
}
