using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Auvik.Api.Internal;

/// <summary>
/// Renders the diagnostic string presentation shared by the data objects.
/// </summary>
/// <remarks>
/// Every data object printed itself with the same hand-written StringBuilder block, which is the
/// single largest source of duplication in this library. The format produced here is byte for byte
/// the format those blocks produced.
/// </remarks>
internal static class ObjectDescription
{
	private static readonly ConcurrentDictionary<Type, PropertyInfo[]> PropertyCache = new();

	/// <summary>
	/// Returns the string presentation of <paramref name="instance"/>: its type name followed by
	/// each public property, one per line, in ordinal name order.
	/// </summary>
	/// <param name="instance">The object to describe.</param>
	public static string Describe(object instance)
	{
		ArgumentNullException.ThrowIfNull(instance);

		var type = instance.GetType();
		var properties = PropertyCache.GetOrAdd(
			type,
			static t => [.. t.GetProperties(BindingFlags.Public | BindingFlags.Instance)
				.Where(p => p.GetIndexParameters().Length == 0)
				.OrderBy(p => p.Name, StringComparer.Ordinal)]);

		var stringBuilder = new StringBuilder();
		stringBuilder.Append("class ").Append(type.Name).Append(" {\n");
		foreach (var property in properties)
		{
			stringBuilder.Append("  ").Append(property.Name).Append(": ").Append(property.GetValue(instance)).Append('\n');
		}

		stringBuilder.Append("}\n");
		return stringBuilder.ToString();
	}
}
