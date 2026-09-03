#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Serialization;

namespace Auvik.Api.Data;

/// <summary>
/// Device statistics resource object
/// </summary>
[DataContract]
public class DeviceStatisticsResourceObject : StatisticsResourceObject
{
	/// <summary>
	/// The type of this resource object
	/// </summary>
	/// <value>The type of this resource object</value>
	[JsonConverter(typeof(EnumMemberJsonConverter))]
	public enum TypeEnum
	{
		/// <summary>
		/// Enum DeviceStatistics for "deviceStatistics"
		/// </summary>
		[EnumMember(Value = "deviceStatistics")]
		DeviceStatistics
	}

	/// <summary>
	/// The type of this resource object
	/// </summary>
	/// <value>The type of this resource object</value>
	[DataMember(Name = "type", EmitDefaultValue = false)]
	[JsonPropertyName("type")]
	public TypeEnum? Type { get; set; }
}
