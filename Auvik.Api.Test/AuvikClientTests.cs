using Auvik.Api;
using Auvik.Api.Exceptions;
using AwesomeAssertions;
using System;
using System.Net.Http;
using Xunit;

namespace Auvik.Api.Test;

/// <summary>
/// Tests construction and disposal of <see cref="AuvikClient"/>. None of these tests touch the network.
/// </summary>
public class AuvikClientTests
{
	/// <summary>
	/// Builds options that pass validation, optionally with a caller-supplied HttpClient.
	/// </summary>
	private static AuvikClientOptions ValidOptions(HttpClient? httpClient = null) => new()
	{
		Uri = new Uri("https://auvikapi.us1.my.auvik.com"),
		Username = "u",
		ApiKey = "k",
		HttpClient = httpClient,
	};

	/// <summary>
	/// A null options argument is rejected before anything else happens.
	/// </summary>
	[Fact]
	public void Constructor_NullOptions_Throws()
	{
		Func<AuvikClient> act = () => new AuvikClient(null!);

		act.Should().Throw<ArgumentNullException>().WithParameterName("auvikClientOptions");
	}

	/// <summary>
	/// Each of the three required options being missing yields a ConfigurationException.
	/// </summary>
	[Theory]
	[InlineData(null, "u", "k")]
	[InlineData("https://x.example", null, "k")]
	[InlineData("https://x.example", "u", null)]
	public void Constructor_MissingRequiredOption_Throws(string? uri, string? username, string? apiKey)
	{
		var options = new AuvikClientOptions
		{
			Uri = uri is null ? null! : new Uri(uri),
			Username = username!,
			ApiKey = apiKey!,
		};

		Func<AuvikClient> act = () => new AuvikClient(options);

		act.Should().Throw<ConfigurationException>();
	}

	/// <summary>
	/// Valid options produce a client whose resources are all created.
	/// </summary>
	[Fact]
	public void Constructor_ValidOptions_InitialisesAllResources()
	{
		using var client = new AuvikClient(ValidOptions(new HttpClient()));

		client.Alerts.Should().NotBeNull();
		client.AlertHistories.Should().NotBeNull();
		client.Components.Should().NotBeNull();
		client.Configurations.Should().NotBeNull();
		client.Credentials.Should().NotBeNull();
		client.Devices.Should().NotBeNull();
		client.Entities.Should().NotBeNull();
		client.Interfaces.Should().NotBeNull();
		client.Networks.Should().NotBeNull();
		client.Statistics.Should().NotBeNull();
		client.Tenants.Should().NotBeNull();
		client.Usage.Should().NotBeNull();
	}

	/// <summary>
	/// Disposal is idempotent whether the handler owns the HttpClient or not.
	/// </summary>
	[Fact]
	public void Dispose_Twice_DoesNotThrow()
	{
		var client = new AuvikClient(ValidOptions());
		client.Dispose();
		client.Dispose();
	}
}
