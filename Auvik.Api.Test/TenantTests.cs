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
			var userTenantsReadMultiple = await AuvikClient
				.Tenants
				.ReadMultipleTenants()
				.ConfigureAwait(false);

			userTenantsReadMultiple.Should().NotBeNull();
		}
	}
}