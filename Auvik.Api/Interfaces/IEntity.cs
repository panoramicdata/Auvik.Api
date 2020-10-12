using Auvik.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Auvik.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IEntity
	{
		/// <summary>
		/// Read Multiple Entity Audits
		/// </summary>
		/// <remarks>
		/// Use the Read Multiple Entity Audits API pull information about multiple entity audits for you clients. You'll need the client IDs for the clients you want to run the multiple read against.&lt;br&gt; &lt;br&gt; To find the client IDs, run the &lt;a href&#x3D;\&quot;#operation/readMultipleTenants\&quot;&gt;Read Multiple Tenants API.&lt;/a&gt;&lt;br&gt; &lt;br&gt; Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command: &lt;ul&gt;	 &lt;li&gt;Within the API URL, &lt;b&gt;us1.my&lt;/b&gt; (https://auvikapi.us1.my.auvik.com) should be updated to match the region in which your account resides. To locate the region, log into your Auvik dashboard and look at the URL in your browser's address bar.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view entity audit history.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;195798545063742726&lt;/i&gt; should be the ID or comma delimited IDs of the client(s) whose data you wish to fetch information from. &lt;/li&gt;	 &lt;li&gt;&lt;i&gt;filter[status]&#x3D;created&lt;/i&gt; should be whichever key and value pair you want to filter the result set by. See below for a list of filterable parameters.&lt;/li&gt; &lt;/ul&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="filter_user">Filter by user name associated to the audit. (optional)</param>
		/// <param name="filter_category">Filter by the audit's category. (optional)</param>
		/// <param name="filter_status">Filter by the audit's status. (optional)</param>
		/// <param name="filter_modifiedAfter">Filter by date and time, only returning entities modified after provided value. (optional)</param>
		/// <param name="tenants">Comma delimited list of tenant IDs to request info from. (optional)</param>
		/// <param name="page_first">For paginated responses, the first N elements will be returned. Used in combination with &lt;code&gt;page[after]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_after">Cursor after which elements will be returned as a page. The page size is provided by &lt;code&gt;page[first]&lt;/code&gt;. (optional)</param>
		/// <param name="page_last">For paginated responses, the last N services will be returned. Used in combination with &lt;code&gt;page[before]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_before">Cursor before which elements will be returned as a page. The page size is provided by &lt;code&gt;page[last]&lt;/code&gt;. (optional)</param>
		/// <returns>Task of EntityAuditReadMultiple</returns>
		[Get("/v1/inventory/entity/audit")]
		Task<EntityAuditReadMultiple> ReadMultipleEntityAudit(
			[AliasAs("filter_user")] string filter_user = null,
			[AliasAs("filter_category")] string filter_category = null,
			[AliasAs("filter_status")] string filter_status = null,
			[AliasAs("filter_modifiedAfter")] string filter_modifiedAfter = null,
			[AliasAs("tenants")] string tenants = null,
			[AliasAs("page_first")] decimal? page_first = null,
			[AliasAs("page_after")] string page_after = null,
			[AliasAs("page_last")] decimal? page_last = null,
			[AliasAs("page_before")] string page_before = null,
			CancellationToken? cancellationToken = null
		);

		/// <summary>
		/// Read Multiple Entity Notes
		/// </summary>
		/// <remarks>
		/// Use the Read Multiple Entity Notes API pull information about multiple entity notes. You'll need the client IDs for the clients you want to run the multiple read against.&lt;br&gt; &lt;br&gt; To find the client IDs, run the &lt;a href&#x3D;\&quot;#operation/readMultipleTenants\&quot;&gt;Read Multiple Tenants API.&lt;/a&gt;&lt;br&gt; &lt;br&gt; Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command: &lt;ul&gt;	 &lt;li&gt;Within the API URL, &lt;b&gt;us1.my&lt;/b&gt; (https://auvikapi.us1.my.auvik.com) should be updated to match the region in which your account resides. To locate the region, log into your Auvik dashboard and look at the URL in your browser's address bar.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view entity notes.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;195798545063742726&lt;/i&gt; should be the ID or comma delimited IDs of the client(s) whose data you wish to fetch information from. &lt;/li&gt;	 &lt;li&gt;&lt;i&gt;filter[entityType]&#x3D;device&lt;/i&gt; should be whichever key and value pair you want to filter the result set by. See below for a list of filterable parameters.&lt;/li&gt; &lt;/ul&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="filter_entityId">Filter by the entity's ID. (optional)</param>
		/// <param name="filter_entityType">Filter by the entity's type. (optional)</param>
		/// <param name="filter_entityName">Filter by the entity's name. (optional)</param>
		/// <param name="filter_lastModifiedBy">Filter by the user the note was last modified by. (optional)</param>
		/// <param name="filter_modifiedAfter">Filter by date and time, only returning entities modified after provided value. (optional)</param>
		/// <param name="tenants">Comma delimited list of tenant IDs to request info from. (optional)</param>
		/// <param name="page_first">For paginated responses, the first N elements will be returned. Used in combination with &lt;code&gt;page[after]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_after">Cursor after which elements will be returned as a page. The page size is provided by &lt;code&gt;page[first]&lt;/code&gt;. (optional)</param>
		/// <param name="page_last">For paginated responses, the last N services will be returned. Used in combination with &lt;code&gt;page[before]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_before">Cursor before which elements will be returned as a page. The page size is provided by &lt;code&gt;page[last]&lt;/code&gt;. (optional)</param>
		/// <returns>Task of EntityNotesReadMultiple</returns>
		[Get("/v1/inventory/entity/note")]
		Task<EntityNotesReadMultiple> ReadMultipleEntityNote(
			[AliasAs("filter_entityId")] string filter_entityId = null,
			[AliasAs("filter_entityType")] string filter_entityType = null,
			[AliasAs("filter_entityName")] string filter_entityName = null,
			[AliasAs("filter_lastModifiedBy")] string filter_lastModifiedBy = null,
			[AliasAs("filter_modifiedAfter")] string filter_modifiedAfter = null,
			[AliasAs("tenants")] string tenants = null,
			[AliasAs("page_first")] decimal? page_first = null,
			[AliasAs("page_after")] string page_after = null,
			[AliasAs("page_last")] decimal? page_last = null,
			[AliasAs("page_before")] string page_before = null,
			CancellationToken? cancellationToken = null
		);

		/// <summary>
		/// Read a Single Entity Audit
		/// </summary>
		/// <remarks>
		/// Use the Single Multiple Entity Audit API pull information about a single entity audit. You'll need the audit entry ID for the specific audit.&lt;br&gt; &lt;br&gt; To find the audit ID, run the &lt;a href&#x3D;\&quot;#operation/readMultipleEntityAudit\&quot;&gt;Read Multiple Entity Audits API&lt;/a&gt;&lt;br&gt; &lt;br&gt; Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command: &lt;ul&gt;	 &lt;li&gt;Within the API URL, &lt;b&gt;us1.my&lt;/b&gt; (https://auvikapi.us1.my.auvik.com) should be updated to match the region in which your account resides. To locate the region, log into your Auvik dashboard and look at the URL in your browser's address bar.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view entity audit history.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;MTk...yMw&lt;/i&gt; should be the audit's ID.&lt;/li&gt; &lt;/ul&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">ID of entity audit</param>
		/// <returns>Task of EntityAuditReadSingle</returns>
		[Get("/v1/inventory/entity/audit/{id}")]
		Task<EntityAuditReadSingle> ReadSingleEntityAudit(
			[AliasAs("id")] string id,
			CancellationToken? cancellationToken = null
		);

		/// <summary>
		/// Read a Single Entity Note
		/// </summary>
		/// <remarks>
		/// Use the Read Single Entity Note API to pull the information about a specific entity note. You'll need the entity note ID for the specific entity note.&lt;br&gt; &lt;br&gt; To find the note IDs the &lt;a href&#x3D;\&quot;#operation/readMultipleEntityNote\&quot;&gt;Read Multiple Entity Notes API&lt;/a&gt;.&lt;br&gt; &lt;br&gt; Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command: &lt;ul&gt;	 &lt;li&gt;Within the API URL, &lt;b&gt;us1.my&lt;/b&gt; (https://auvikapi.us1.my.auvik.com) should be updated to match the region in which your account resides. To locate the region, log into your Auvik dashboard and look at the URL in your browser's address bar.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view entity notes.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;MTk...yMw&lt;/i&gt; should be the note ID.&lt;/li&gt; &lt;/ul&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">ID of entity note</param>
		/// <returns>Task of EntityNotesReadSingle</returns>
		[Get("/v1/inventory/entity/note/{id}")]
		Task<EntityNotesReadSingle> ReadSingleEntityNote(
			[AliasAs("id")] string id,
			CancellationToken? cancellationToken = null
		);
	}
}
