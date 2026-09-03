#nullable disable

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// root level object per the json-api spec
/// </summary>
[DataContract]
public class TenantsDetailReadMultiple
{
	/// <summary>
	/// An array of resource objects, an array of resource identifier objects, or an empty array ([]), for requests that target resource collections.
	/// </summary>
	/// <value>An array of resource objects, an array of resource identifier objects, or an empty array ([]), for requests that target resource collections.</value>
	[DataMember(Name="data", EmitDefaultValue=false)]
	[JsonPropertyName("data")]
	public List<TenantDetailResourceObject> Data { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
