using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Auvik.Api;

/// <summary>
/// HTTP handler that applies Basic authentication and debug logging to outgoing requests.
/// </summary>
public class AuthenticatedHttpClientHandler : HttpClientHandler
{
	private readonly AuthenticationHeaderValue _auth;
	private readonly ILogger _logger;

	/// <summary>
	/// Initializes a new instance of the <see cref="AuthenticatedHttpClientHandler"/> class.
	/// </summary>
	/// <param name="auvikClientOptions">Client options containing API credentials and logger configuration.</param>
	public AuthenticatedHttpClientHandler(AuvikClientOptions auvikClientOptions)
	{
		var byteArray = Encoding.ASCII.GetBytes($"{auvikClientOptions.Username}:{auvikClientOptions.ApiKey}");
		_auth = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
		_logger = auvikClientOptions?.Logger ?? NullLogger.Instance;
	}

	/// <summary>
	/// Sends an HTTP request with authentication headers attached.
	/// </summary>
	/// <param name="request">The outgoing HTTP request.</param>
	/// <param name="cancellationToken">A token used to cancel the request.</param>
	/// <returns>The HTTP response message.</returns>
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