#nullable disable

using System.IO;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// The type-specific properties of the interfaces object returned
/// </summary>
[DataContract]
public class DeviceDetailsRelationshipsInterfacesAttributes
{
	/// <summary>
	/// This interface's name
	/// </summary>
	/// <value>This interface's name</value>
	[DataMember(Name="interfaceName", EmitDefaultValue=false)]
	[JsonPropertyName("interfaceName")]
	public string InterfaceName { get; set; }

	/// <summary>
	/// The MAC address of this interface
	/// </summary>
	/// <value>The MAC address of this interface</value>
	[DataMember(Name="macAddress", EmitDefaultValue=false)]
	[JsonPropertyName("macAddress")]
	public string MacAddress { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
