using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Auvik.Api
{
	public class AuthenticatedHttpClientHandler : HttpClientHandler
	{
		private readonly AuthenticationHeaderValue _auth;
		private readonly ILogger _logger;

		public AuthenticatedHttpClientHandler(AuvikClientOptions auvikClientOptions)
		{
			var byteArray = Encoding.ASCII.GetBytes($"{auvikClientOptions.Username}:{auvikClientOptions.ApiKey}");
			_auth = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
			_logger = auvikClientOptions?.Logger ?? NullLogger.Instance;
		}

		protected override async Task<HttpResponseMessage> SendAsync(
			HttpRequestMessage request,
			CancellationToken cancellationToken)
		{
			// See if the request has an authorize header
			request.Headers.Authorization = _auth;
			_logger.LogDebug($"{request.Method} {request.RequestUri}\n{request.Headers}{(request.Content is null ? null : "\n" + await request.Content.ReadAsStringAsync().ConfigureAwait(false))}");

			var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
			_logger.LogDebug($"{(int)response.StatusCode} {response.ReasonPhrase}\n{response.Headers}\n{(response.Content is null ? null : "\n" + await response.Content.ReadAsStringAsync().ConfigureAwait(false))}");

			return response;
		}
	}
}