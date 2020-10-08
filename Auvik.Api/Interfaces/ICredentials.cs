using Refit;
using System.Threading.Tasks;

namespace Auvik.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ICredentials
	{
		/// <summary>
		/// Verify Credentials
		/// </summary>
		/// <remarks>
		/// Use the Verify Credentials API to verify your credentials are correct before making a call to an endpoint.&lt;br&gt; &lt;br&gt; Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command: &lt;ul&gt;	 &lt;li&gt;Within the API URL, &lt;b&gt;us1.my&lt;/b&gt; (https://auvikapi.us1.my.auvik.com) should be updated to match the region in which your account resides. To locate the region, log into your Auvik dashboard and look at the URL in your browser's address bar.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user whose credentials you wish to check.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt; &lt;/ul&gt;
		/// </remarks>
		/// <returns>Task of void</returns>
		[Get("/authentication/verify")]
		Task VerifyCredentials(
		);
	}
}
