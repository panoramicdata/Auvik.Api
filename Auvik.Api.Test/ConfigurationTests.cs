using Auvik.Api.Exceptions;
using FluentAssertions;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Auvik.Api.Test;

public class ConfigurationTests : Test
{
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

	[Fact]
	public async Task GoodConfig_Works()
		=> await AuvikClient
			.Credentials
           .VerifyCredentials();
}
