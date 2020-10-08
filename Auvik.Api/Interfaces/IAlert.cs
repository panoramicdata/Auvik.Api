using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Auvik.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IAlert
	{
		/// <summary>
		/// Dismiss an alert
		/// </summary>
		/// <remarks>
		/// Use the Dismiss Alert API to dismiss a specific alert that Auvik has triggered
		/// </remarks>
		/// <param name="id">ID of alert</param>
		/// <returns>Task of void</returns>
		[Post("/alert/dismiss/{id}")]
		public Task AlertDismissSingle(
			[AliasAs("id")] string id,
			CancellationToken cancellationToken);
	}
}
