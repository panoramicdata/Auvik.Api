#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// InterfaceRelationshipsNetworksData
/// </summary>
[DataContract]
public class InterfaceRelationshipsNetworksData
{
	/// <summary>
	/// The type of the object
	/// </summary>
	/// <value>The type of the object</value>
	[JsonConverter(typeof(EnumMemberJsonConverter))]
	public enum TypeEnum
	{

		/// <summary>
		/// Enum Network for "network"
		/// </summary>
		[EnumMember(Value = "network")]
		Network
	}

	/// <summary>
	/// The type of the object
	/// </summary>
	/// <value>The type of the object</value>
	[DataMember(Name="type", EmitDefaultValue=false)]
	[JsonPropertyName("type")]
	public TypeEnum? Type { get; set; }

	/// <summary>
	/// Gets or Sets Attributes
	/// </summary>
	[DataMember(Name="attributes", EmitDefaultValue=false)]
	[JsonPropertyName("attributes")]
	public DeviceRelationshipsNetworksAttributes Attributes { get; set; }

	/// <summary>
	/// The unique identifier for this network
	/// </summary>
	/// <value>The unique identifier for this network</value>
	[DataMember(Name="id", EmitDefaultValue=false)]
	[JsonPropertyName("id")]
	public string Id { get; set; }

	/// <summary>
	/// Gets or Sets Links
	/// </summary>
	[DataMember(Name="links", EmitDefaultValue=false)]
	[JsonPropertyName("links")]
	public InterfaceRelationshipsNetworksLinks Links { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
