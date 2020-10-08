using Auvik.Api.Interfaces;
using Refit;
using System;
using System.Net.Http;

namespace Auvik.Api
{
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

			Alerts = RestService.For<IAlert>(_httpClient);
			AlertHistories = RestService.For<IAlertHistory>(_httpClient);
			Components = RestService.For<IComponent>(_httpClient);
			Configurations = RestService.For<IConfiguration>(_httpClient);
			Credentials = RestService.For<ICredentials>(_httpClient);
			Devices = RestService.For<IDevice>(_httpClient);
			Entities = RestService.For<IEntity>(_httpClient);
			Interfaces = RestService.For<IInterface>(_httpClient);
			Networks = RestService.For<INetworkApi>(_httpClient);
			Statistics = RestService.For<IStatistics>(_httpClient);
			Tenants = RestService.For<ITenants>(_httpClient);
			Usage = RestService.For<IUsage>(_httpClient);
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
		public ICredentials Credentials { get; }

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

		public void Dispose()
		{
			// Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}
	}
}
