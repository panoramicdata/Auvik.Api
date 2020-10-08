using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Auvik.Api.Data
{
	/// <summary>
	/// A device resource object
	/// </summary>
	[DataContract]
	public class OidRelationshipsDeviceData
	{
		/// <summary>
		/// The type of the object
		/// </summary>
		/// <value>The type of the object</value>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum TypeEnum
		{

			/// <summary>
			/// Enum Device for "device"
			/// </summary>
			[EnumMember(Value = "device")]
			Device
		}

		/// <summary>
		/// The type of the object
		/// </summary>
		/// <value>The type of the object</value>
		[DataMember(Name="type", EmitDefaultValue=false)]
		public TypeEnum? Type { get; set; }

		/// <summary>
		/// The name of the device
		/// </summary>
		/// <value>The name of the device</value>
		[DataMember(Name="deviceName", EmitDefaultValue=false)]
		public string DeviceName { get; set; }

		/// <summary>
		/// The type of the device
		/// </summary>
		/// <value>The type of the device</value>
		[DataMember(Name="deviceType", EmitDefaultValue=false)]
		public string DeviceType { get; set; }

		/// <summary>
		/// This device's ID
		/// </summary>
		/// <value>This device's ID</value>
		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		/// <summary>
		/// Gets or Sets Links
		/// </summary>
		[DataMember(Name="links", EmitDefaultValue=false)]
		public InterfaceRelationshipsParentDeviceDataLinks Links { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class OidRelationshipsDeviceData {\n");
			sb.Append("  DeviceName: ").Append(DeviceName).Append("\n");
			sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Links: ").Append(Links).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
