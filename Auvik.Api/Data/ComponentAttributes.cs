#nullable disable

using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using Auvik.Api.Serialization;

namespace Auvik.Api.Data;

/// <summary>
/// The type-specific properties of the components object returned
/// </summary>
[DataContract]
public class ComponentAttributes
{
	/// <summary>
	/// This component's type
	/// </summary>
	/// <value>This component's type</value>
	[JsonConverter(typeof(EnumMemberJsonConverter))]
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
	/// High level description of this component's status
	/// </summary>
	/// <value>High level description of this component's status</value>
	[JsonConverter(typeof(EnumMemberJsonConverter))]
	public enum CurrentStatusEnum
	{

		/// <summary>
		/// Enum Ok for "ok"
		/// </summary>
		[EnumMember(Value = "ok")]
		Ok,

		/// <summary>
		/// Enum Degraded for "degraded"
		/// </summary>
		[EnumMember(Value = "degraded")]
		Degraded,

		/// <summary>
		/// Enum Failed for "failed"
		/// </summary>
		[EnumMember(Value = "failed")]
		Failed
	}

	/// <summary>
	/// This component's type
	/// </summary>
	/// <value>This component's type</value>
	[DataMember(Name = "componentType", EmitDefaultValue = false)]
	[JsonPropertyName("componentType")]
	public ComponentTypeEnum? ComponentType { get; set; }

	/// <summary>
	/// High level description of this component's status
	/// </summary>
	/// <value>High level description of this component's status</value>
	[DataMember(Name = "currentStatus", EmitDefaultValue = false)]
	[JsonPropertyName("currentStatus")]
	public CurrentStatusEnum? CurrentStatus { get; set; }

	/// <summary>
	/// This component's name
	/// </summary>
	/// <value>This component's name</value>
	[DataMember(Name = "componentName", EmitDefaultValue = false)]
	[JsonPropertyName("componentName")]
	public string ComponentName { get; set; }

	/// <summary>
	/// When one of this component's attributes was last modified
	/// </summary>
	/// <value>When one of this component's attributes was last modified</value>
	[DataMember(Name = "lastModified", EmitDefaultValue = false)]
	[JsonPropertyName("lastModified")]
	public string LastModified { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class ComponentAttributes {\n");
		sb.Append("  ComponentName: ").Append(ComponentName).Append("\n");
		sb.Append("  ComponentType: ").Append(ComponentType).Append("\n");
		sb.Append("  CurrentStatus: ").Append(CurrentStatus).Append("\n");
		sb.Append("  LastModified: ").Append(LastModified).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}