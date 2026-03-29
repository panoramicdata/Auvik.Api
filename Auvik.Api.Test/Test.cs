using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System.Diagnostics;
using Xunit;

namespace Auvik.Api.Test;

public abstract class Test
{
   protected Test()
	{
     Logger = NullLogger.Instance;
		Config = new TestConfig(null, Logger);
		AuvikClient = Config.AuvikClient;
		Stopwatch = Stopwatch.StartNew();
	}
	protected ILogger Logger { get; }

	internal TestConfig Config { get; }

	private Stopwatch Stopwatch { get; }

	protected AuvikClient AuvikClient { get; }

	protected void AssertIsFast(int durationSeconds)
		=> Assert.InRange(Stopwatch.ElapsedMilliseconds, 0, durationSeconds * 1000);
}
