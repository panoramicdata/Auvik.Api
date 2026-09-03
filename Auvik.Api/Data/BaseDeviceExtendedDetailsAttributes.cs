#nullable disable

using System.IO;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// The type-specific properties of the devices object returned
/// </summary>
[DataContract]
public class BaseDeviceExtendedDetailsAttributes
{
	/// <summary>
	/// Device's name
	/// </summary>
	/// <value>Device's name</value>
	[DataMember(Name = "deviceName", EmitDefaultValue = false)]
	[JsonPropertyName("deviceName")]
	public string DeviceName { get; set; }

	/// <summary>
	/// When one of this device's attributes was last modified
	/// </summary>
	/// <value>When one of this device's attributes was last modified</value>
	[DataMember(Name = "lastModified", EmitDefaultValue = false)]
	[JsonPropertyName("lastModified")]
	public string LastModified { get; set; }

	/// <summary>
	/// Last seen online date/time of a device
	/// </summary>
	/// <value>Last seen online date/time of a device</value>
	[DataMember(Name = "lastSeenTime", EmitDefaultValue = false)]
	[JsonPropertyName("lastSeenTime")]
	public string LastSeenTime { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}