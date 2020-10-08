using System.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Net.Http;
using Auvik.Api.Exceptions;

namespace Auvik.Api
{
	/// <summary>
	/// An Auvik Client Options
	/// </summary>
	public class AuvikClientOptions
	{
		/// <summary>
		/// An optional HttpClient to use
		/// </summary>
		public HttpClient HttpClient { get; set; }

		/// <summary>
		/// The Uri - this must be provided.
		/// </summary>
		public Uri Uri { get; set; } = null!;

		/// <summary>
		/// The username
		/// </summary>
		public string Username { get; set; }

		/// <summary>
		/// The API key
		/// </summary>
		public string ApiKey { get; set; }

		/// <summary>
		/// The Logger
		/// </summary>
		public ILogger Logger { get; set; } = NullLogger.Instance;

		/// <summary>
		/// Throws an exception if this object is invalid.
		/// </summary>
		internal void Validate()
		{
			if (Uri is null)
			{
				throw new ConfigurationException($"Missing {nameof(Uri)}");
			}

			if (string.IsNullOrWhiteSpace(Username))
			{
				throw new ConfigurationException($"Missing {nameof(Username)}");
			}

			if (string.IsNullOrWhiteSpace(ApiKey))
			{
				throw new ConfigurationException($"Missing {nameof(ApiKey)}");
			}
		}
	}
}