using System.Text;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// This interface's parent device
	/// </summary>
	[DataContract]
	public class InterfaceRelationshipsParentDevice
	{
		/// <summary>
		/// Gets or Sets Data
		/// </summary>
		[DataMember(Name="data", EmitDefaultValue=false)]
		public InterfaceRelationshipsParentDeviceData Data { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class InterfaceRelationshipsParentDevice {\n");
			sb.Append("  Data: ").Append(Data).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
