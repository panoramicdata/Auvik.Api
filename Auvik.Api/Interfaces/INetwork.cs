using Auvik.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Auvik.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface INetworkApi
	{
		/// <summary>
		/// Read Multiple Networks' Details
		/// </summary>
		/// <remarks>
		/// Use the Read Multiple Networks' Details API to pull extra collected information about the various networks Auvik has discovered not already included in the Network Info API. You'll need the client IDs for the clients you want to run the multiple read against.&lt;br&gt; &lt;br&gt; To find the client IDs, run the &lt;a href&#x3D;\&quot;#operation/readMultipleTenants\&quot;&gt;Read Multiple Tenants API.&lt;/a&gt;&lt;br&gt; &lt;br&gt; Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command: &lt;ul&gt;	 &lt;li&gt;Within the API URL, &lt;b&gt;us1.my&lt;/b&gt; (https://auvikapi.us1.my.auvik.com) should be updated to match the region in which your account resides. To locate the region, log into your Auvik dashboard and look at the URL in your browser's address bar.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view network details.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;195798545063742726&lt;/i&gt; should be the ID or comma delimited IDs of the client(s) whose data you wish to fetch information from. &lt;/li&gt;	 &lt;li&gt;&lt;i&gt;filter[networkType]&#x3D;routed&lt;/i&gt; should be whichever key and value pair you want to filter the result set by. See below for a list of filterable parameters.&lt;/li&gt; &lt;/ul&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="filter_networkType">Filter by network type. (optional)</param>
		/// <param name="filter_scanStatus">Filter by the network's scan status. (optional)</param>
		/// <param name="filter_devices">Filter by IDs of devices on this network. Filter by multiple values by providing a comma delimited list. (optional)</param>
		/// <param name="filter_modifiedAfter">Filter by date and time, only returning entities modified after provided value. (optional)</param>
		/// <param name="filter_scope">Filter by the network's scope (optional)</param>
		/// <param name="tenants">Comma delimited list of tenant IDs to request info from. (optional)</param>
		/// <param name="page_first">For paginated responses, the first N elements will be returned. Used in combination with &lt;code&gt;page[after]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_after">Cursor after which elements will be returned as a page. The page size is provided by &lt;code&gt;page[first]&lt;/code&gt;. (optional)</param>
		/// <param name="page_last">For paginated responses, the last N services will be returned. Used in combination with &lt;code&gt;page[before]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_before">Cursor before which elements will be returned as a page. The page size is provided by &lt;code&gt;page[last]&lt;/code&gt;. (optional)</param>
		/// <returns>Task of NetworkDetailsReadMultiple</returns>
		[Get("/v1/inventory/network/detail")]
		Task<NetworkDetailsReadMultiple> ReadMultipleNetworkDetails(
			[AliasAs("filter[networkType]")] string filter_networkType = null,
			[AliasAs("filter[scanStatus]")] string filter_scanStatus = null,
			[AliasAs("filter[devices]")] string filter_devices = null,
			[AliasAs("filter[modifiedAfter]")] string filter_modifiedAfter = null,
			[AliasAs("filter[scope]")] string filter_scope = null,
			[AliasAs("tenants")] string tenants = null,
			[AliasAs("page[first]")] decimal? page_first = null,
			[AliasAs("page[after]")] string page_after = null,
			[AliasAs("page[last]")] decimal? page_last = null,
			[AliasAs("page[before]")] string page_before = null,
			CancellationToken? cancellationToken = null
		);

		/// <summary>
		/// Read Multiple Networks' Info
		/// </summary>
		/// <remarks>
		/// Use the Read Multiple Networks' Info API to pull the collected information about the various networks Auvik has discovered. You'll need the client IDs for the clients you want to run the multiple read against.&lt;br&gt; &lt;br&gt; To find the client IDs, run the &lt;a href&#x3D;\&quot;#operation/readMultipleTenants\&quot;&gt;Read Multiple Tenants API.&lt;/a&gt;&lt;br&gt; &lt;br&gt; Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command: &lt;ul&gt;	 &lt;li&gt;Within the API URL, &lt;b&gt;us1.my&lt;/b&gt; (https://auvikapi.us1.my.auvik.com) should be updated to match the region in which your account resides. To locate the region, log into your Auvik dashboard and look at the URL in your browser's address bar.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view network information.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;195798545063742726&lt;/i&gt; should be the ID or comma delimited IDs of the client(s) whose data you wish to fetch information from. &lt;/li&gt;	 &lt;li&gt;&lt;i&gt;filter[networkType]&#x3D;routed&lt;/i&gt; should be whichever key and value pair you want to filter the result set by. See below for a list of filterable parameters.&lt;/li&gt; &lt;/ul&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="filter_networkType">Filter by network type. (optional)</param>
		/// <param name="filter_scanStatus">Filter by the network's scan status. (optional)</param>
		/// <param name="filter_devices">Filter by IDs of devices on this network. Filter by multiple values by providing a comma delimited list. (optional)</param>
		/// <param name="filter_modifiedAfter">Filter by date and time, only returning entities modified after provided value. (optional)</param>
		/// <param name="tenants">Comma delimited list of tenant IDs to request info from. (optional)</param>
		/// <param name="page_first">For paginated responses, the first N elements will be returned. Used in combination with &lt;code&gt;page[after]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_after">Cursor after which elements will be returned as a page. The page size is provided by &lt;code&gt;page[first]&lt;/code&gt;. (optional)</param>
		/// <param name="page_last">For paginated responses, the last N services will be returned. Used in combination with &lt;code&gt;page[before]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_before">Cursor before which elements will be returned as a page. The page size is provided by &lt;code&gt;page[last]&lt;/code&gt;. (optional)</param>
		/// <param name="include">Use to include the full resource objects of any of the network's relationships. (optional)</param>
		/// <param name="fields_networkDetail">Use to limit the attributes that will be returned in the included detail object to only what is specified by this query parameter. Requires &lt;code&gt;include&#x3D;networkDetail&lt;/code&gt; (optional)</param>
		/// <returns>Task of NetworkInfoReadMultiple</returns>
		[Get("/v1/inventory/network/info")]
		Task<NetworkInfoReadMultiple> ReadMultipleNetworkInfo(
			[AliasAs("filter[networkType]")] string filter_networkType = null,
			[AliasAs("filter[scanStatus]")] string filter_scanStatus = null,
			[AliasAs("filter[devices]")] string filter_devices = null,
			[AliasAs("filter[modifiedAfter]")] string filter_modifiedAfter = null,
			[AliasAs("tenants")] string tenants = null,
			[AliasAs("page[first]")] decimal? page_first = null,
			[AliasAs("page[after]")] string page_after = null,
			[AliasAs("page[last]")] decimal? page_last = null,
			[AliasAs("page[before]")] string page_before = null,
			[AliasAs("include")] string include = null,
			[AliasAs("fields[networkDetail]")] string fields_networkDetail = null,
			CancellationToken? cancellationToken = null
		);

		/// <summary>
		/// Read a Single Network's Details
		/// </summary>
		/// <remarks>
		/// Use the Read Single Networks's Details API to pull extra collected information about a specific network Auvik has discovered not already included in the network Info API. You'll need the network ID for the specific network.&lt;br&gt; &lt;br&gt; To find the network IDs, run the &lt;a href&#x3D;\&quot;#operations/readMultipleNetworkInfo\&quot;&gt;Read Multiple Networks API&lt;/a&gt;.&lt;br&gt; &lt;br&gt; Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command: &lt;ul&gt;	 &lt;li&gt;Within the API URL, &lt;b&gt;us1.my&lt;/b&gt; (https://auvikapi.us1.my.auvik.com) should be updated to match the region in which your account resides. To locate the region, log into your Auvik dashboard and look at the URL in your browser's address bar.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view network details.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;MTk...yMw&lt;/i&gt; should be the network's ID.&lt;/li&gt; &lt;/ul&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">ID of network</param>
		/// <returns>Task of NetworkDetailsReadSingle</returns>
		[Get("/v1/inventory/network/detail/{id}")]
		Task<NetworkDetailsReadSingle> ReadSingleNetworkDetails(
			[AliasAs("id")] string id,
			CancellationToken? cancellationToken = null
		);

		/// <summary>
		/// Read a Single Network's Info
		/// </summary>
		/// <remarks>
		/// Use the Read Single Network's Info API to pull the collected information about a specific network Auvik has discovered. You'll need the network ID for the specific network.&lt;br&gt; &lt;br&gt; To find the network IDs, run the &lt;a href&#x3D;\&quot;#operations/readMultipleNetworkInfo\&quot;&gt;Read Multiple Networks' Info API&lt;/a&gt;.&lt;br&gt; &lt;br&gt; Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command: &lt;ul&gt;	 &lt;li&gt;Within the API URL, &lt;b&gt;us1.my&lt;/b&gt; (https://auvikapi.us1.my.auvik.com) should be updated to match the region in which your account resides. To locate the region, log into your Auvik dashboard and look at the URL in your browser's address bar.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view network information.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;MTk...yMw&lt;/i&gt; should be the network ID.&lt;/li&gt; &lt;/ul&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">ID of network</param>
		/// <param name="include">Use to include the full resource objects of any of the network's relationships. (optional)</param>
		/// <param name="fields_networkDetail">Use to limit the attributes that will be returned in the included detail object to only what is specified by this query parameter. Requires &lt;code&gt;include&#x3D;networkDetail&lt;/code&gt; (optional)</param>
		/// <returns>Task of NetworkInfoReadSingle</returns>
		[Get("/v1/inventory/network/info/{id}")]
		Task<NetworkInfoReadSingle> ReadSingleNetworkInfo(
			[AliasAs("id")] string id,
			[AliasAs("include")] string include = null,
			[AliasAs("fields[networkDetail]")] string fields_networkDetail = null,
			CancellationToken? cancellationToken = null
		);
	}
}