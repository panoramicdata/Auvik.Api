using Auvik.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Auvik.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IDevice
	{
		/// <summary>
		/// Read Multiple Devices' Details
		/// </summary>
		/// <remarks>
		/// Use the Read Multiple Devices' Details API to pull extra collected information about the various devices Auvik has discovered not already included in the Device Info API. You'll need the client IDs for the clients you want to run the multiple read against.&lt;br&gt; &lt;br&gt; To find the client IDs, run the &lt;a href&#x3D;\&quot;#operation/readMultipleTenants\&quot;&gt;Read Multiple Tenants API.&lt;/a&gt;&lt;br&gt; &lt;br&gt; Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command: &lt;ul&gt;	 &lt;li&gt;Within the API URL, &lt;b&gt;us1.my&lt;/b&gt; (https://auvikapi.us1.my.auvik.com) should be updated to match the region in which your account resides. To locate the region, log into your Auvik dashboard and look at the URL in your browser's address bar.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view device details.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;195798545063742726&lt;/i&gt; should be the ID or comma delimited IDs of the client(s) whose data you wish to fetch information from. &lt;/li&gt;	 &lt;li&gt;&lt;i&gt;filter[deviceType]&#x3D;router&lt;/i&gt; should be whichever key and value pair you want to filter the result set by. See below for a list of filterable parameters.&lt;/li&gt; &lt;/ul&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="filter_manageStatus">Filter by managed status (optional)</param>
		/// <param name="filter_discoverySNMP">Filter by the device's SNMP discovery status. (optional)</param>
		/// <param name="filter_discoveryWMI">Filter by the device's WMI discovery status. (optional)</param>
		/// <param name="filter_discoveryLogin">Filter by the device's Login discovery status. (optional)</param>
		/// <param name="filter_discoveryVMware">Filter by the device's VMware discovery status. (optional)</param>
		/// <param name="filter_trafficInsightsStatus">Filter by the device's TrafficInsights status. (optional)</param>
		/// <param name="tenants">Comma delimited list of tenant IDs to request info from. (optional)</param>
		/// <param name="page_first">For paginated responses, the first N elements will be returned. Used in combination with &lt;code&gt;page[after]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_after">Cursor after which elements will be returned as a page. The page size is provided by &lt;code&gt;page[first]&lt;/code&gt;. (optional)</param>
		/// <param name="page_last">For paginated responses, the last N services will be returned. Used in combination with &lt;code&gt;page[before]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_before">Cursor before which elements will be returned as a page. The page size is provided by &lt;code&gt;page[last]&lt;/code&gt;. (optional)</param>
		/// <returns>Task of DeviceDetailsReadMultiple</returns>
		[Get("/v1/inventory/device/detail")]
		Task<DeviceDetailsReadMultiple> ReadMultipleDeviceDetails(
			[AliasAs("filter_manageStatus")] bool? filter_manageStatus = null,
			[AliasAs("filter_discoverySNMP")] string filter_discoverySNMP = null,
			[AliasAs("filter_discoveryWMI")] string filter_discoveryWMI = null,
			[AliasAs("filter_discoveryLogin")] string filter_discoveryLogin = null,
			[AliasAs("filter_discoveryVMware")] string filter_discoveryVMware = null,
			[AliasAs("filter_trafficInsightsStatus")] string filter_trafficInsightsStatus = null,
			[AliasAs("tenants")] string tenants = null,
			[AliasAs("page_first")] decimal? page_first = null,
			[AliasAs("page_after")] string page_after = null,
			[AliasAs("page_last")] decimal? page_last = null,
			[AliasAs("page_before")] string page_before = null,
			CancellationToken? cancellationToken = null
		);

		/// <summary>
		/// Read Multiple Devices' Extended Details
		/// </summary>
		/// <remarks>
		/// Use the Read Multiple Devices' Extended Details API to get many devices' extended details. Many device types have information collected and tracked by Auvik that are unique to that device type. Use this endpoint to access such information for a given device. You'll need the client IDs for the clients you want to run the multiple read against.&lt;br&gt; &lt;br&gt; To find the client IDs, run the &lt;a href&#x3D;\&quot;#operation/readMultipleTenants\&quot;&gt;Read Multiple Tenants API.&lt;/a&gt;&lt;br&gt; &lt;br&gt; Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command: &lt;ul&gt;	 &lt;li&gt;Within the API URL, &lt;b&gt;us1.my&lt;/b&gt; (https://auvikapi.us1.my.auvik.com) should be updated to match the region in which your account resides. To locate the region, log into your Auvik dashboard and look at the URL in your browser's address bar.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view device extended details.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;195798545063742726&lt;/i&gt; should be the ID or comma delimited IDs of the client(s) whose data you wish to fetch information from. &lt;/li&gt;	 &lt;li&gt;&lt;i&gt;filter[deviceType]&#x3D;switch&lt;/i&gt; should be whichever key and value pair you want to filter the result set by. See below for a list of filterable parameters.&lt;/li&gt; &lt;/ul&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="filter_deviceType">Filter by device type.</param>
		/// <param name="filter_modifiedAfter">Filter by date and time, only returning entities modified after provided value. (optional)</param>
		/// <param name="filter_notSeenSince">Filter by the last seen online time, returning entities not seen online after the provided value. (optional)</param>
		/// <param name="tenants">Comma delimited list of tenant IDs to request info from. (optional)</param>
		/// <param name="page_first">For paginated responses, the first N elements will be returned. Used in combination with &lt;code&gt;page[after]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_after">Cursor after which elements will be returned as a page. The page size is provided by &lt;code&gt;page[first]&lt;/code&gt;. (optional)</param>
		/// <param name="page_last">For paginated responses, the last N services will be returned. Used in combination with &lt;code&gt;page[before]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_before">Cursor before which elements will be returned as a page. The page size is provided by &lt;code&gt;page[last]&lt;/code&gt;. (optional)</param>
		/// <returns>Task of DeviceDetailsExtendedReadMultiple</returns>
		[Get("/v1/inventory/device/detail/extended")]
		Task<DeviceDetailsExtendedReadMultiple> ReadMultipleDeviceExtendedDetail(
			[AliasAs("filter_deviceType")] string filter_deviceType,
			[AliasAs("filter_modifiedAfter")] string filter_modifiedAfter = null,
			[AliasAs("filter_notSeenSince")] string filter_notSeenSince = null,
			[AliasAs("tenants")] string tenants = null,
			[AliasAs("page_first")] decimal? page_first = null,
			[AliasAs("page_after")] string page_after = null,
			[AliasAs("page_last")] decimal? page_last = null,
			[AliasAs("page_before")] string page_before = null,
			CancellationToken? cancellationToken = null
		);

		/// <summary>
		/// Read Multiple Devices' Info
		/// </summary>
		/// <remarks>
		/// Use the Read Multiple Devices' Info API to pull the collected information about the various devices Auvik has discovered. You'll need the client IDs for the clients you want to run the multiple read against.&lt;br&gt; &lt;br&gt; To find the client IDs, run the &lt;a href&#x3D;\&quot;#operation/readMultipleTenants\&quot;&gt;Read Multiple Tenants API.&lt;/a&gt;&lt;br&gt; &lt;br&gt; Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command: &lt;ul&gt;	 &lt;li&gt;Within the API URL, &lt;b&gt;us1.my&lt;/b&gt; (https://auvikapi.us1.my.auvik.com) should be updated to match the region in which your account resides. To locate the region, log into your Auvik dashboard and look at the URL in your browser's address bar.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view device information.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;195798545063742726&lt;/i&gt; should be the ID or comma delimited IDs of the client(s) whose data you wish to fetch information from. &lt;/li&gt;	 &lt;li&gt;&lt;i&gt;filter[deviceType]&#x3D;router&lt;/i&gt; should be whichever key and value pair you want to filter the result set by. See below for a list of filterable parameters.&lt;/li&gt; &lt;/ul&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="filter_networks">Filter by IDs of networks this device is on. (optional)</param>
		/// <param name="filter_deviceType">Filter by device type. (optional)</param>
		/// <param name="filter_makeModel">Filter by the device's make and model. (optional)</param>
		/// <param name="filter_vendorName">Filter by the device's vendor/manufacturer. (optional)</param>
		/// <param name="filter_onlineStatus">Filter by the device's online status. (optional)</param>
		/// <param name="filter_modifiedAfter">Filter by date and time, only returning entities modified after provided value. (optional)</param>
		/// <param name="filter_notSeenSince">Filter by the last seen online time, returning entities not seen online after the provided value. (optional)</param>
		/// <param name="tenants">Comma delimited list of tenant IDs to request info from. (optional)</param>
		/// <param name="page_first">For paginated responses, the first N elements will be returned. Used in combination with &lt;code&gt;page[after]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_after">Cursor after which elements will be returned as a page. The page size is provided by &lt;code&gt;page[first]&lt;/code&gt;. (optional)</param>
		/// <param name="page_last">For paginated responses, the last N services will be returned. Used in combination with &lt;code&gt;page[before]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_before">Cursor before which elements will be returned as a page. The page size is provided by &lt;code&gt;page[last]&lt;/code&gt;. (optional)</param>
		/// <param name="include">Use to include the full resource objects of the list device relationships. (optional)</param>
		/// <param name="fields_deviceDetail">Use to limit the attributes that will be returned in the included detail object to only what is specified by this query parameter. Requires &lt;code&gt;include&#x3D;deviceDetail&lt;/code&gt; (optional)</param>
		/// <returns>Task of DeviceInfoReadMultiple</returns>
		[Get("/v1/inventory/device/info")]
		Task<DeviceInfoReadMultiple> ReadMultipleDeviceInfo(
			[AliasAs("filter_networks")] string filter_networks = null,
			[AliasAs("filter_deviceType")] string filter_deviceType = null,
			[AliasAs("filter_makeModel")] string filter_makeModel = null,
			[AliasAs("filter_vendorName")] string filter_vendorName = null,
			[AliasAs("filter_onlineStatus")] string filter_onlineStatus = null,
			[AliasAs("filter_modifiedAfter")] string filter_modifiedAfter = null,
			[AliasAs("filter_notSeenSince")] string filter_notSeenSince = null,
			[AliasAs("tenants")] string tenants = null,
			[AliasAs("page_first")] decimal? page_first = null,
			[AliasAs("page_after")] string page_after = null,
			[AliasAs("page_last")] decimal? page_last = null,
			[AliasAs("page_before")] string page_before = null,
			[AliasAs("include")] string include = null,
			[AliasAs("fields_deviceDetail")] string fields_deviceDetail = null,
			CancellationToken? cancellationToken = null
		);

		/// <summary>
		/// Read Multiple Devices' Lifecycle Info
		/// </summary>
		/// <remarks>
		/// Use the Read Multiple Devices' Lifecycle API to pull the collected lifecycle information about the various devices Auvik has discovered. You'll need the client IDs for the clients you want to run the multiple read against.&lt;br&gt; &lt;br&gt; To find the client IDs, run the &lt;a href&#x3D;\&quot;#operation/readMultipleTenants\&quot;&gt;Read Multiple Tenants API.&lt;/a&gt;&lt;br&gt; &lt;br&gt; Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command: &lt;ul&gt;	 &lt;li&gt;Within the API URL, &lt;b&gt;us1.my&lt;/b&gt; (https://auvikapi.us1.my.auvik.com) should be updated to match the region in which your account resides. To locate the region, log into your Auvik dashboard and look at the URL in your browser's address bar.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view device information.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;195798545063742726&lt;/i&gt; should be the ID or comma delimited IDs of the client(s) whose data you wish to fetch information from. &lt;/li&gt;	 &lt;li&gt;&lt;i&gt;filter[salesAvailability]&#x3D;available&lt;/i&gt; should be whichever key and value pair you want to filter the result set by. See below for a list of filterable parameters.&lt;/li&gt; &lt;/ul&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="filter_salesAvailability">Filter by sales availability. (optional)</param>
		/// <param name="filter_softwareMaintenanceStatus">Filter by software maintenance status. (optional)</param>
		/// <param name="filter_securitySoftwareMaintenanceStatus">Filter by security software maintenance status. (optional)</param>
		/// <param name="filter_lastSupportStatus">Filter by last support status. (optional)</param>
		/// <param name="tenants">Comma delimited list of tenant IDs to request info from. (optional)</param>
		/// <param name="page_first">For paginated responses, the first N elements will be returned. Used in combination with &lt;code&gt;page[after]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_after">Cursor after which elements will be returned as a page. The page size is provided by &lt;code&gt;page[first]&lt;/code&gt;. (optional)</param>
		/// <param name="page_last">For paginated responses, the last N services will be returned. Used in combination with &lt;code&gt;page[before]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_before">Cursor before which elements will be returned as a page. The page size is provided by &lt;code&gt;page[last]&lt;/code&gt;. (optional)</param>
		/// <returns>Task of DeviceLifecycleReadMultiple</returns>
		[Get("/v1/inventory/device/lifecycle")]
		Task<DeviceLifecycleReadMultiple> ReadMultipleDeviceLifecycle(
			[AliasAs("filter_salesAvailability")] string filter_salesAvailability = null,
			[AliasAs("filter_softwareMaintenanceStatus")] string filter_softwareMaintenanceStatus = null,
			[AliasAs("filter_securitySoftwareMaintenanceStatus")] string filter_securitySoftwareMaintenanceStatus = null,
			[AliasAs("filter_lastSupportStatus")] string filter_lastSupportStatus = null,
			[AliasAs("tenants")] string tenants = null,
			[AliasAs("page_first")] decimal? page_first = null,
			[AliasAs("page_after")] string page_after = null,
			[AliasAs("page_last")] decimal? page_last = null,
			[AliasAs("page_before")] string page_before = null,
			CancellationToken? cancellationToken = null
		);

		/// <summary>
		/// Read Multiple Devices' Warranty Info
		/// </summary>
		/// <remarks>
		/// Use the Read Multiple Devices' Warranty API to pull the collected warranty information about the various devices Auvik has discovered. You'll need the client IDs for the clients you want to run the multiple read against.&lt;br&gt; &lt;br&gt; To find the client IDs, run the &lt;a href&#x3D;\&quot;#operation/readMultipleTenants\&quot;&gt;Read Multiple Tenants API.&lt;/a&gt;&lt;br&gt; &lt;br&gt; Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command: &lt;ul&gt;	 &lt;li&gt;Within the API URL, &lt;b&gt;us1.my&lt;/b&gt; (https://auvikapi.us1.my.auvik.com) should be updated to match the region in which your account resides. To locate the region, log into your Auvik dashboard and look at the URL in your browser's address bar.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view device information.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;195798545063742726&lt;/i&gt; should be the ID or comma delimited IDs of the client(s) whose data you wish to fetch information from. &lt;/li&gt;	 &lt;li&gt;&lt;i&gt;filter[coveredUnderWarranty]&#x3D;true&lt;/i&gt; should be whichever key and value pair you want to filter the result set by. See below for a list of filterable parameters.&lt;/li&gt; &lt;/ul&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="filter_coveredUnderWarranty">Filter by warranty coverage status. (optional)</param>
		/// <param name="filter_coveredUnderService">Filter by service coverage status. (optional)</param>
		/// <param name="tenants">Comma delimited list of tenant IDs to request info from. (optional)</param>
		/// <param name="page_first">For paginated responses, the first N elements will be returned. Used in combination with &lt;code&gt;page[after]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_after">Cursor after which elements will be returned as a page. The page size is provided by &lt;code&gt;page[first]&lt;/code&gt;. (optional)</param>
		/// <param name="page_last">For paginated responses, the last N services will be returned. Used in combination with &lt;code&gt;page[before]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_before">Cursor before which elements will be returned as a page. The page size is provided by &lt;code&gt;page[last]&lt;/code&gt;. (optional)</param>
		/// <returns>Task of DeviceWarrantyReadMultiple</returns>
		[Get("/v1/inventory/device/warranty")]
		Task<DeviceWarrantyReadMultiple> ReadMultipleDeviceWarranty(
			[AliasAs("filter_coveredUnderWarranty")] bool? filter_coveredUnderWarranty = null,
			[AliasAs("filter_coveredUnderService")] bool? filter_coveredUnderService = null,
			[AliasAs("tenants")] string tenants = null,
			[AliasAs("page_first")] decimal? page_first = null,
			[AliasAs("page_after")] string page_after = null,
			[AliasAs("page_last")] decimal? page_last = null,
			[AliasAs("page_before")] string page_before = null,
			CancellationToken? cancellationToken = null
		);

		/// <summary>
		/// Read a Single Device's Details
		/// </summary>
		/// <remarks>
		/// Use the Read Single Device's Details API to pull extra collected information about a specific device Auvik has discovered not already included in the Device Info API. You'll need the device ID for the specific device.&lt;br&gt; &lt;br&gt; To find the device IDs, run the &lt;a href&#x3D;\&quot;#operation/readMultipleDeviceInfo\&quot;&gt;Read Multiple Devices API&lt;/a&gt;.&lt;br&gt; &lt;br&gt; Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command: &lt;ul&gt;	 &lt;li&gt;Within the API URL, &lt;b&gt;us1.my&lt;/b&gt; (https://auvikapi.us1.my.auvik.com) should be updated to match the region in which your account resides. To locate the region, log into your Auvik dashboard and look at the URL in your browser's address bar.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view device details.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;MTk...2Nw&lt;/i&gt; should be the device's ID.&lt;/li&gt; &lt;/ul&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">ID of device</param>
		/// <returns>Task of DeviceDetailsReadSingle</returns>
		[Get("/v1/inventory/device/detail/{id}")]
		Task<DeviceDetailsReadSingle> ReadSingleDeviceDetails(
			[AliasAs("id")] string id,
			CancellationToken? cancellationToken = null
		);

		/// <summary>
		/// Read a Single Device's Extended Details
		/// </summary>
		/// <remarks>
		/// Use the Read Single Device's Extended Details API to get a device's extended details. Many device types have information collected and tracked by Auvik that are unique to that device type. Use this endpoint to access such information for a given device.&lt;br&gt; &lt;br&gt; To find the device IDs, run the &lt;a href&#x3D;\&quot;#operation/readMultipleDeviceInfo\&quot;&gt;Read Multiple Devices API&lt;/a&gt;.&lt;br&gt; &lt;br&gt; Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command: &lt;ul&gt;	 &lt;li&gt;Within the API URL, &lt;b&gt;us1.my&lt;/b&gt; (https://auvikapi.us1.my.auvik.com) should be updated to match the region in which your account resides. To locate the region, log into your Auvik dashboard and look at the URL in your browser's address bar.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view device extended details.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;MTk...2Nw&lt;/i&gt; should be the device's ID.&lt;/li&gt; &lt;/ul&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">ID of device</param>
		/// <returns>Task of DeviceDetailsExtendedReadSingle</returns>
		[Get("/v1/inventory/device/detail/extended/{id}")]
		Task<DeviceDetailsExtendedReadSingle> ReadSingleDeviceExtendedDetail(
			[AliasAs("id")] string id,
			CancellationToken? cancellationToken = null
		);

		/// <summary>
		/// Read a Single Device's Info
		/// </summary>
		/// <remarks>
		/// Use the Read Single Device's Info API to pull the collected information about a specific device Auvik has discovered. You'll need the device ID for the specific device.&lt;br&gt; &lt;br&gt; To find the device IDs, run the &lt;a href&#x3D;\&quot;#operation/readMultipleDeviceInfo\&quot;&gt;Read Multiple Devices API&lt;/a&gt;.&lt;br&gt; &lt;br&gt; Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command: &lt;ul&gt;	 &lt;li&gt;Within the API URL, &lt;b&gt;us1.my&lt;/b&gt; (https://auvikapi.us1.my.auvik.com) should be updated to match the region in which your account resides. To locate the region, log into your Auvik dashboard and look at the URL in your browser's address bar.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view device information.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;MTk...2Nw&lt;/i&gt; should be the device's ID. &lt;/li&gt;&lt;/ul&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">ID of device</param>
		/// <param name="include">Use to include the full resource objects of the list device relationships. (optional)</param>
		/// <param name="fields_deviceDetail">Use to limit the attributes that will be returned in the included detail object to only what is specified by this query parameter. Requires &lt;code&gt;include&#x3D;deviceDetail&lt;/code&gt; (optional)</param>
		/// <returns>Task of DeviceInfoReadSingle</returns>
		[Get("/v1/inventory/device/info/{id}")]
		Task<DeviceInfoReadSingle> ReadSingleDeviceInfo(
			[AliasAs("id")] string id,
			[AliasAs("include")] string include = null,
			[AliasAs("fields_deviceDetail")] string fields_deviceDetail = null,
			CancellationToken? cancellationToken = null
		);

		/// <summary>
		/// Read a Single Device's Lifecycle Info
		/// </summary>
		/// <remarks>
		/// Use the Read Single Device's Lifecycle Info API to pull the collected information about a specific device Auvik has discovered. You'll need the device ID for the specific device.&lt;br&gt; &lt;br&gt; To find the device IDs, run the &lt;a href&#x3D;\&quot;#operation/readMultipleDeviceInfo\&quot;&gt;Read Multiple Devices API&lt;/a&gt;.&lt;br&gt; &lt;br&gt; Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command: &lt;ul&gt;	 &lt;li&gt;Within the API URL, &lt;b&gt;us1.my&lt;/b&gt; (https://auvikapi.us1.my.auvik.com) should be updated to match the region in which your account resides. To locate the region, log into your Auvik dashboard and look at the URL in your browser's address bar.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view device information.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;MTk...2Nw&lt;/i&gt; should be the device's ID. &lt;/li&gt;&lt;/ul&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">ID of device</param>
		/// <returns>Task of DeviceLifecycleReadSingle</returns>
		[Get("/v1/inventory/device/lifecycle/{id}")]
		Task<DeviceLifecycleReadSingle> ReadSingleDeviceLifecycle(
			[AliasAs("id")] string id,
			CancellationToken? cancellationToken = null
		);

		/// <summary>
		/// Read a Single Device's Warranty Info
		/// </summary>
		/// <remarks>
		/// Use the Read Single Device's Warranty Info API to pull the collected information about a specific device Auvik has discovered. You'll need the device ID for the specific device.&lt;br&gt; &lt;br&gt; To find the device IDs, run the &lt;a href&#x3D;\&quot;#operation/readMultipleDeviceInfo\&quot;&gt;Read Multiple Devices API&lt;/a&gt;.&lt;br&gt; &lt;br&gt; Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command: &lt;ul&gt;	 &lt;li&gt;Within the API URL, &lt;b&gt;us1.my&lt;/b&gt; (https://auvikapi.us1.my.auvik.com) should be updated to match the region in which your account resides. To locate the region, log into your Auvik dashboard and look at the URL in your browser's address bar.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view device information.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;MTk...2Nw&lt;/i&gt; should be the device's ID. &lt;/li&gt;&lt;/ul&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">ID of device</param>
		/// <returns>Task of DeviceWarrantyReadSingle</returns>
		[Get("/v1/inventory/device/warranty/{id}")]
		Task<DeviceWarrantyReadSingle> ReadSingleDeviceWarranty(
			[AliasAs("id")] string id,
			CancellationToken? cancellationToken = null
		);
	}
}
