using Auvik.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Auvik.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IAlertHistory
	{
		/// <summary>
		/// Read Multiple Alerts' Info
		/// </summary>
		/// <remarks>
		/// Use the Read Multiple Alerts' Info API to pull the collected information about the various alerts that Auvik has triggered.&lt;br&gt; &lt;br&gt; To find the client IDs, run the &lt;a href&#x3D;\&quot;#operation/readMultipleTenants\&quot;&gt;Read Multiple Tenants API&lt;/a&gt;.&lt;br&gt; &lt;br&gt; Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command: &lt;ul&gt;	 &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view alert information.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;195798545063742726&lt;/i&gt; should be the ID or comma delimited IDs of the tenant(s) whose data you wish to fetch information from. &lt;/li&gt;	 &lt;li&gt;&lt;i&gt;severity&lt;/i&gt; and &lt;i&gt;warning&lt;/i&gt; should be whichever key and value pair you want to filter the result set by. See below for a list of filterable attributes.&lt;/li&gt; &lt;/ul&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="filter_alertSpecificationId">Filter by alert specification ID. (optional)</param>
		/// <param name="filter_severity">Filter by alert severity. (optional)</param>
		/// <param name="filter_status">Filter by the status of the alert. (optional)</param>
		/// <param name="filter_entityId">Filter by the related entity ID. (optional)</param>
		/// <param name="filter_dismissed">Filter by the dismissed status. (optional)</param>
		/// <param name="filter_dispatched">Filter by dispatched status. (optional)</param>
		/// <param name="filter_detectedTimeAfter">Filter by the time which is greater than the given timestamp. (optional)</param>
		/// <param name="filter_detectedTimeBefore">Filter by the time which is less than or equal to the given timestamp. (optional)</param>
		/// <param name="tenants">Comma delimited list of tenant IDs to request info from. (optional)</param>
		/// <param name="page_first">For paginated responses, the first N elements will be returned. Used in combination with &lt;code&gt;page[after]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_after">Cursor after which elements will be returned as a page. The page size is provided by &lt;code&gt;page[first]&lt;/code&gt;. (optional)</param>
		/// <param name="page_last">For paginated responses, the last N services will be returned. Used in combination with &lt;code&gt;page[before]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_before">Cursor before which elements will be returned as a page. The page size is provided by &lt;code&gt;page[last]&lt;/code&gt;. (optional)</param>
		/// <returns>Task of AlertHistoryInfoReadMultiple</returns>
		[Get("/alert/history/info")]
		Task<AlertHistoryInfoReadMultiple> ReadMultipleAlertInfo(
			[AliasAs("filter_alertSpecificationId")] string filter_alertSpecificationId = null,
			[AliasAs("filter_severity")] string filter_severity = null,
			[AliasAs("filter_status")] string filter_status = null,
			[AliasAs("filter_entityId")] string filter_entityId = null,
			[AliasAs("filter_dismissed")] bool? filter_dismissed = null,
			[AliasAs("filter_dispatched")] bool? filter_dispatched = null,
			[AliasAs("filter_detectedTimeAfter")] bool? filter_detectedTimeAfter = null,
			[AliasAs("filter_detectedTimeBefore")] bool? filter_detectedTimeBefore = null,
			[AliasAs("tenants")] string tenants = null,
			[AliasAs("page_first")] decimal? page_first = null,
			[AliasAs("page_after")] string page_after = null,
			[AliasAs("page_last")] decimal? page_last = null,
			[AliasAs("page_before")] string page_before = null,
			CancellationToken? cancellationToken = null
			);

		/// <summary>
		/// Read a Single Alert's Info
		/// </summary>
		/// <remarks>
		/// Use the Read Single Alert's Info API to pull the collected information about a specific alert that Auvik has triggered.&lt;br&gt; &lt;br&gt; To find the alert IDs, run the &lt;a href&#x3D;\&quot;#operation/readMultipleAlertInfo\&quot;&gt;Read Multiple Alerts API&lt;/a&gt;.&lt;br&gt; &lt;br&gt; Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command: &lt;ul&gt;	 &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view alert information.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;195798545063742726&lt;/i&gt; should be the ID or comma delimited IDs of the tenant(s) whose data you wish to fetch information from. &lt;/li&gt;	 &lt;li&gt;&lt;i&gt;MTk...2Nw&lt;/i&gt; should be the alert's ID.&lt;/li&gt; &lt;/ul&gt;
		/// </remarks>
		/// <param name="id">ID of alert</param>
		/// <returns>Task of AlertHistoryInfoReadSingle</returns>
		[Get("/alert/history/info/{id}")]
		Task<AlertHistoryInfoReadSingle> ReadSingleAlertInfo(
			[AliasAs("id")] string id,
			CancellationToken? cancellationToken
			);
	}
}
