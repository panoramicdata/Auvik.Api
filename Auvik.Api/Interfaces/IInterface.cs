using Auvik.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Auvik.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IInterface
	{
		/// <summary>
		/// Read Multiple Interfaces Info
		/// </summary>
		/// <remarks>
		/// Use the Read Multiple Interfaces Info API to pull the collected information about the various device interfaces Auvik has discovered. You'll need the client IDs for the clients you want to run the multiple read against.&lt;br&gt; &lt;br&gt; To find the client IDs, run the &lt;a href&#x3D;\&quot;#operation/readMultipleTenants\&quot;&gt;Read Multiple Tenants API.&lt;/a&gt;&lt;br&gt; &lt;br&gt; Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command: &lt;ul&gt;	 &lt;li&gt;Within the API URL, &lt;b&gt;us1.my&lt;/b&gt; (https://auvikapi.us1.my.auvik.com) should be updated to match the region in which your account resides. To locate the region, log into your Auvik dashboard and look at the URL in your browser's address bar.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view interface information.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;195798545063742726&lt;/i&gt; should be the ID or comma delimited IDs of the client(s) whose data you wish to fetch information from. &lt;/li&gt;	 &lt;li&gt;&lt;i&gt;filter[interfaceType]&#x3D;ethernet&lt;/i&gt; should be whichever key and value pair you want to filter the result set by. See below for a list of filterable parameters.&lt;/li&gt; &lt;/ul&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="filter_interfaceType">Filter by interface type. (optional)</param>
		/// <param name="filter_parentDevice">Filter by the entity's parent device ID. (optional)</param>
		/// <param name="filter_adminStatus">Filter by the interface's admin status. (optional)</param>
		/// <param name="filter_operationalStatus">Filter by the interface's operational status. (optional)</param>
		/// <param name="filter_modifiedAfter">Filter by date and time, only returning entities modified after provided value. (optional)</param>
		/// <param name="tenants">Comma delimited list of tenant IDs to request info from. (optional)</param>
		/// <param name="page_first">For paginated responses, the first N elements will be returned. Used in combination with &lt;code&gt;page[after]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_after">Cursor after which elements will be returned as a page. The page size is provided by &lt;code&gt;page[first]&lt;/code&gt;. (optional)</param>
		/// <param name="page_last">For paginated responses, the last N services will be returned. Used in combination with &lt;code&gt;page[before]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_before">Cursor before which elements will be returned as a page. The page size is provided by &lt;code&gt;page[last]&lt;/code&gt;. (optional)</param>
		/// <returns>Task of InterfaceInfoReadMultiple</returns>
		[Get("/inventory/interface/info")]
		Task<InterfaceInfoReadMultiple> ReadMultipleInterfaceInfo(
			[AliasAs("filter_interfaceType")] string filter_interfaceType = null,
			[AliasAs("filter_parentDevice")] string filter_parentDevice = null,
			[AliasAs("filter_adminStatus")] bool? filter_adminStatus = null,
			[AliasAs("filter_operationalStatus")] string filter_operationalStatus = null,
			[AliasAs("filter_modifiedAfter")] string filter_modifiedAfter = null,
			[AliasAs("tenants")] string tenants = null,
			[AliasAs("page_first")] decimal? page_first = null,
			[AliasAs("page_after")] string page_after = null,
			[AliasAs("page_last")] decimal? page_last = null,
			[AliasAs("page_before")] string page_before = null,
			CancellationToken? cancellationToken = null
		);

		/// <summary>
		/// Read a Single Interfaces Info
		/// </summary>
		/// <remarks>
		/// Use the Read Single Interface Info API to pull the collected information about a specific device interface Auvik has discovered. You'll need the interface ID for the specific interface.&lt;br&gt; &lt;br&gt; To find the interface IDs, run the &lt;a href&#x3D;\&quot;#operation/readMultipleInterfaceInfo\&quot;&gt;Read Multiple Interfaces Info API&lt;/a&gt;.&lt;br&gt; &lt;br&gt; Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command: &lt;ul&gt;	 &lt;li&gt;Within the API URL, &lt;b&gt;us1.my&lt;/b&gt; (https://auvikapi.us1.my.auvik.com) should be updated to match the region in which your account resides. To locate the region, log into your Auvik dashboard and look at the URL in your browser's address bar.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view interface information.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;MTk...2Nw&lt;/i&gt; should be the interface ID.&lt;/li&gt; &lt;/ul&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">ID of interface</param>
		/// <returns>Task of InterfaceInfoReadSingle</returns>
		[Get("/inventory/interface/info/{id}")]
		Task<InterfaceInfoReadSingle> ReadSingleInterfaceInfo(
			[AliasAs("id")] string id,
			CancellationToken? cancellationToken = null
		);
	}
}
