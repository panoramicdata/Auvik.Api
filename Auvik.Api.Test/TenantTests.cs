using FluentAssertions;
using Xunit;
using System.Threading.Tasks;

namespace Auvik.Api.Test;

public class TenantTests : Test
{
	[Fact]
	public async Task ReadMultipleTenantsDetail_Succeeds()
	{
		var tenants = await AuvikClient
			.Tenants
           .ReadMultipleTenantsDetail("warps");

		tenants.Should().NotBeNull();
	}

	[Fact]
	public async Task ReadMultipleTenants_Succeeds()
	{
		var tenants = await AuvikClient
			.Tenants
           .ReadMultipleTenants();

		tenants.Should().NotBeNull();
	}
	[Fact]
	public async Task ReadSingleTenantsDetail_Succeeds()
	{
		var tenants = await AuvikClient
			.Tenants
           .ReadMultipleTenants();

		tenants.Should().NotBeNull();

		foreach (var tenant in tenants.Data)
		{
			var tenantDetail = await AuvikClient
				.Tenants
               .ReadSingleTenantDetail(tenant.Attributes.DomainPrefix, tenant.Id);

			tenantDetail.Should().NotBeNull();
		}
	}
}
