#nullable disable

using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// List of other devices connected to this device
/// </summary>
[DataContract]
public class DeviceDetailsRelationshipsConnectedDevices
{
	/// <summary>
	/// A connected device resource object
	/// </summary>
	/// <value>A connected device resource object</value>
	[DataMember(Name="data", EmitDefaultValue=false)]
	[JsonPropertyName("data")]
	public List<DeviceDetailsRelationshipsConnectedDevicesData> Data { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
