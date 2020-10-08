using System.IO;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The type-specific properties of the OID object returned
	/// </summary>
	[DataContract]
	public class OidAttributes
	{
		/// <summary>
		/// OID identifier
		/// </summary>
		/// <value>OID identifier</value>
		[DataMember(Name="oid", EmitDefaultValue=false)]
		public string Oid { get; set; }

		/// <summary>
		/// OID name
		/// </summary>
		/// <value>OID name</value>
		[DataMember(Name="oidName", EmitDefaultValue=false)]
		public string OidName { get; set; }

		/// <summary>
		/// OID value
		/// </summary>
		/// <value>OID value</value>
		[DataMember(Name="value", EmitDefaultValue=false)]
		public decimal? Value { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class OidAttributes {\n");
			sb.Append("  Oid: ").Append(Oid).Append("\n");
			sb.Append("  OidName: ").Append(OidName).Append("\n");
			sb.Append("  Value: ").Append(Value).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
