using FluentAssertions;
using Xunit;
using System.Threading.Tasks;

namespace Auvik.Api.Test;

public class NetworkTests : Test
{
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
           );

		networkInfoReadMultiple.Should().NotBeNull();
	}
}
