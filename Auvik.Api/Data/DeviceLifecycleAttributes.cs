using System.IO;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The type-specific properties of the devices object returned
	/// </summary>
	[DataContract]
	public class DeviceLifecycleAttributes
	{
		/// <summary>
		/// Availability of service and support for the product
		/// </summary>
		/// <value>Availability of service and support for the product</value>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum LastSupportStatusEnum
		{

			/// <summary>
			/// Enum Covered for "covered"
			/// </summary>
			[EnumMember(Value = "covered")]
			Covered,

			/// <summary>
			/// Enum Available for "available"
			/// </summary>
			[EnumMember(Value = "available")]
			Available,

			/// <summary>
			/// Enum Expired for "expired"
			/// </summary>
			[EnumMember(Value = "expired")]
			Expired,

			/// <summary>
			/// Enum SecurityOnly for "securityOnly"
			/// </summary>
			[EnumMember(Value = "securityOnly")]
			SecurityOnly,

			/// <summary>
			/// Enum Unpublished for "unpublished"
			/// </summary>
			[EnumMember(Value = "unpublished")]
			Unpublished,

			/// <summary>
			/// Enum Empty for "empty"
			/// </summary>
			[EnumMember(Value = "empty")]
			Empty
		}

		/// <summary>
		/// Availability to order the requested product through Cisco point-of-sale mechanisms
		/// </summary>
		/// <value>Availability to order the requested product through Cisco point-of-sale mechanisms</value>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum SalesAvailabilityEnum
		{

			/// <summary>
			/// Enum Covered for "covered"
			/// </summary>
			[EnumMember(Value = "covered")]
			Covered,

			/// <summary>
			/// Enum Available for "available"
			/// </summary>
			[EnumMember(Value = "available")]
			Available,

			/// <summary>
			/// Enum Expired for "expired"
			/// </summary>
			[EnumMember(Value = "expired")]
			Expired,

			/// <summary>
			/// Enum SecurityOnly for "securityOnly"
			/// </summary>
			[EnumMember(Value = "securityOnly")]
			SecurityOnly,

			/// <summary>
			/// Enum Unpublished for "unpublished"
			/// </summary>
			[EnumMember(Value = "unpublished")]
			Unpublished,

			/// <summary>
			/// Enum Empty for "empty"
			/// </summary>
			[EnumMember(Value = "empty")]
			Empty
		}

		/// <summary>
		/// Availability of any planned maintenance release or scheduled software remedy for a security vulnerability issued by Cisco Engineering
		/// </summary>
		/// <value>Availability of any planned maintenance release or scheduled software remedy for a security vulnerability issued by Cisco Engineering</value>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum SecuritySoftwareMaintenanceStatusEnum
		{

			/// <summary>
			/// Enum Covered for "covered"
			/// </summary>
			[EnumMember(Value = "covered")]
			Covered,

			/// <summary>
			/// Enum Available for "available"
			/// </summary>
			[EnumMember(Value = "available")]
			Available,

			/// <summary>
			/// Enum Expired for "expired"
			/// </summary>
			[EnumMember(Value = "expired")]
			Expired,

			/// <summary>
			/// Enum SecurityOnly for "securityOnly"
			/// </summary>
			[EnumMember(Value = "securityOnly")]
			SecurityOnly,

			/// <summary>
			/// Enum Unpublished for "unpublished"
			/// </summary>
			[EnumMember(Value = "unpublished")]
			Unpublished,

			/// <summary>
			/// Enum Empty for "empty"
			/// </summary>
			[EnumMember(Value = "empty")]
			Empty
		}

		/// <summary>
		/// Availability of any software maintenance releases or bug fixes to the software product released by Cisco Engineering
		/// </summary>
		/// <value>Availability of any software maintenance releases or bug fixes to the software product released by Cisco Engineering</value>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum SoftwareMaintenanceStatusEnum
		{

			/// <summary>
			/// Enum Covered for "covered"
			/// </summary>
			[EnumMember(Value = "covered")]
			Covered,

			/// <summary>
			/// Enum Available for "available"
			/// </summary>
			[EnumMember(Value = "available")]
			Available,

			/// <summary>
			/// Enum Expired for "expired"
			/// </summary>
			[EnumMember(Value = "expired")]
			Expired,

			/// <summary>
			/// Enum SecurityOnly for "securityOnly"
			/// </summary>
			[EnumMember(Value = "securityOnly")]
			SecurityOnly,

			/// <summary>
			/// Enum Unpublished for "unpublished"
			/// </summary>
			[EnumMember(Value = "unpublished")]
			Unpublished,

			/// <summary>
			/// Enum Empty for "empty"
			/// </summary>
			[EnumMember(Value = "empty")]
			Empty
		}

		/// <summary>
		/// Availability of service and support for the product
		/// </summary>
		/// <value>Availability of service and support for the product</value>
		[DataMember(Name="lastSupportStatus", EmitDefaultValue=false)]
		public LastSupportStatusEnum? LastSupportStatus { get; set; }

		/// <summary>
		/// Availability to order the requested product through Cisco point-of-sale mechanisms
		/// </summary>
		/// <value>Availability to order the requested product through Cisco point-of-sale mechanisms</value>
		[DataMember(Name="salesAvailability", EmitDefaultValue=false)]
		public SalesAvailabilityEnum? SalesAvailability { get; set; }

		/// <summary>
		/// Availability of any planned maintenance release or scheduled software remedy for a security vulnerability issued by Cisco Engineering
		/// </summary>
		/// <value>Availability of any planned maintenance release or scheduled software remedy for a security vulnerability issued by Cisco Engineering</value>
		[DataMember(Name="securitySoftwareMaintenanceStatus", EmitDefaultValue=false)]
		public SecuritySoftwareMaintenanceStatusEnum? SecuritySoftwareMaintenanceStatus { get; set; }

		/// <summary>
		/// Availability of any software maintenance releases or bug fixes to the software product released by Cisco Engineering
		/// </summary>
		/// <value>Availability of any software maintenance releases or bug fixes to the software product released by Cisco Engineering</value>
		[DataMember(Name="softwareMaintenanceStatus", EmitDefaultValue=false)]
		public SoftwareMaintenanceStatusEnum? SoftwareMaintenanceStatus { get; set; }

		/// <summary>
		/// Device's name
		/// </summary>
		/// <value>Device's name</value>
		[DataMember(Name="deviceName", EmitDefaultValue=false)]
		public string DeviceName { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceLifecycleAttributes {\n");
			sb.Append("  DeviceName: ").Append(DeviceName).Append("\n");
			sb.Append("  LastSupportStatus: ").Append(LastSupportStatus).Append("\n");
			sb.Append("  SalesAvailability: ").Append(SalesAvailability).Append("\n");
			sb.Append("  SecuritySoftwareMaintenanceStatus: ").Append(SecuritySoftwareMaintenanceStatus).Append("\n");
			sb.Append("  SoftwareMaintenanceStatus: ").Append(SoftwareMaintenanceStatus).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
