using Auvik.Api.Interfaces;
using Auvik.Api.Serialization;
using Refit;
using System;
using System.Net.Http;

namespace Auvik.Api;

/// <summary>
/// API client is mainly responsible for making the HTTP call to the API backend.
/// </summary>
public class AuvikClient : IDisposable
{
	private bool disposedValue;
	private readonly bool _disposeHttpClient;
	private readonly HttpClient _httpClient;

	/// <summary>
	/// Constructor
	/// </summary>
	/// <param name="auvikClientOptions"></param>
	public AuvikClient(AuvikClientOptions auvikClientOptions)
	{
		if (auvikClientOptions == null)
		{
			throw new ArgumentNullException(nameof(auvikClientOptions));
		}
		auvikClientOptions.Validate();

		_disposeHttpClient = auvikClientOptions.HttpClient is null;
		_httpClient = auvikClientOptions.HttpClient ?? new HttpClient(new AuthenticatedHttpClientHandler(auvikClientOptions))
		{
			BaseAddress = auvikClientOptions.Uri
		};

		var refitSettings = new RefitSettings
		{
			ContentSerializer = new SystemTextJsonContentSerializer(AuvikJsonSerializerOptions.Default)
		};

		Alerts = RestService.For<IAlert>(_httpClient, refitSettings);
		AlertHistories = RestService.For<IAlertHistory>(_httpClient, refitSettings);
		Components = RestService.For<IComponent>(_httpClient, refitSettings);
		Configurations = RestService.For<IConfiguration>(_httpClient, refitSettings);
		Credentials = RestService.For<Interfaces.ICredentials>(_httpClient, refitSettings);
		Devices = RestService.For<IDevice>(_httpClient, refitSettings);
		Entities = RestService.For<IEntity>(_httpClient, refitSettings);
		Interfaces = RestService.For<IInterface>(_httpClient, refitSettings);
		Networks = RestService.For<INetworkApi>(_httpClient, refitSettings);
		Statistics = RestService.For<IStatistics>(_httpClient, refitSettings);
		Tenants = RestService.For<ITenants>(_httpClient, refitSettings);
		Usage = RestService.For<IUsage>(_httpClient, refitSettings);
	}

	/// <inheritdoc />
	public IAlert Alerts { get; }

	/// <inheritdoc />
	public IAlertHistory AlertHistories { get; }

	/// <inheritdoc />
	public IComponent Components { get; }

	/// <inheritdoc />
	public IConfiguration Configurations { get; }

	/// <inheritdoc />
	public Interfaces.ICredentials Credentials { get; }

	/// <inheritdoc />
	public IDevice Devices { get; }

	/// <inheritdoc />
	public IEntity Entities { get; }

	/// <inheritdoc />
	public IInterface Interfaces { get; }

	/// <inheritdoc />
	public INetworkApi Networks { get; }

	/// <inheritdoc />
	public IStatistics Statistics { get; }

	/// <inheritdoc />
	public ITenants Tenants { get; }

	/// <inheritdoc />
	public IUsage Usage { get; }

	/// <summary>
	/// Releases resources used by the client.
	/// </summary>
	/// <param name="disposing">True when called from <see cref="Dispose()"/>; false when called from a finalizer.</param>
	protected virtual void Dispose(bool disposing)
	{
		if (!disposedValue)
		{
			if (disposing)
			{
				if (_disposeHttpClient)
				{
					_httpClient?.Dispose();
				}
			}

			// TODO: free unmanaged resources (unmanaged objects) and override finalizer
			// TODO: set large fields to null
			disposedValue = true;
		}
	}

	/// <summary>
	/// Releases all resources used by this instance.
	/// </summary>
	public void Dispose()
	{
		// Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}
}
