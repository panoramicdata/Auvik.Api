using System.IO;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The type-specific properties of the component object returned
	/// </summary>
	[DataContract]
	public class DeviceDetailsRelationshipsComponentsAttributes
	{
		/// <summary>
		/// This component's type
		/// </summary>
		/// <value>This component's type</value>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum ComponentTypeEnum
		{

			/// <summary>
			/// Enum Cpu for "cpu"
			/// </summary>
			[EnumMember(Value = "cpu")]
			Cpu,

			/// <summary>
			/// Enum Disk for "disk"
			/// </summary>
			[EnumMember(Value = "disk")]
			Disk,

			/// <summary>
			/// Enum Fan for "fan"
			/// </summary>
			[EnumMember(Value = "fan")]
			Fan,

			/// <summary>
			/// Enum Memory for "memory"
			/// </summary>
			[EnumMember(Value = "memory")]
			Memory,

			/// <summary>
			/// Enum PowerSupply for "powerSupply"
			/// </summary>
			[EnumMember(Value = "powerSupply")]
			PowerSupply,

			/// <summary>
			/// Enum StorageController for "storageController"
			/// </summary>
			[EnumMember(Value = "storageController")]
			StorageController,

			/// <summary>
			/// Enum SystemBoard for "systemBoard"
			/// </summary>
			[EnumMember(Value = "systemBoard")]
			SystemBoard
		}

		/// <summary>
		/// This component's type
		/// </summary>
		/// <value>This component's type</value>
		[DataMember(Name="componentType", EmitDefaultValue=false)]
		public ComponentTypeEnum? ComponentType { get; set; }

		/// <summary>
		/// This component's name
		/// </summary>
		/// <value>This component's name</value>
		[DataMember(Name="componentName", EmitDefaultValue=false)]
		public string ComponentName { get; set; }

		/// <summary>
		/// Gets or Sets ConfigurationId
		/// </summary>
		[DataMember(Name="configurationId", EmitDefaultValue=false)]
		public string ConfigurationId { get; set; }

		/// <summary>
		/// Gets or Sets ConfigurationIndex
		/// </summary>
		[DataMember(Name="configurationIndex", EmitDefaultValue=false)]
		public string ConfigurationIndex { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceDetailsRelationshipsComponentsAttributes {\n");
			sb.Append("  ComponentName: ").Append(ComponentName).Append("\n");
			sb.Append("  ComponentType: ").Append(ComponentType).Append("\n");
			sb.Append("  ConfigurationId: ").Append(ConfigurationId).Append("\n");
			sb.Append("  ConfigurationIndex: ").Append(ConfigurationIndex).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
