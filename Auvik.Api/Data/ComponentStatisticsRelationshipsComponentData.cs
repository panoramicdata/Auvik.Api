#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// A component resource object
/// </summary>
[DataContract]
public class ComponentStatisticsRelationshipsComponentData
{
	/// <summary>
	/// This component's name
	/// </summary>
	/// <value>This component's name</value>
	[DataMember(Name = "componentName", EmitDefaultValue = false)]
	[JsonPropertyName("componentName")]
	public string ComponentName { get; set; }

	/// <summary>
	/// This component's type
	/// </summary>
	/// <value>This component's type</value>
	[DataMember(Name = "componentType", EmitDefaultValue = false)]
	[JsonPropertyName("componentType")]
	public string ComponentType { get; set; }

	/// <summary>
	/// This component's ID
	/// </summary>
	/// <value>This component's ID</value>
	[DataMember(Name = "id", EmitDefaultValue = false)]
	[JsonPropertyName("id")]
	public string Id { get; set; }

	/// <summary>
	/// Gets or Sets Links
	/// </summary>
	[DataMember(Name = "links", EmitDefaultValue = false)]
	[JsonPropertyName("links")]
	public ComponentStatisticsRelationshipsComponentDataLinks Links { get; set; }

	/// <summary>
	/// This component's parent device
	/// </summary>
	/// <value>This component's parent device</value>
	[DataMember(Name = "parentDevice", EmitDefaultValue = false)]
	[JsonPropertyName("parentDevice")]
	public string ParentDevice { get; set; }

	/// <summary>
	/// The type of the object
	/// </summary>
	/// <value>The type of the object</value>
	[DataMember(Name = "type", EmitDefaultValue = false)]
	[JsonPropertyName("type")]
	public string Type { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}