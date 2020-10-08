using System.Runtime.Serialization;
using System.Text;

namespace Auvik.Api.Data
{
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
		public string ComponentName { get; set; }

		/// <summary>
		/// This component's type
		/// </summary>
		/// <value>This component's type</value>
		[DataMember(Name = "componentType", EmitDefaultValue = false)]
		public string ComponentType { get; set; }

		/// <summary>
		/// This component's ID
		/// </summary>
		/// <value>This component's ID</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		/// Gets or Sets Links
		/// </summary>
		[DataMember(Name = "links", EmitDefaultValue = false)]
		public ComponentStatisticsRelationshipsComponentDataLinks Links { get; set; }

		/// <summary>
		/// This component's parent device
		/// </summary>
		/// <value>This component's parent device</value>
		[DataMember(Name = "parentDevice", EmitDefaultValue = false)]
		public string ParentDevice { get; set; }

		/// <summary>
		/// The type of the object
		/// </summary>
		/// <value>The type of the object</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public string Type { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ComponentStatisticsRelationshipsComponentData {\n");
			sb.Append("  ComponentName: ").Append(ComponentName).Append("\n");
			sb.Append("  ComponentType: ").Append(ComponentType).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Links: ").Append(Links).Append("\n");
			sb.Append("  ParentDevice: ").Append(ParentDevice).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}