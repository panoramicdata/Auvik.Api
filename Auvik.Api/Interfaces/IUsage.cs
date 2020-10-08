using Auvik.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Auvik.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IUsage
	{
		/// <summary>
		/// Read Client Usage
		/// </summary>
		/// <remarks>
		/// Use the Read Client Usage API to pull a summary of a client's (and client's children if a multi-client) usage for a given time range.&lt;br&gt; &lt;br&gt; To find the client IDs, run the &lt;a href&#x3D;\&quot;#operation/readMultipleTenants\&quot;&gt;Read Multiple Tenants API.&lt;/a&gt;&lt;br&gt; Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command: &lt;ul&gt;	 &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view billing information.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;2019-06-01&lt;/i&gt; should be the date from which you want to query.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;2019-06-30&lt;/i&gt; should be the date to which you want to query.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;199762235015168516&lt;/i&gt; should be the IDs of list of IDs of the clients whose data you wish to query.&lt;/li&gt; &lt;/ul&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="filter_fromDate">Date from which you want to query</param>
		/// <param name="filter_thruDate">Date to which you want to query</param>
		/// <param name="tenants">Comma delimited list of tenant IDs to request info from. (optional)</param>
		/// <returns>Task of ClientUsageRead</returns>
		[Get("/billing/usage/client")]
		Task<ClientUsageRead> ReadClientUsage(
			[AliasAs("filter_fromDate")] string filter_fromDate,
			[AliasAs("filter_thruDate")] string filter_thruDate,
			[AliasAs("tenants")] string tenants = null,
			CancellationToken? cancellationToken = null
		);

		/// <summary>
		/// Read Device Usage
		/// </summary>
		/// <remarks>
		/// Use the Read Device Usage API to pull a summary of a client's (and client's children if a multi-client) usage for a given time range.&lt;br&gt; Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command: &lt;ul&gt;	 &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view billing information.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;2019-06-01&lt;/i&gt; should be the date from which you want to query.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;2019-06-30&lt;/i&gt; should be the date to which you want to query.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;MTk5...g2Nw&lt;/i&gt; should be the ID of the device whose usage you want to query.&lt;/li&gt; &lt;/ul&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">ID of device</param>
		/// <param name="filter_fromDate">Date from which you want to query</param>
		/// <param name="filter_thruDate">Date to which you want to query</param>
		/// <returns>Task of DeviceUsageRead</returns>
		[Get("/billing/usage/device/{id}")]
		Task<DeviceUsageRead> ReadDeviceUsage(
			[AliasAs("id")] string id,
			[AliasAs("filter_fromDate")] string filter_fromDate,
			[AliasAs("filter_thruDate")] string filter_thruDate,
			CancellationToken? cancellationToken = null
		);
	}
}
