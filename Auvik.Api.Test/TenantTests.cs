using FluentAssertions;
using Xunit;
using Xunit.Abstractions;
using System.Threading.Tasks;

namespace Auvik.Api.Test
{
	public class TenantTests : Test
	{
		public TenantTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
		{
		}

		[Fact]
		public async Task ReadMultipleTenantsDetail_Succeeds()
		{
			var tenants = await AuvikClient
				.Tenants
				.ReadMultipleTenantsDetail("warps")
				.ConfigureAwait(false);

			tenants.Should().NotBeNull();
		}

		[Fact]
		public async Task ReadMultipleTenants_Succeeds()
		{
			var tenants = await AuvikClient
				.Tenants
				.ReadMultipleTenants()
				.ConfigureAwait(false);

			tenants.Should().NotBeNull();
		}
		[Fact]
		public async Task ReadSingleTenantsDetail_Succeeds()
		{
			var tenants = await AuvikClient
				.Tenants
				.ReadMultipleTenants()
				.ConfigureAwait(false);

			tenants.Should().NotBeNull();

			foreach (var tenant in tenants.Data)
			{
				var tenantDetail = await AuvikClient
					.Tenants
					.ReadSingleTenantDetail(tenant.Attributes.DomainPrefix, tenant.Id)
					.ConfigureAwait(false);

				tenantDetail.Should().NotBeNull();
			}
		}
	}
}