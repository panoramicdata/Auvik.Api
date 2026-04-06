using FluentAssertions;
using Xunit;
using System.Threading.Tasks;

namespace Auvik.Api.Test;

/// <summary>
/// Integration tests for tenant API endpoints.
/// </summary>
public class TenantTests : Test
{
	/// <summary>
	/// Verifies reading multiple tenant details returns a payload.
	/// </summary>
	[Fact]
	public async Task ReadMultipleTenantsDetail_Succeeds()
	{
		var tenants = await AuvikClient
			.Tenants
           .ReadMultipleTenantsDetail("warps");

		tenants.Should().NotBeNull();
	}

	/// <summary>
	/// Verifies reading multiple tenants returns a payload.
	/// </summary>
	[Fact]
	public async Task ReadMultipleTenants_Succeeds()
	{
		var tenants = await AuvikClient
			.Tenants
           .ReadMultipleTenants();

		tenants.Should().NotBeNull();
	}
	/// <summary>
	/// Verifies reading each tenant's detail returns a payload.
	/// </summary>
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
