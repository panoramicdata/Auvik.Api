#nullable disable

using System.IO;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// The type-specific properties of the notes object returned
/// </summary>
[DataContract]
public class NoteAttributes
{
	/// <summary>
	/// The related entity type
	/// </summary>
	/// <value>The related entity type</value>
	[JsonConverter(typeof(EnumMemberJsonConverter))]
	public enum EntityTypeEnum
	{

		/// <summary>
		/// Enum Root for "root"
		/// </summary>
		[EnumMember(Value = "root")]
		Root,

		/// <summary>
		/// Enum Device for "device"
		/// </summary>
		[EnumMember(Value = "device")]
		Device,

		/// <summary>
		/// Enum Network for "network"
		/// </summary>
		[EnumMember(Value = "network")]
		Network,

		/// <summary>
		/// Enum Interface for "interface"
		/// </summary>
		[EnumMember(Value = "interface")]
		Interface
	}

	/// <summary>
	/// The related entity type
	/// </summary>
	/// <value>The related entity type</value>
	[DataMember(Name="entityType", EmitDefaultValue=false)]
	[JsonPropertyName("entityType")]
	public EntityTypeEnum? EntityType { get; set; }

	/// <summary>
	/// Content of this note
	/// </summary>
	/// <value>Content of this note</value>
	[DataMember(Name="body", EmitDefaultValue=false)]
	[JsonPropertyName("body")]
	public string Body { get; set; }

	/// <summary>
	/// The related entity's ID
	/// </summary>
	/// <value>The related entity's ID</value>
	[DataMember(Name="entityId", EmitDefaultValue=false)]
	[JsonPropertyName("entityId")]
	public string EntityId { get; set; }

	/// <summary>
	/// The related entity's name
	/// </summary>
	/// <value>The related entity's name</value>
	[DataMember(Name="entityName", EmitDefaultValue=false)]
	[JsonPropertyName("entityName")]
	public string EntityName { get; set; }

	/// <summary>
	/// When one of this entity note's attributes was last modified
	/// </summary>
	/// <value>When one of this entity note's attributes was last modified</value>
	[DataMember(Name="lastModified", EmitDefaultValue=false)]
	[JsonPropertyName("lastModified")]
	public string LastModified { get; set; }

	/// <summary>
	/// The username that last modified the note
	/// </summary>
	/// <value>The username that last modified the note</value>
	[DataMember(Name="lastModifiedBy", EmitDefaultValue=false)]
	[JsonPropertyName("lastModifiedBy")]
	public string LastModifiedBy { get; set; }

	/// <summary>
	/// This note's title
	/// </summary>
	/// <value>This note's title</value>
	[DataMember(Name="title", EmitDefaultValue=false)]
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
