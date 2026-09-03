#nullable disable

using System.IO;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// The type-specific properties of the devices object returned
/// </summary>
[DataContract]
public class DeviceDetailsAttributes
{
	/// <summary>
	/// The status of TrafficInsights on this device
	/// </summary>
	/// <value>The status of TrafficInsights on this device</value>
	[JsonConverter(typeof(EnumMemberJsonConverter))]
	public enum TrafficInsightsStatusEnum
	{

		/// <summary>
		/// Enum NotDetected for "notDetected"
		/// </summary>
		[EnumMember(Value = "notDetected")]
		NotDetected,

		/// <summary>
		/// Enum Detected for "detected"
		/// </summary>
		[EnumMember(Value = "detected")]
		Detected,

		/// <summary>
		/// Enum NotApproved for "notApproved"
		/// </summary>
		[EnumMember(Value = "notApproved")]
		NotApproved,

		/// <summary>
		/// Enum Approved for "approved"
		/// </summary>
		[EnumMember(Value = "approved")]
		Approved,

		/// <summary>
		/// Enum Linking for "linking"
		/// </summary>
		[EnumMember(Value = "linking")]
		Linking,

		/// <summary>
		/// Enum LinkingFailed for "linkingFailed"
		/// </summary>
		[EnumMember(Value = "linkingFailed")]
		LinkingFailed,

		/// <summary>
		/// Enum Forwarding for "forwarding"
		/// </summary>
		[EnumMember(Value = "forwarding")]
		Forwarding
	}

	/// <summary>
	/// The status of TrafficInsights on this device
	/// </summary>
	/// <value>The status of TrafficInsights on this device</value>
	[DataMember(Name="trafficInsightsStatus", EmitDefaultValue=false)]
	[JsonPropertyName("trafficInsightsStatus")]
	public TrafficInsightsStatusEnum? TrafficInsightsStatus { get; set; }

	/// <summary>
	/// Gets or Sets DiscoveryStatus
	/// </summary>
	[DataMember(Name="discoveryStatus", EmitDefaultValue=false)]
	[JsonPropertyName("discoveryStatus")]
	public DeviceDetailsAttributesDiscoveryStatus DiscoveryStatus { get; set; }

	/// <summary>
	/// Whether this device is managed by Auvik or not
	/// </summary>
	/// <value>Whether this device is managed by Auvik or not</value>
	[DataMember(Name="manageStatus", EmitDefaultValue=false)]
	[JsonPropertyName("manageStatus")]
	public bool? ManageStatus { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
