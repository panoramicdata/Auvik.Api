using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace Auvik.Api.Test
{
	internal class TestConfig
	{
		internal TestConfig(
			  string credentialsName, ILogger logger)
		{
			var builder = new ConfigurationBuilder()
				  .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../.."))
				  .AddJsonFile("appsettings.json");

			var configuration = builder.Build();

			var defaultCredentialsName = configuration["DefaultCredentials"];
			credentialsName = $"{credentialsName ?? defaultCredentialsName}";
			var credentialsAppSetting = configuration[$"Credentials:{credentialsName}"];

			if (credentialsAppSetting == null)
			{
				throw new Exception($"No credentials found in appsettings.json file for {credentialsName}.");
			}

			var credentials = credentialsAppSetting.Split(';');
			if (credentials.Length != 3)
			{
				throw new Exception($"Expected to find credentials in the form URI;Username;ApiKey.  Found '{credentialsAppSetting}'");
			}

			var credentialIndex = -1;
			AuvikClient = new AuvikClient(new AuvikClientOptions
			{
				Uri = new Uri(credentials[++credentialIndex]),
				Username = credentials[++credentialIndex],
				ApiKey = credentials[++credentialIndex],
				Logger = logger
			});

			TestCustomerId = configuration["TestCustomerId"];
		}

		internal AuvikClient AuvikClient { get; }
		public string TestCustomerId { get; }
	}
}