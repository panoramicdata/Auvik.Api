using Auvik.Api.Exceptions;
using FluentAssertions;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Auvik.Api.Test;

/// <summary>
/// Tests validation behavior for <see cref="AuvikClientOptions"/>.
/// </summary>
public class ConfigurationTests : Test
{
	/// <summary>
	/// Verifies client creation fails when URI is missing.
	/// </summary>
	[Fact]
  public async Task NoUri_ThrowsException()
	{
		Func<Task> act = async () =>
		{
			await new AuvikClient(new AuvikClientOptions
			{
				Username = "ABC",
				ApiKey = "123"
			})
			.Credentials
            .VerifyCredentials();
		};

      await act
			.Should()
           .ThrowAsync<ConfigurationException>()
			.WithMessage("Missing Uri");
	}

	/// <summary>
	/// Verifies client creation fails when username is missing.
	/// </summary>
	[Fact]
  public async Task NoUsername_ThrowsException()
	{
		Func<Task> act = async () =>
		{
			await new AuvikClient(new AuvikClientOptions
			{
				Uri = new Uri("https://auvikapi.us1.my.auvik.com"),
				ApiKey = "ABC"
			})
			.Credentials
            .VerifyCredentials();
		};

      await act
			.Should()
           .ThrowAsync<ConfigurationException>()
			.WithMessage("Missing Username");
	}

	/// <summary>
	/// Verifies client creation fails when API key is missing.
	/// </summary>
	[Fact]
  public async Task NoApiKey_ThrowsException()
	{
		Func<Task> act = async () =>
		{
			await new AuvikClient(new AuvikClientOptions
			{
				Uri = new Uri("https://auvikapi.us1.my.auvik.com"),
				Username = "ABC"
			})
			.Credentials
            .VerifyCredentials();
		};

      await act
			.Should()
           .ThrowAsync<ConfigurationException>()
			.WithMessage("Missing ApiKey");
	}

	/// <summary>
	/// Verifies a valid configuration can call the credentials endpoint.
	/// </summary>
	[Fact]
	public async Task GoodConfig_Works()
		=> await AuvikClient
			.Credentials
           .VerifyCredentials();
}
