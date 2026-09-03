#nullable disable

using System.IO;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// This device's attributes
/// </summary>
[DataContract]
public class NetworkRelationshipsDevicesAttributes
{
	/// <summary>
	/// Device's name
	/// </summary>
	/// <value>Device's name</value>
	[DataMember(Name="deviceName", EmitDefaultValue=false)]
	[JsonPropertyName("deviceName")]
	public string DeviceName { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
