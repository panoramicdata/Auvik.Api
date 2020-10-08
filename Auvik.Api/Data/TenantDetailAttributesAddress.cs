using System.Text;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// Address of the tenant
	/// </summary>
	[DataContract]
	public class TenantDetailAttributesAddress
	{
		/// <summary>
		/// The state or province the tenant locates
		/// </summary>
		/// <value>The state or province the tenant locates</value>
		[DataMember(Name="State/Province", EmitDefaultValue=false)]
		public string StateProvince { get; set; }

		/// <summary>
		/// ZIP or PostalCode of the address
		/// </summary>
		/// <value>ZIP or PostalCode of the address</value>
		[DataMember(Name="ZIP/PostalCode", EmitDefaultValue=false)]
		public string ZIPPostalCode { get; set; }

		/// <summary>
		/// First part of address
		/// </summary>
		/// <value>First part of address</value>
		[DataMember(Name="address1", EmitDefaultValue=false)]
		public string Address1 { get; set; }

		/// <summary>
		/// Second part of address
		/// </summary>
		/// <value>Second part of address</value>
		[DataMember(Name="address2", EmitDefaultValue=false)]
		public string Address2 { get; set; }

		/// <summary>
		/// The city tenant locates
		/// </summary>
		/// <value>The city tenant locates</value>
		[DataMember(Name="city", EmitDefaultValue=false)]
		public string City { get; set; }

		/// <summary>
		/// Country of the tenant
		/// </summary>
		/// <value>Country of the tenant</value>
		[DataMember(Name="country", EmitDefaultValue=false)]
		public string Country { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TenantDetailAttributesAddress {\n");
			sb.Append("  StateProvince: ").Append(StateProvince).Append("\n");
			sb.Append("  ZIPPostalCode: ").Append(ZIPPostalCode).Append("\n");
			sb.Append("  Address1: ").Append(Address1).Append("\n");
			sb.Append("  Address2: ").Append(Address2).Append("\n");
			sb.Append("  City: ").Append(City).Append("\n");
			sb.Append("  Country: ").Append(Country).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
