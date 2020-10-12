using Auvik.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Auvik.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ITenants
	{
		/// <summary>
		/// Read Multiple Tenants
		/// </summary>
		/// <remarks>
		/// Use the Read Multiple Tenants API to pull access detail about multiple multi-clients and clients associated with your Auvik user account.&lt;br&gt;		 &lt;br&gt;		 Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command:		 &lt;ul&gt;	 &lt;li&gt;Within the API URL, &lt;b&gt;us1.my&lt;/b&gt; (https://auvikapi.us1.my.auvik.com) should be updated to match the region in which your account resides. To locate the region, log into your Auvik dashboard and look at the URL in your browser's address bar.&lt;/li&gt;		   &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view tenant information.&lt;/li&gt;		   &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;		   &lt;/ul&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of UserTenantsReadMultiple</returns>
		[Get("/v1/tenants")]
		Task<UserTenantsReadMultiple> ReadMultipleTenants(
			CancellationToken? cancellationToken = null
		);

		/// <summary>
		/// Read Multiple Tenants Detail
		/// </summary>
		/// <remarks>
		/// Use the Read Multiple Tenants API to pull details for multiple multi-clients and clients associated with your main Auvik account.&lt;br&gt;		 &lt;br&gt;		 Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command:		 &lt;ul&gt;	 &lt;li&gt;Within the API URL, &lt;b&gt;us1.my&lt;/b&gt; (https://auvikapi.us1.my.auvik.com) should be updated to match the region in which your account resides. To locate the region, log into your Auvik dashboard and look at the URL in your browser's address bar.&lt;/li&gt;		   &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view tenant information.&lt;/li&gt;		   &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;		   &lt;li&gt;&lt;i&gt;mspdemo&lt;/i&gt; should be the domain prefix of your main Auvik account. To locate your domain prefix, log into your Auvik dashboard and look at the URL in your browser's address bar.&lt;/li&gt;&lt;/ul&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tenantDomainPrefix">Domain prefix of your main Auvik account (tenant).</param>
		/// <param name="filter_availableTenants">Filter whether or not a tenant is available, i.e. data can be gotten from them via the API. (optional)</param>
		/// <returns>Task of TenantsDetailReadMultiple</returns>
		[Get("/v1/tenants/detail")]
		Task<TenantsDetailReadMultiple> ReadMultipleTenantsDetail(
			[AliasAs("tenantDomainPrefix")] string tenantDomainPrefix,
			[AliasAs("filter_availableTenants")] bool? filter_availableTenants = null,
			CancellationToken? cancellationToken = null
		);

		/// <summary>
		/// Read Single Tenant Detail
		/// </summary>
		/// <remarks>
		/// Use the Read a Single Tenant API to pull detail about a specific multi-client and client associated with your main Auvik account. You'll need the tenant ID for the specific multi-client or client you want detail for.&lt;br&gt;		 &lt;br&gt;		 You can find the tenant ID for the multi-client or client by &lt;a href&#x3D;\&quot;#operation/readMultipleTenantsDetail\&quot;&gt;Read Multiple Tenants Detail&lt;/a&gt;.&lt;br&gt;		 &lt;br&gt;		 Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command:		 &lt;ul&gt;	 &lt;li&gt;Within the API URL, &lt;b&gt;us1.my&lt;/b&gt; (https://auvikapi.us1.my.auvik.com) should be updated to match the region in which your account resides. To locate the region, log into your Auvik dashboard and look at the URL in your browser's address bar.&lt;/li&gt;		   &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to edit Client Management.&lt;/li&gt;		   &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;		   &lt;li&gt;&lt;i&gt;322018492519875477&lt;/i&gt; should be the tenant ID.&lt;/li&gt;		   &lt;li&gt;&lt;i&gt;mspdemo&lt;/i&gt; should be the domain prefix of your main Auvik account. To locate your domain prefix, log into your Auvik dashboard and look at the URL in your browser's address bar.&lt;/li&gt;		 &lt;/ul&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tenantDomainPrefix">Domain prefix of your main Auvik account (tenant).</param>
		/// <param name="id">ID of tenant</param>
		/// <returns>Task of TenantsDetailReadSingle</returns>
		[Get("/v1/tenants/detail/{id}")]
		Task<TenantsDetailReadSingle> ReadSingleTenantDetail(
			[AliasAs("tenantDomainPrefix")] string tenantDomainPrefix,
			[AliasAs("id")] string id,
			CancellationToken? cancellationToken = null
		);
	}
}
