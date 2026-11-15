using Auvik.Api.Data;
using Auvik.Api.Interfaces;
using AwesomeAssertions;
using Refit;
using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Auvik.Api.Test;

/// <summary>Checks that the statistics query objects reach the wire in the form the Auvik API expects.</summary>
public class StatisticsQueryTests
{
	private sealed class CapturingHandler : HttpMessageHandler
	{
		public string? RequestUri { get; private set; }

		protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			RequestUri = Uri.UnescapeDataString(request.RequestUri!.PathAndQuery);
			return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
			{
				Content = new StringContent("{}", System.Text.Encoding.UTF8, "application/json")
			});
		}
	}

	/// <summary>The time range and paging options are sent as filter[...] and page[...] query parameters.</summary>
	[Fact]
	public async Task ReadDeviceStatistics_SendsTimeRangeAndPagingAsQueryParameters()
	{
		var handler = new CapturingHandler();
		var api = RestService.For<IStatistics>(new HttpClient(handler) { BaseAddress = new Uri("https://example.invalid") });

		await api.ReadDeviceStatistics(
			"cpuUtilization",
			new StatisticsTimeRange { FromTime = "2024-01-01T00:00:00Z", Interval = "hour" },
			new PagingOptions { First = 10, After = "abc" },
			filter_deviceType: "switch",
			cancellationToken: TestContext.Current.CancellationToken);

		handler.RequestUri.Should().Be(
			"/v1/stat/device/cpuUtilization?filter[fromTime]=2024-01-01T00:00:00Z&filter[interval]=hour&page[first]=10&page[after]=abc&filter[deviceType]=switch");
	}
}
