using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Auvik.Api.Test
{
	public class TenantTests : Test
	{
		public TenantTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
		{
		}

		[Fact]
		public async void ReadMultipleNetworkInfo_Succeeds()
		{
			var tenants = await AuvikClient
				.Tenants
				.ReadMultipleTenants()
				.ConfigureAwait(false);

			tenants.Should().NotBeNull();

			foreach(var tenant in tenants.Data)
			{
				var tenantDetail = await AuvikClient
					.Tenants
					.ReadSingleTenantsDetail(tenant.Attributes.DomainPrefix, tenant.Id)
					.ConfigureAwait(false);

				tenantDetail.Should().NotBeNull();
			}
		}
	}
}