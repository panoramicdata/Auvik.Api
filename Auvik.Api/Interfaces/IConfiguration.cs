using Auvik.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Auvik.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IConfiguration
	{
		/// <summary>
		/// Read Multiple Device Configurations
		/// </summary>
		/// <remarks>
		/// Use the Read Multiple Device Configuration API to pull all device configurations. You'll need the client IDs for the clients you want to run the multiple read against.&lt;br&gt; &lt;br&gt; To find the client IDs, run the &lt;a href&#x3D;\&quot;#operation/readMultipleTenants\&quot;&gt;Read Multiple Tenants API.&lt;/a&gt;&lt;br&gt; &lt;br&gt; Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command: &lt;ul&gt;	 &lt;li&gt;Within the API URL, &lt;b&gt;us1.my&lt;/b&gt; (https://auvikapi.us1.my.auvik.com) should be updated to match the region in which your account resides. To locate the region, log into your Auvik dashboard and look at the URL in your browser's address bar.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view configuration history.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;195798545063742726&lt;/i&gt; should be the ID or comma delimited IDs of the client(s) whose data you wish to fetch information from. &lt;/li&gt;	 &lt;li&gt;&lt;i&gt;filter[deviceType]&#x3D;router&lt;/i&gt; should be whichever key and value pair you want to filter the result set by. See below for a list of filterable parameters.&lt;/li&gt; &lt;/ul&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="filter_deviceId">Filter by device ID (optional)</param>
		/// <param name="filter_backupTimeAfter">Filter by date and time, filtering out configurations backed up before value. (optional)</param>
		/// <param name="filter_backupTimeBefore">Filter by date and time, filtering out configurations backed up after value. (optional)</param>
		/// <param name="filter_isRunning">Filter for configurations that are currently running, or filter for all configurations which are not currently running. (optional)</param>
		/// <param name="tenants">Comma delimited list of tenant IDs to request info from. (optional)</param>
		/// <param name="page_first">For paginated responses, the first N elements will be returned. Used in combination with &lt;code&gt;page[after]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_after">Cursor after which elements will be returned as a page. The page size is provided by &lt;code&gt;page[first]&lt;/code&gt;. (optional)</param>
		/// <param name="page_last">For paginated responses, the last N services will be returned. Used in combination with &lt;code&gt;page[before]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_before">Cursor before which elements will be returned as a page. The page size is provided by &lt;code&gt;page[last]&lt;/code&gt;. (optional)</param>
		/// <returns>Task of ConfigReadMultiple</returns>
		[Get("/v1/inventory/configuration")]
		Task<ConfigReadMultiple> ReadMultipleConfigurations(
			[AliasAs("filter_deviceId")] string filter_deviceId = null,
			[AliasAs("filter_backupTimeAfter")] string filter_backupTimeAfter = null,
			[AliasAs("filter_backupTimeBefore")] string filter_backupTimeBefore = null,
			[AliasAs("filter_isRunning")] bool? filter_isRunning = null,
			[AliasAs("tenants")] string tenants = null,
			[AliasAs("page_first")] decimal? page_first = null,
			[AliasAs("page_after")] string page_after = null,
			[AliasAs("page_last")] decimal? page_last = null,
			[AliasAs("page_before")] string page_before = null,
			CancellationToken? cancellationToken = null
		);

		/// <summary>
		/// Read a Single Device Configuration
		/// </summary>
		/// <remarks>
		/// Use the Read Single Device Configuration API to pull a single device configuration. You'll need the client IDs for the clients you want to run the multiple read against.&lt;br&gt; &lt;br&gt; To find the client IDs, run the &lt;a href&#x3D;\&quot;#operation/readMultipleTenants\&quot;&gt;Read Multiple Tenants API.&lt;/a&gt;&lt;br&gt; &lt;br&gt; Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command: &lt;ul&gt;	 &lt;li&gt;Within the API URL, &lt;b&gt;us1.my&lt;/b&gt; (https://auvikapi.us1.my.auvik.com) should be updated to match the region in which your account resides. To locate the region, log into your Auvik dashboard and look at the URL in your browser's address bar.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view configuration history.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;195798545063742726&lt;/i&gt; should be the ID or comma delimited IDs of the client(s) whose data you wish to fetch information from. &lt;/li&gt;	 &lt;li&gt;&lt;i&gt;filter[deviceType]&#x3D;router&lt;/i&gt; should be whichever key and value pair you want to filter the result set by. See below for a list of filterable parameters.&lt;/li&gt; &lt;/ul&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">ID of configuration</param>
		/// <returns>Task of ConfigReadSingle</returns>
		[Get("/v1/inventory/configuration/{id}")]
		Task<ConfigReadSingle> ReadSingleConfiguration(
			[AliasAs("id")] string id,
			CancellationToken? cancellationToken = null
		);
	}
}
