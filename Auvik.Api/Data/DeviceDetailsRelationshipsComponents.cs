#nullable disable

using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// The components of a device
/// </summary>
[DataContract]
public class DeviceDetailsRelationshipsComponents
{
	/// <summary>
	/// A component resource object
	/// </summary>
	/// <value>A component resource object</value>
	[DataMember(Name="data", EmitDefaultValue=false)]
	[JsonPropertyName("data")]
	public List<DeviceDetailsRelationshipsComponentsData> Data { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
