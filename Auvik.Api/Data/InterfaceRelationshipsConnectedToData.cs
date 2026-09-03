#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// InterfaceRelationshipsConnectedToData
/// </summary>
[DataContract]
public class InterfaceRelationshipsConnectedToData
{
	/// <summary>
	/// The type of the object
	/// </summary>
	/// <value>The type of the object</value>
	[JsonConverter(typeof(EnumMemberJsonConverter))]
	public enum TypeEnum
	{

		/// <summary>
		/// Enum Interface for "interface"
		/// </summary>
		[EnumMember(Value = "interface")]
		Interface
	}

	/// <summary>
	/// The type of the object
	/// </summary>
	/// <value>The type of the object</value>
	[DataMember(Name="type", EmitDefaultValue=false)]
	[JsonPropertyName("type")]
	public TypeEnum? Type { get; set; }

	/// <summary>
	/// This interface's ID
	/// </summary>
	/// <value>This interface's ID</value>
	[DataMember(Name="id", EmitDefaultValue=false)]
	[JsonPropertyName("id")]
	public string Id { get; set; }

	/// <summary>
	/// Gets or Sets Links
	/// </summary>
	[DataMember(Name="links", EmitDefaultValue=false)]
	[JsonPropertyName("links")]
	public InterfaceRelationshipsConnectedToLinks Links { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
