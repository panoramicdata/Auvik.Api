using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System.Diagnostics;
using Xunit;

namespace Auvik.Api.Test;

/// <summary>
/// Shared test base that initializes logger, configuration, and API client.
/// </summary>
public abstract class Test
{
	/// <summary>
	/// Initializes a new test context.
	/// </summary>
   protected Test()
	{
     Logger = NullLogger.Instance;
		Config = new TestConfig(null, Logger);
		AuvikClient = Config.AuvikClient;
		Stopwatch = Stopwatch.StartNew();
	}
	/// <summary>
	/// Gets the logger instance used by tests.
	/// </summary>
	protected ILogger Logger { get; }

	internal TestConfig Config { get; }

	private Stopwatch Stopwatch { get; }

	/// <summary>
	/// Gets the configured API client used by tests.
	/// </summary>
	protected AuvikClient AuvikClient { get; }

	/// <summary>
	/// Asserts the test completed within the expected duration.
	/// </summary>
	/// <param name="durationSeconds">Maximum allowed duration in seconds.</param>
	protected void AssertIsFast(int durationSeconds)
		=> Assert.InRange(Stopwatch.ElapsedMilliseconds, 0, durationSeconds * 1000);
}
