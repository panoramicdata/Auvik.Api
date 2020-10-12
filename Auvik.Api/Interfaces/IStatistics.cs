using Auvik.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Auvik.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IStatistics
	{
		/// <summary>
		/// Read Component Statistics
		/// </summary>
		/// <remarks>
		/// Use the Read Component Statistics API to fetch detailed statistics of a client's (and client's children if a multi-client) components for a given time range.&lt;br&gt; Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command: &lt;ul&gt;	 &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view component statistics information.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;2020-03-10T01:00:00.000Z&lt;/i&gt; should be the date from which you want to query.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;2020-03-11T01:00:00.000Z&lt;/i&gt; should be the date to which you want to query.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;hour&lt;/i&gt; should be the reporting interval for the statistics that are returned.&lt;/li&gt; &lt;/ul&gt;Each component type specified in the query path supports reporting statistics as indicated below: &lt;table&gt;&lt;tr&gt;&lt;th&gt;componentType&lt;/th&gt;&lt;th&gt;statId&lt;/th&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;cpu&lt;/td&gt;&lt;td&gt;&lt;ul&gt;&lt;li&gt;capacity&lt;/li&gt;&lt;li&gt;latency&lt;/li&gt;&lt;li&gt;readiness&lt;/li&gt;&lt;li&gt;ready&lt;/li&gt;&lt;li&gt;swap&lt;/li&gt;&lt;/ul&gt;&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;cpuCore&lt;/td&gt;&lt;td&gt;&lt;ul&gt;&lt;li&gt;idle&lt;/li&gt;&lt;li&gt;utilization&lt;/li&gt;&lt;/ul&gt;&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;disk&lt;/td&gt;&lt;td&gt;&lt;ul&gt;&lt;li&gt;latency&lt;/li&gt;&lt;li&gt;queueLatency&lt;/li&gt;&lt;li&gt;rate&lt;/li&gt;&lt;li&gt;totalLatency&lt;/li&gt;&lt;/ul&gt;&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;fan&lt;/td&gt;&lt;td&gt;&lt;ul&gt;&lt;li&gt;speed&lt;/li&gt;&lt;/ul&gt;&lt;/td&gt;&lt;/tr&gt;&lt;/tr&gt;&lt;td&gt;memory&lt;/td&gt;&lt;td&gt;&lt;ul&gt;&lt;li&gt;counters&lt;/li&gt;&lt;li&gt;swap&lt;/li&gt;&lt;li&gt;swapRate&lt;/li&gt;&lt;li&gt;temperature&lt;/li&gt;&lt;/ul&gt;&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;powerSupply&lt;/td&gt;&lt;td&gt;&lt;ul&gt;&lt;li&gt;power&lt;/li&gt;&lt;/ul&gt;&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;systemBoard&lt;/td&gt;&lt;td&gt;&lt;ul&gt;&lt;li&gt;temperature&lt;/li&gt;&lt;/ul&gt;&lt;/td&gt;&lt;/tr&gt;&lt;/table&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="componentType">Component type of statistic to return</param>
		/// <param name="statId">ID of statistic to return</param>
		/// <param name="filter_fromTime">Timestamp from which you want to query</param>
		/// <param name="filter_interval">Statistics reporting interval</param>
		/// <param name="filter_thruTime">Timestamp to which you want to query (defaults to current time) (optional)</param>
		/// <param name="filter_componentId">Filter by component ID. (optional)</param>
		/// <param name="filter_parentDevice">Filter by the entity's parent device ID. (optional)</param>
		/// <param name="tenants">Comma delimited list of tenant IDs to request info from. (optional)</param>
		/// <param name="page_first">For paginated responses, the first N elements will be returned. Used in combination with &lt;code&gt;page[after]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_after">Cursor after which elements will be returned as a page. The page size is provided by &lt;code&gt;page[first]&lt;/code&gt;. (optional)</param>
		/// <param name="page_last">For paginated responses, the last N services will be returned. Used in combination with &lt;code&gt;page[before]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_before">Cursor before which elements will be returned as a page. The page size is provided by &lt;code&gt;page[last]&lt;/code&gt;. (optional)</param>
		/// <returns>Task of ComponentStatisticsRead</returns>
		[Get("/v1/stat/component/{componentType}/{statId}")]
		Task<ComponentStatisticsRead> ReadComponentStatistics(
			[Header("UserAgent")] string userAgent,
			[AliasAs("componentType")] string componentType,
			[AliasAs("statId")] string statId,
			[AliasAs("filter_fromTime")] string filter_fromTime,
			[AliasAs("filter_interval")] string filter_interval,
			[AliasAs("filter_thruTime")] string filter_thruTime = null,
			[AliasAs("filter_componentId")] string filter_componentId = null,
			[AliasAs("filter_parentDevice")] string filter_parentDevice = null,
			[AliasAs("tenants")] string tenants = null,
			[AliasAs("page_first")] decimal? page_first = null,
			[AliasAs("page_after")] string page_after = null,
			[AliasAs("page_last")] decimal? page_last = null,
			[AliasAs("page_before")] string page_before = null,
			CancellationToken? cancellationToken = null
		);

		/// <summary>
		/// Read Device Availability Statistics
		/// </summary>
		/// <remarks>
		/// Use the Read Device Availability Statistics API to fetch detailed availability statistics of a client's (and client's children if a multi-client) devices for a given time range.&lt;br&gt; Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command: &lt;ul&gt;	 &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view device availability statistics information.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;2020-03-10T01:00:00.000Z&lt;/i&gt; should be the date from which you want to query.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;2020-03-11T01:00:00.000Z&lt;/i&gt; should be the date to which you want to query.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;hour&lt;/i&gt; should be the reporting interval for the statistics that are returned.&lt;/li&gt; &lt;/ul&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="statId">ID of statistic to return</param>
		/// <param name="filter_fromTime">Timestamp from which you want to query</param>
		/// <param name="filter_interval">Statistics reporting interval</param>
		/// <param name="filter_thruTime">Timestamp to which you want to query (defaults to current time) (optional)</param>
		/// <param name="filter_deviceType">Filter by device type. (optional)</param>
		/// <param name="filter_deviceId">Filter by device ID (optional)</param>
		/// <param name="tenants">Comma delimited list of tenant IDs to request info from. (optional)</param>
		/// <param name="page_first">For paginated responses, the first N elements will be returned. Used in combination with &lt;code&gt;page[after]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_after">Cursor after which elements will be returned as a page. The page size is provided by &lt;code&gt;page[first]&lt;/code&gt;. (optional)</param>
		/// <param name="page_last">For paginated responses, the last N services will be returned. Used in combination with &lt;code&gt;page[before]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_before">Cursor before which elements will be returned as a page. The page size is provided by &lt;code&gt;page[last]&lt;/code&gt;. (optional)</param>
		/// <returns>Task of DeviceAvailabilityStatisticsRead</returns>
		[Get("/v1/stat/deviceAvailability/{statId}")]
		Task<DeviceAvailabilityStatisticsRead> ReadDeviceAvailabilityStatistics(
			[AliasAs("statId")] string statId,
			[AliasAs("filter_fromTime")] string filter_fromTime,
			[AliasAs("filter_interval")] string filter_interval,
			[AliasAs("filter_thruTime")] string filter_thruTime = null,
			[AliasAs("filter_deviceType")] string filter_deviceType = null,
			[AliasAs("filter_deviceId")] string filter_deviceId = null,
			[AliasAs("tenants")] string tenants = null,
			[AliasAs("page_first")] decimal? page_first = null,
			[AliasAs("page_after")] string page_after = null,
			[AliasAs("page_last")] decimal? page_last = null,
			[AliasAs("page_before")] string page_before = null,
			CancellationToken? cancellationToken = null
		);

		/// <summary>
		/// Read Device Statistics
		/// </summary>
		/// <remarks>
		/// Use the Read Device Statistics API to fetch detailed statistics of a client's (and client's children if a multi-client) devices for a given time range.&lt;br&gt; Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command: &lt;ul&gt;	 &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view device statistics information.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;2020-03-10T01:00:00.000Z&lt;/i&gt; should be the date from which you want to query.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;2020-03-11T01:00:00.000Z&lt;/i&gt; should be the date to which you want to query.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;hour&lt;/i&gt; should be the reporting interval for the statistics that are returned.&lt;/li&gt; &lt;/ul&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="statId">ID of statistic to return</param>
		/// <param name="filter_fromTime">Timestamp from which you want to query</param>
		/// <param name="filter_interval">Statistics reporting interval</param>
		/// <param name="filter_thruTime">Timestamp to which you want to query (defaults to current time) (optional)</param>
		/// <param name="filter_deviceType">Filter by device type. (optional)</param>
		/// <param name="filter_deviceId">Filter by device ID (optional)</param>
		/// <param name="tenants">Comma delimited list of tenant IDs to request info from. (optional)</param>
		/// <param name="page_first">For paginated responses, the first N elements will be returned. Used in combination with &lt;code&gt;page[after]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_after">Cursor after which elements will be returned as a page. The page size is provided by &lt;code&gt;page[first]&lt;/code&gt;. (optional)</param>
		/// <param name="page_last">For paginated responses, the last N services will be returned. Used in combination with &lt;code&gt;page[before]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_before">Cursor before which elements will be returned as a page. The page size is provided by &lt;code&gt;page[last]&lt;/code&gt;. (optional)</param>
		/// <returns>Task of DeviceStatisticsRead</returns>
		[Get("/v1/stat/device/{statId}")]
		Task<DeviceStatisticsRead> ReadDeviceStatistics(
			[AliasAs("statId")] string statId,
			[AliasAs("filter_fromTime")] string filter_fromTime,
			[AliasAs("filter_interval")] string filter_interval,
			[AliasAs("filter_thruTime")] string filter_thruTime = null,
			[AliasAs("filter_deviceType")] string filter_deviceType = null,
			[AliasAs("filter_deviceId")] string filter_deviceId = null,
			[AliasAs("tenants")] string tenants = null,
			[AliasAs("page_first")] decimal? page_first = null,
			[AliasAs("page_after")] string page_after = null,
			[AliasAs("page_last")] decimal? page_last = null,
			[AliasAs("page_before")] string page_before = null,
			CancellationToken? cancellationToken = null
		);

		/// <summary>
		/// Read Interface Statistics
		/// </summary>
		/// <remarks>
		/// Use the Read Interface Statistics API to fetch detailed statistics of a client's (and client's children if a multi-client) interfaces for a given time range.&lt;br&gt; Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command: &lt;ul&gt;	 &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view interface statistics information.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;2020-03-10T01:00:00.000Z&lt;/i&gt; should be the date from which you want to query.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;2020-03-11T01:00:00.000Z&lt;/i&gt; should be the date to which you want to query.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;hour&lt;/i&gt; should be the reporting interval for the statistics that are returned.&lt;/li&gt; &lt;/ul&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="statId">ID of statistic to return</param>
		/// <param name="filter_fromTime">Timestamp from which you want to query</param>
		/// <param name="filter_interval">Statistics reporting interval</param>
		/// <param name="filter_thruTime">Timestamp to which you want to query (defaults to current time) (optional)</param>
		/// <param name="filter_interfaceType">Filter by interface type. (optional)</param>
		/// <param name="filter_interfaceId">Filter by interface ID. (optional)</param>
		/// <param name="filter_parentDevice">Filter by the entity's parent device ID. (optional)</param>
		/// <param name="tenants">Comma delimited list of tenant IDs to request info from. (optional)</param>
		/// <param name="page_first">For paginated responses, the first N elements will be returned. Used in combination with &lt;code&gt;page[after]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_after">Cursor after which elements will be returned as a page. The page size is provided by &lt;code&gt;page[first]&lt;/code&gt;. (optional)</param>
		/// <param name="page_last">For paginated responses, the last N services will be returned. Used in combination with &lt;code&gt;page[before]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_before">Cursor before which elements will be returned as a page. The page size is provided by &lt;code&gt;page[last]&lt;/code&gt;. (optional)</param>
		/// <returns>Task of InterfaceStatisticsRead</returns>
		[Get("/v1/stat/interface/{statId}")]
		Task<InterfaceStatisticsRead> ReadInterfaceStatistics(
			[AliasAs("statId")] string statId,
			[AliasAs("filter_fromTime")] string filter_fromTime,
			[AliasAs("filter_interval")] string filter_interval,
			[AliasAs("filter_thruTime")] string filter_thruTime = null,
			[AliasAs("filter_interfaceType")] string filter_interfaceType = null,
			[AliasAs("filter_interfaceId")] string filter_interfaceId = null,
			[AliasAs("filter_parentDevice")] string filter_parentDevice = null,
			[AliasAs("tenants")] string tenants = null,
			[AliasAs("page_first")] decimal? page_first = null,
			[AliasAs("page_after")] string page_after = null,
			[AliasAs("page_last")] decimal? page_last = null,
			[AliasAs("page_before")] string page_before = null,
			CancellationToken? cancellationToken = null
		);

		/// <summary>
		/// Read OID Statistics
		/// </summary>
		/// <remarks>
		/// Use the Read OID Statistics API to fetch the last recorded value of a monitored device OID.&lt;br&gt; Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command: &lt;ul&gt;	 &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view device statistics information.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt; &lt;/ul&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="statId">ID of statistic to return</param>
		/// <param name="filter_deviceId">Filter by device ID (optional)</param>
		/// <param name="filter_deviceType">Filter by device type. (optional)</param>
		/// <param name="filter_oid">Filter by OID (optional)</param>
		/// <param name="tenants">Comma delimited list of tenant IDs to request info from. (optional)</param>
		/// <param name="page_first">For paginated responses, the first N elements will be returned. Used in combination with &lt;code&gt;page[after]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_after">Cursor after which elements will be returned as a page. The page size is provided by &lt;code&gt;page[first]&lt;/code&gt;. (optional)</param>
		/// <param name="page_last">For paginated responses, the last N services will be returned. Used in combination with &lt;code&gt;page[before]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_before">Cursor before which elements will be returned as a page. The page size is provided by &lt;code&gt;page[last]&lt;/code&gt;. (optional)</param>
		/// <returns>Task of DeviceOidMonitorRead</returns>
		[Get("/v1/stat/oid/{statId}")]
		Task<DeviceOidMonitorRead> ReadOidStatistics(
			[AliasAs("statId")] string statId,
			[AliasAs("filter_deviceId")] string filter_deviceId = null,
			[AliasAs("filter_deviceType")] string filter_deviceType = null,
			[AliasAs("filter_oid")] string filter_oid = null,
			[AliasAs("tenants")] string tenants = null,
			[AliasAs("page_first")] decimal? page_first = null,
			[AliasAs("page_after")] string page_after = null,
			[AliasAs("page_last")] decimal? page_last = null,
			[AliasAs("page_before")] string page_before = null,
			CancellationToken? cancellationToken = null
		);

		/// <summary>
		/// Read Service Statistics
		/// </summary>
		/// <remarks>
		/// Use the Read Service Statistics API to fetch detailed statistics of a client's (and client's children if a multi-client) services for a given time range.&lt;br&gt; Looking at the detail screen on the right, click cURL to see the command that will be used. Click &lt;b&gt;Copy&lt;/b&gt; to copy the details of the command to your clipboard. Be sure to edit the following parameters within the command: &lt;ul&gt;	 &lt;li&gt;&lt;i&gt;user@example.com&lt;/i&gt; should be the email address of a user with permissions to view service statistics information.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;apiKey&lt;/i&gt; should be the API key that's been set for the user.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;2020-03-10T01:00:00.000Z&lt;/i&gt; should be the date from which you want to query.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;2020-03-11T01:00:00.000Z&lt;/i&gt; should be the date to which you want to query.&lt;/li&gt;	 &lt;li&gt;&lt;i&gt;hour&lt;/i&gt; should be the reporting interval for the statistics that are returned.&lt;/li&gt; &lt;/ul&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="statId">ID of statistic to return</param>
		/// <param name="filter_fromTime">Timestamp from which you want to query</param>
		/// <param name="filter_interval">Statistics reporting interval</param>
		/// <param name="filter_thruTime">Timestamp to which you want to query (defaults to current time) (optional)</param>
		/// <param name="filter_serviceId">Filter by service ID (optional)</param>
		/// <param name="tenants">Comma delimited list of tenant IDs to request info from. (optional)</param>
		/// <param name="page_first">For paginated responses, the first N elements will be returned. Used in combination with &lt;code&gt;page[after]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_after">Cursor after which elements will be returned as a page. The page size is provided by &lt;code&gt;page[first]&lt;/code&gt;. (optional)</param>
		/// <param name="page_last">For paginated responses, the last N services will be returned. Used in combination with &lt;code&gt;page[before]&lt;/code&gt;. (optional, default to 100)</param>
		/// <param name="page_before">Cursor before which elements will be returned as a page. The page size is provided by &lt;code&gt;page[last]&lt;/code&gt;. (optional)</param>
		/// <returns>Task of ServiceStatisticsRead</returns>
		[Get("/v1/stat/service/{statId}")]
		Task<ServiceStatisticsRead> ReadServiceStatistics(
			[Header("UserAgent")] string userAgent,
			[AliasAs("statId")] string statId,
			[AliasAs("filter_fromTime")] string filter_fromTime,
			[AliasAs("filter_interval")] string filter_interval,
			[AliasAs("filter_thruTime")] string filter_thruTime = null,
			[AliasAs("filter_serviceId")] string filter_serviceId = null,
			[AliasAs("tenants")] string tenants = null,
			[AliasAs("page_first")] decimal? page_first = null,
			[AliasAs("page_after")] string page_after = null,
			[AliasAs("page_last")] decimal? page_last = null,
			[AliasAs("page_before")] string page_before = null,
			CancellationToken? cancellationToken = null
		);
	}
}
