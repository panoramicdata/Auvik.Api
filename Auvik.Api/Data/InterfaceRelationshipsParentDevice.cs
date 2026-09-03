#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// This interface's parent device
/// </summary>
[DataContract]
public class InterfaceRelationshipsParentDevice
{
	/// <summary>
	/// Gets or Sets Data
	/// </summary>
	[DataMember(Name="data", EmitDefaultValue=false)]
	[JsonPropertyName("data")]
	public InterfaceRelationshipsParentDeviceData Data { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
