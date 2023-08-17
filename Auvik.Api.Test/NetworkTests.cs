using FluentAssertions;
using Xunit;
using Xunit.Abstractions;
using System.Threading.Tasks;

namespace Auvik.Api.Test
{
	public class NetworkTests : Test
	{
		public NetworkTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
		{
		}

		[Fact]
		public async Task ReadMultipleNetworkInfo_Succeeds()
		{
			var networkInfoReadMultiple = await AuvikClient
				.Networks
				.ReadMultipleNetworkInfo(
					page_first: 1,
					page_last: 1,
					filter_networkType: "routed",
					include: "networkDetail"
				)
				.ConfigureAwait(false);

			networkInfoReadMultiple.Should().NotBeNull();
		}
	}
}