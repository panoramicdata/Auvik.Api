using Auvik.Api.Exceptions;
using FluentAssertions;
using System;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Auvik.Api.Test
{
	public class ConfigurationTests : Test
	{
		public ConfigurationTests(ITestOutputHelper iTestOutputHelper)
			: base(iTestOutputHelper)
		{
		}

		[Fact]
		public void NoUri_ThrowsException()
		{
			Func<Task> act = async () =>
			{
				await new AuvikClient(new AuvikClientOptions
				{
					Username = "ABC",
					ApiKey = "123"
				})
				.Credentials
				.VerifyCredentials()
				.ConfigureAwait(false);
			};

			act
				.Should()
				.Throw<ConfigurationException>()
				.WithMessage("Missing Uri");
		}

		[Fact]
		public void NoUsername_ThrowsException()
		{
			Func<Task> act = async () =>
			{
				await new AuvikClient(new AuvikClientOptions
				{
					Uri = new Uri("https://auvikapi.us1.my.auvik.com"),
					ApiKey = "ABC"
				})
				.Credentials
				.VerifyCredentials()
				.ConfigureAwait(false);
			};

			act
				.Should()
				.Throw<ConfigurationException>()
				.WithMessage("Missing Username");
		}

		[Fact]
		public void NoApiKey_ThrowsException()
		{
			Func<Task> act = async () =>
			{
				await new AuvikClient(new AuvikClientOptions
				{
					Uri = new Uri("https://auvikapi.us1.my.auvik.com"),
					Username = "ABC"
				})
				.Credentials
				.VerifyCredentials()
				.ConfigureAwait(false);
			};

			act
				.Should()
				.Throw<ConfigurationException>()
				.WithMessage("Missing ApiKey");
		}


		[Fact]
		public async void GoodConfig_Works()
			=> await AuvikClient
				.Credentials
				.VerifyCredentials()
				.ConfigureAwait(false);
	}
}