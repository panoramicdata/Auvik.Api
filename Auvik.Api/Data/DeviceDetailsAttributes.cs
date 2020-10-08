using System.IO;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Auvik.Api.Data
{
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
		[JsonConverter(typeof(StringEnumConverter))]
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
		public TrafficInsightsStatusEnum? TrafficInsightsStatus { get; set; }

		/// <summary>
		/// Gets or Sets DiscoveryStatus
		/// </summary>
		[DataMember(Name="discoveryStatus", EmitDefaultValue=false)]
		public DeviceDetailsAttributesDiscoveryStatus DiscoveryStatus { get; set; }

		/// <summary>
		/// Whether this device is managed by Auvik or not
		/// </summary>
		/// <value>Whether this device is managed by Auvik or not</value>
		[DataMember(Name="manageStatus", EmitDefaultValue=false)]
		public bool? ManageStatus { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceDetailsAttributes {\n");
			sb.Append("  DiscoveryStatus: ").Append(DiscoveryStatus).Append("\n");
			sb.Append("  ManageStatus: ").Append(ManageStatus).Append("\n");
			sb.Append("  TrafficInsightsStatus: ").Append(TrafficInsightsStatus).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
