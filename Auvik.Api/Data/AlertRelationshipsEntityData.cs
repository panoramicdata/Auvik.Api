#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// An entity resource object
/// </summary>
[DataContract]
public class AlertRelationshipsEntityData
{
	/// <summary>
	/// The type of object in the api
	/// </summary>
	/// <value>The type of object in the api</value>
	[JsonConverter(typeof(EnumMemberJsonConverter))]
	public enum TypeEnum
	{

		/// <summary>
		/// Enum Interface for "interface"
		/// </summary>
		[EnumMember(Value = "interface")]
		Interface,

		/// <summary>
		/// Enum Device for "device"
		/// </summary>
		[EnumMember(Value = "device")]
		Device,

		/// <summary>
		/// Enum Network for "network"
		/// </summary>
		[EnumMember(Value = "network")]
		Network
	}

	/// <summary>
	/// The type of object in the api
	/// </summary>
	/// <value>The type of object in the api</value>
	[DataMember(Name = "type", EmitDefaultValue = false)]
	[JsonPropertyName("type")]
	public TypeEnum? Type { get; set; }

	/// <summary>
	/// The unique identifier for this entity
	/// </summary>
	/// <value>The unique identifier for this entity</value>
	[DataMember(Name = "id", EmitDefaultValue = false)]
	[JsonPropertyName("id")]
	public string Id { get; set; }

	/// <summary>
	/// Gets or Sets Links
	/// </summary>
	[DataMember(Name = "links", EmitDefaultValue = false)]
	[JsonPropertyName("links")]
	public AlertRelationshipsEntityDataLinks Links { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}