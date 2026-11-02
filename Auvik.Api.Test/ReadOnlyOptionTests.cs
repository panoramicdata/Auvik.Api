using AwesomeAssertions;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Auvik.Api.Test;

/// <summary>
/// Pure unit tests: a refused write throws before any request is sent, so no credentials or tenant are needed.
/// </summary>
public class ReadOnlyOptionTests
{
	private static AuvikClient NewClient(bool isReadOnly) => new(new AuvikClientOptions
	{
		Uri = new Uri("https://auvikapi.invalid"),
		Username = "fake-user",
		ApiKey = "fake-key",
		IsReadOnly = isReadOnly
	});

	/// <summary>
	/// The option defaults to false so existing callers are unaffected.
	/// </summary>
	[Fact]
	public void IsReadOnly_DefaultsToFalse()
		=> new AuvikClientOptions().IsReadOnly.Should().BeFalse();

	/// <summary>
	/// The only write the API exposes is refused before it is sent.
	/// </summary>
	[Fact]
	public async Task AlertDismissIsRefused_WhenIsReadOnly()
	{
		using var client = NewClient(true);

		var act = () => client.Alerts.AlertDismissSingle("1", TestContext.Current.CancellationToken);

		await act.Should().ThrowAsync<InvalidOperationException>();
	}
}
