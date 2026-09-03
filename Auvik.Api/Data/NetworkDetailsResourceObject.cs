#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// The template for a resource object representing an Auvik network's extra details
/// </summary>
[DataContract]
public class NetworkDetailsResourceObject
{
	/// <summary>
	/// The type of object in the API
	/// </summary>
	/// <value>The type of object in the API</value>
	[JsonConverter(typeof(EnumMemberJsonConverter))]
	public enum TypeEnum
	{

		/// <summary>
		/// Enum NetworkDetail for "networkDetail"
		/// </summary>
		[EnumMember(Value = "networkDetail")]
		NetworkDetail
	}

	/// <summary>
	/// The type of object in the API
	/// </summary>
	/// <value>The type of object in the API</value>
	[DataMember(Name="type", EmitDefaultValue=false)]
	[JsonPropertyName("type")]
	public TypeEnum? Type { get; set; }

	/// <summary>
	/// Gets or Sets Attributes
	/// </summary>
	[DataMember(Name="attributes", EmitDefaultValue=false)]
	[JsonPropertyName("attributes")]
	public NetworkDetailsAttributes Attributes { get; set; }

	/// <summary>
	/// The unique identifier for a network
	/// </summary>
	/// <value>The unique identifier for a network</value>
	[DataMember(Name="id", EmitDefaultValue=false)]
	[JsonPropertyName("id")]
	public string Id { get; set; }

	/// <summary>
	/// Gets or Sets Links
	/// </summary>
	[DataMember(Name="links", EmitDefaultValue=false)]
	[JsonPropertyName("links")]
	public NetworkDetailsResourceObjectLinks Links { get; set; }

	/// <summary>
	/// Gets or Sets Relationships
	/// </summary>
	[DataMember(Name="relationships", EmitDefaultValue=false)]
	[JsonPropertyName("relationships")]
	public NetworkDetailsRelationships Relationships { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
