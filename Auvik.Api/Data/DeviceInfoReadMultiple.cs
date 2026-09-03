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
public class DeviceInfoReadMultiple
{
	/// <summary>
	/// Gets or Sets Data
	/// </summary>
	[DataMember(Name="data", EmitDefaultValue=false)]
	[JsonPropertyName("data")]
	public List<DevicesResourceObject> Data { get; set; }

	/// <summary>
	/// Gets or Sets Included
	/// </summary>
	[DataMember(Name="included", EmitDefaultValue=false)]
	[JsonPropertyName("included")]
	public List<DeviceDetailsResourceObject> Included { get; set; }

	/// <summary>
	/// Gets or Sets Links
	/// </summary>
	[DataMember(Name="links", EmitDefaultValue=false)]
	[JsonPropertyName("links")]
	public DeviceInfoReadMultipleLinks Links { get; set; }

	/// <summary>
	/// Gets or Sets Meta
	/// </summary>
	[DataMember(Name="meta", EmitDefaultValue=false)]
	[JsonPropertyName("meta")]
	public Meta Meta { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
