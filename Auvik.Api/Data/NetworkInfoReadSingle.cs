#nullable disable

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// Root level object per the json-api spec
/// </summary>
[DataContract]
public class NetworkInfoReadSingle
{
	/// <summary>
	/// Gets or Sets Data
	/// </summary>
	[DataMember(Name="data", EmitDefaultValue=false)]
	[JsonPropertyName("data")]
	public NetworksResourceObject Data { get; set; }

	/// <summary>
	/// Gets or Sets Included
	/// </summary>
	[DataMember(Name="included", EmitDefaultValue=false)]
	[JsonPropertyName("included")]
	public List<NetworkDetailsResourceObject> Included { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
