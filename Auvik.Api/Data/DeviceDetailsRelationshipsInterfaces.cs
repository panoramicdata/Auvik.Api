#nullable disable

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// This device's interfaces
/// </summary>
[DataContract]
public class DeviceDetailsRelationshipsInterfaces
{
	/// <summary>
	/// An interface resource object
	/// </summary>
	/// <value>An interface resource object</value>
	[DataMember(Name="data", EmitDefaultValue=false)]
	[JsonPropertyName("data")]
	public List<DeviceDetailsRelationshipsInterfacesData> Data { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
