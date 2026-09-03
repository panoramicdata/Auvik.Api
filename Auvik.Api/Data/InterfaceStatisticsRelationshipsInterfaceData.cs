#nullable disable

using System.Text;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Auvik.Api.Data;

/// <summary>
/// A interface resource object
/// </summary>
[DataContract]
public class InterfaceStatisticsRelationshipsInterfaceData
{
	/// <summary>
	/// This interface's ID
	/// </summary>
	/// <value>This interface's ID</value>
	[DataMember(Name="id", EmitDefaultValue=false)]
	[JsonPropertyName("id")]
	public string Id { get; set; }

	/// <summary>
	/// This interface's name
	/// </summary>
	/// <value>This interface's name</value>
	[DataMember(Name="interfaceName", EmitDefaultValue=false)]
	[JsonPropertyName("interfaceName")]
	public string InterfaceName { get; set; }

	/// <summary>
	/// This interface's type
	/// </summary>
	/// <value>This interface's type</value>
	[DataMember(Name="interfaceType", EmitDefaultValue=false)]
	[JsonPropertyName("interfaceType")]
	public string InterfaceType { get; set; }

	/// <summary>
	/// Gets or Sets Links
	/// </summary>
	[DataMember(Name="links", EmitDefaultValue=false)]
	[JsonPropertyName("links")]
	public InterfaceStatisticsRelationshipsInterfaceDataLinks Links { get; set; }

	/// <summary>
	/// This interface's parent device
	/// </summary>
	/// <value>This interface's parent device</value>
	[DataMember(Name="parentDevice", EmitDefaultValue=false)]
	[JsonPropertyName("parentDevice")]
	public string ParentDevice { get; set; }

	/// <summary>
	/// The type of the object
	/// </summary>
	/// <value>The type of the object</value>
	[DataMember(Name="type", EmitDefaultValue=false)]
	[JsonPropertyName("type")]
	public string Type { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class InterfaceStatisticsRelationshipsInterfaceData {\n");
		sb.Append("  Id: ").Append(Id).Append("\n");
		sb.Append("  InterfaceName: ").Append(InterfaceName).Append("\n");
		sb.Append("  InterfaceType: ").Append(InterfaceType).Append("\n");
		sb.Append("  Links: ").Append(Links).Append("\n");
		sb.Append("  ParentDevice: ").Append(ParentDevice).Append("\n");
		sb.Append("  Type: ").Append(Type).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
