#nullable disable

using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// Root level object per the json-api spec
/// </summary>
[DataContract]
public class DeviceDetailsExtendedReadSingle
{
	/// <summary>
	/// Gets or Sets Data
	/// </summary>
	[DataMember(Name = "data", EmitDefaultValue = false)]
	[JsonPropertyName("data")]
	public DeviceExtendedDetailResourceObject Data { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
