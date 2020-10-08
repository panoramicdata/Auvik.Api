using System.Text;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
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
		public InterfaceRelationshipsConnectedTo ConnectedTo { get; set; }

		/// <summary>
		/// Gets or Sets Networks
		/// </summary>
		[DataMember(Name="networks", EmitDefaultValue=false)]
		public InterfaceRelationshipsNetworks Networks { get; set; }

		/// <summary>
		/// Gets or Sets ParentDevice
		/// </summary>
		[DataMember(Name="parentDevice", EmitDefaultValue=false)]
		public InterfaceRelationshipsParentDevice ParentDevice { get; set; }

		/// <summary>
		/// Gets or Sets Tenant
		/// </summary>
		[DataMember(Name="tenant", EmitDefaultValue=false)]
		public Tenant Tenant { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class InterfaceRelationships {\n");
			sb.Append("  ConnectedTo: ").Append(ConnectedTo).Append("\n");
			sb.Append("  Networks: ").Append(Networks).Append("\n");
			sb.Append("  ParentDevice: ").Append(ParentDevice).Append("\n");
			sb.Append("  Tenant: ").Append(Tenant).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
