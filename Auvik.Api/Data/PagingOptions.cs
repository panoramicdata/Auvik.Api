#nullable disable

using Refit;

namespace Auvik.Api.Data;

/// <summary>
/// Cursor-based paging options
/// </summary>
public class PagingOptions
{
	/// <summary>The first N elements to return; used with <c>After</c>. (optional, default to 100)</summary>
	[AliasAs("page[first]")]
	public decimal? First { get; set; }

	/// <summary>Cursor after which elements will be returned. (optional)</summary>
	[AliasAs("page[after]")]
	public string After { get; set; }

	/// <summary>The last N elements to return; used with <c>Before</c>. (optional, default to 100)</summary>
	[AliasAs("page[last]")]
	public decimal? Last { get; set; }

	/// <summary>Cursor before which elements will be returned. (optional)</summary>
	[AliasAs("page[before]")]
	public string Before { get; set; }
}
