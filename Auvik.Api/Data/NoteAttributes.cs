using System.IO;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Auvik.Api.Data
{
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
		[JsonConverter(typeof(StringEnumConverter))]
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
		public EntityTypeEnum? EntityType { get; set; }

		/// <summary>
		/// Content of this note
		/// </summary>
		/// <value>Content of this note</value>
		[DataMember(Name="body", EmitDefaultValue=false)]
		public string Body { get; set; }

		/// <summary>
		/// The related entity's ID
		/// </summary>
		/// <value>The related entity's ID</value>
		[DataMember(Name="entityId", EmitDefaultValue=false)]
		public string EntityId { get; set; }

		/// <summary>
		/// The related entity's name
		/// </summary>
		/// <value>The related entity's name</value>
		[DataMember(Name="entityName", EmitDefaultValue=false)]
		public string EntityName { get; set; }

		/// <summary>
		/// When one of this entity note's attributes was last modified
		/// </summary>
		/// <value>When one of this entity note's attributes was last modified</value>
		[DataMember(Name="lastModified", EmitDefaultValue=false)]
		public string LastModified { get; set; }

		/// <summary>
		/// The username that last modified the note
		/// </summary>
		/// <value>The username that last modified the note</value>
		[DataMember(Name="lastModifiedBy", EmitDefaultValue=false)]
		public string LastModifiedBy { get; set; }

		/// <summary>
		/// This note's title
		/// </summary>
		/// <value>This note's title</value>
		[DataMember(Name="title", EmitDefaultValue=false)]
		public string Title { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class NoteAttributes {\n");
			sb.Append("  Body: ").Append(Body).Append("\n");
			sb.Append("  EntityId: ").Append(EntityId).Append("\n");
			sb.Append("  EntityName: ").Append(EntityName).Append("\n");
			sb.Append("  EntityType: ").Append(EntityType).Append("\n");
			sb.Append("  LastModified: ").Append(LastModified).Append("\n");
			sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
			sb.Append("  Title: ").Append(Title).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
