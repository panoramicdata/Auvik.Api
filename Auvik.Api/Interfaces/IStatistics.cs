#nullable disable

using Auvik.Api.Data;
using Refit;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Auvik.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IStatistics
{
	/// <summary>
	/// Read Component Statistics
	/// </summary>
	/// <remarks>
	/// Fetch detailed statistics of a client's (and client's children if a multi-client) components for a given time range.
	/// Supported component/stat combinations: cpu (capacity, latency, readiness, ready, swap), cpuCore (idle, utilization),
	/// disk (latency, queueLatency, rate, totalLatency), fan (speed), memory (counters, swap, swapRate, temperature),
	/// powerSupply (power), systemBoard (temperature).
	/// </remarks>
	/// <exception cref="System.Exception">Thrown when fails to make API call</exception>
	/// <param name="componentType">Component type of statistic to return</param>
	/// <param name="statId">ID of statistic to return</param>
	/// <param name="timeRange">The time range and reporting interval to query.</param>
	/// <param name="filter_componentId">Filter by component ID. (optional)</param>
	/// <param name="filter_parentDevice">Filter by the entity's parent device ID. (optional)</param>
	/// <param name="tenants">Comma delimited list of tenant IDs to request info from. (optional)</param>
	/// <param name="paging">Cursor-based paging options. (optional)</param>
	/// <param name="userAgent">userAgent parameter.</param>
	/// <param name="cancellationToken">cancellationToken parameter.</param>
	/// <returns>Task of ComponentStatisticsRead</returns>
	[Get("/v1/stat/component/{componentType}/{statId}")]
	Task<ComponentStatisticsRead> ReadComponentStatistics(
		[Header("UserAgent")] string userAgent,
		[AliasAs("componentType")] string componentType,
		[AliasAs("statId")] string statId,
		[Query] StatisticsTimeRange timeRange,
		[AliasAs("filter[componentId]")] string filter_componentId = null,
		[AliasAs("filter[parentDevice]")] string filter_parentDevice = null,
		[AliasAs("tenants")] string tenants = null,
		[Query, Optional] PagingOptions paging,
		CancellationToken? cancellationToken = null
	);

	/// <summary>
	/// Read Device Availability Statistics
	/// </summary>
	/// <remarks>
	/// Fetch detailed availability statistics of a client's (and client's children if a multi-client) devices for a given time range.
	/// </remarks>
	/// <exception cref="System.Exception">Thrown when fails to make API call</exception>
	/// <param name="statId">ID of statistic to return</param>
	/// <param name="timeRange">The time range and reporting interval to query.</param>
	/// <param name="filter_deviceType">Filter by device type. (optional)</param>
	/// <param name="filter_deviceId">Filter by device ID (optional)</param>
	/// <param name="tenants">Comma delimited list of tenant IDs to request info from. (optional)</param>
	/// <param name="paging">Cursor-based paging options. (optional)</param>
	/// <param name="cancellationToken">cancellationToken parameter.</param>
	/// <returns>Task of DeviceAvailabilityStatisticsRead</returns>
	[Get("/v1/stat/deviceAvailability/{statId}")]
	Task<DeviceAvailabilityStatisticsRead> ReadDeviceAvailabilityStatistics(
		[AliasAs("statId")] string statId,
		[Query] StatisticsTimeRange timeRange,
		[AliasAs("filter[deviceType]")] string filter_deviceType = null,
		[AliasAs("filter[deviceId]")] string filter_deviceId = null,
		[AliasAs("tenants")] string tenants = null,
		[Query, Optional] PagingOptions paging,
		CancellationToken? cancellationToken = null
	);

	/// <summary>
	/// Read Device Statistics
	/// </summary>
	/// <remarks>
	/// Fetch detailed statistics of a client's (and client's children if a multi-client) devices for a given time range.
	/// </remarks>
	/// <exception cref="System.Exception">Thrown when fails to make API call</exception>
	/// <param name="statId">ID of statistic to return</param>
	/// <param name="timeRange">The time range and reporting interval to query.</param>
	/// <param name="filter_deviceType">Filter by device type. (optional)</param>
	/// <param name="filter_deviceId">Filter by device ID (optional)</param>
	/// <param name="tenants">Comma delimited list of tenant IDs to request info from. (optional)</param>
	/// <param name="paging">Cursor-based paging options. (optional)</param>
	/// <param name="cancellationToken">cancellationToken parameter.</param>
	/// <returns>Task of DeviceStatisticsRead</returns>
	[Get("/v1/stat/device/{statId}")]
	Task<DeviceStatisticsRead> ReadDeviceStatistics(
		[AliasAs("statId")] string statId,
		[Query] StatisticsTimeRange timeRange,
		[AliasAs("filter[deviceType]")] string filter_deviceType = null,
		[AliasAs("filter[deviceId]")] string filter_deviceId = null,
		[AliasAs("tenants")] string tenants = null,
		[Query, Optional] PagingOptions paging,
		CancellationToken? cancellationToken = null
	);

	/// <summary>
	/// Read Interface Statistics
	/// </summary>
	/// <remarks>
	/// Fetch detailed statistics of a client's (and client's children if a multi-client) interfaces for a given time range.
	/// </remarks>
	/// <exception cref="System.Exception">Thrown when fails to make API call</exception>
	/// <param name="statId">ID of statistic to return</param>
	/// <param name="timeRange">The time range and reporting interval to query.</param>
	/// <param name="filter_interfaceType">Filter by interface type. (optional)</param>
	/// <param name="filter_interfaceId">Filter by interface ID. (optional)</param>
	/// <param name="filter_parentDevice">Filter by the entity's parent device ID. (optional)</param>
	/// <param name="tenants">Comma delimited list of tenant IDs to request info from. (optional)</param>
	/// <param name="paging">Cursor-based paging options. (optional)</param>
	/// <param name="cancellationToken">cancellationToken parameter.</param>
	/// <returns>Task of InterfaceStatisticsRead</returns>
	[Get("/v1/stat/interface/{statId}")]
	Task<InterfaceStatisticsRead> ReadInterfaceStatistics(
		[AliasAs("statId")] string statId,
		[Query] StatisticsTimeRange timeRange,
		[AliasAs("filter[interfaceType]")] string filter_interfaceType = null,
		[AliasAs("filter[interfaceId]")] string filter_interfaceId = null,
		[AliasAs("filter[parentDevice]")] string filter_parentDevice = null,
		[AliasAs("tenants")] string tenants = null,
		[Query, Optional] PagingOptions paging,
		CancellationToken? cancellationToken = null
	);

	/// <summary>
	/// Read OID Statistics
	/// </summary>
	/// <remarks>
	/// Fetch the last recorded value of a monitored device OID.
	/// </remarks>
	/// <exception cref="System.Exception">Thrown when fails to make API call</exception>
	/// <param name="statId">ID of statistic to return</param>
	/// <param name="filter_deviceId">Filter by device ID (optional)</param>
	/// <param name="filter_deviceType">Filter by device type. (optional)</param>
	/// <param name="filter_oid">Filter by OID (optional)</param>
	/// <param name="tenants">Comma delimited list of tenant IDs to request info from. (optional)</param>
	/// <param name="paging">Cursor-based paging options. (optional)</param>
	/// <param name="cancellationToken">cancellationToken parameter.</param>
	/// <returns>Task of DeviceOidMonitorRead</returns>
	[Get("/v1/stat/oid/{statId}")]
	Task<DeviceOidMonitorRead> ReadOidStatistics(
		[AliasAs("statId")] string statId,
		[AliasAs("filter[deviceId]")] string filter_deviceId = null,
		[AliasAs("filter[deviceType]")] string filter_deviceType = null,
		[AliasAs("filter[oid]")] string filter_oid = null,
		[AliasAs("tenants")] string tenants = null,
		[Query, Optional] PagingOptions paging,
		CancellationToken? cancellationToken = null
	);

	/// <summary>
	/// Read Service Statistics
	/// </summary>
	/// <remarks>
	/// Fetch detailed statistics of a client's (and client's children if a multi-client) services for a given time range.
	/// </remarks>
	/// <exception cref="System.Exception">Thrown when fails to make API call</exception>
	/// <param name="statId">ID of statistic to return</param>
	/// <param name="timeRange">The time range and reporting interval to query.</param>
	/// <param name="filter_serviceId">Filter by service ID (optional)</param>
	/// <param name="tenants">Comma delimited list of tenant IDs to request info from. (optional)</param>
	/// <param name="paging">Cursor-based paging options. (optional)</param>
	/// <param name="userAgent">userAgent parameter.</param>
	/// <param name="cancellationToken">cancellationToken parameter.</param>
	/// <returns>Task of ServiceStatisticsRead</returns>
	[Get("/v1/stat/service/{statId}")]
	Task<ServiceStatisticsRead> ReadServiceStatistics(
		[Header("UserAgent")] string userAgent,
		[AliasAs("statId")] string statId,
		[Query] StatisticsTimeRange timeRange,
		[AliasAs("filter[serviceId]")] string filter_serviceId = null,
		[AliasAs("tenants")] string tenants = null,
		[Query, Optional] PagingOptions paging,
		CancellationToken? cancellationToken = null
	);
}
