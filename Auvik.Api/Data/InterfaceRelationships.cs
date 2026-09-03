#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// This interface's relationships to other resources
/// </summary>
[DataContract]
public class InterfaceRelationships
{
	/// <summary>
	/// Gets or Sets ConnectedTo
	/// </summary>
	[DataMember(Name="connectedTo", EmitDefaultValue=false)]
	[JsonPropertyName("connectedTo")]
	public InterfaceRelationshipsConnectedTo ConnectedTo { get; set; }

	/// <summary>
	/// Gets or Sets Networks
	/// </summary>
	[DataMember(Name="networks", EmitDefaultValue=false)]
	[JsonPropertyName("networks")]
	public InterfaceRelationshipsNetworks Networks { get; set; }

	/// <summary>
	/// Gets or Sets ParentDevice
	/// </summary>
	[DataMember(Name="parentDevice", EmitDefaultValue=false)]
	[JsonPropertyName("parentDevice")]
	public InterfaceRelationshipsParentDevice ParentDevice { get; set; }

	/// <summary>
	/// Gets or Sets Tenant
	/// </summary>
	[DataMember(Name="tenant", EmitDefaultValue=false)]
	[JsonPropertyName("tenant")]
	public Tenant Tenant { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
