using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// List of other interfaces this interface is connected to
	/// </summary>
	[DataContract]
	public class InterfaceRelationshipsConnectedTo
	{
		/// <summary>
		/// An interface resource object
		/// </summary>
		/// <value>An interface resource object</value>
		[DataMember(Name="data", EmitDefaultValue=false)]
		public List<InterfaceRelationshipsConnectedToData> Data { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class InterfaceRelationshipsConnectedTo {\n");
			sb.Append("  Data: ").Append(Data).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
