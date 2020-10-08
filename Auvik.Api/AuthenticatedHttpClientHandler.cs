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

		public AuthenticatedHttpClientHandler(AuvikClientOptions auvikClientOptions)
		{
			var byteArray = Encoding.ASCII.GetBytes($"{auvikClientOptions.Username}:{auvikClientOptions.ApiKey}");
			_auth = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
		}

		protected override async Task<HttpResponseMessage> SendAsync(
			HttpRequestMessage request,
			CancellationToken cancellationToken)
		{
			// See if the request has an authorize header
			request.Headers.Authorization = _auth;
			return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
		}
	}
}