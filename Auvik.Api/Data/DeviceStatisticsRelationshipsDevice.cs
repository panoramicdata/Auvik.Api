#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// This device the statistics are reported against
/// </summary>
[DataContract]
public class DeviceStatisticsRelationshipsDevice
{
	/// <summary>
	/// Gets or Sets Data
	/// </summary>
	[DataMember(Name="data", EmitDefaultValue=false)]
	[JsonPropertyName("data")]
	public DeviceStatisticsRelationshipsDeviceData Data { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
