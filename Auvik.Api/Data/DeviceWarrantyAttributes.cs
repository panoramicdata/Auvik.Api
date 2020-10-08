using System.IO;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The type-specific properties of the devices object returned
	/// </summary>
	[DataContract]
	public class DeviceWarrantyAttributes
	{
		/// <summary>
		/// Contract renewal availability
		/// </summary>
		/// <value>Contract renewal availability</value>
		[DataMember(Name="contractRenewalAvailability", EmitDefaultValue=false)]
		public string ContractRenewalAvailability { get; set; }

		/// <summary>
		/// Device's name
		/// </summary>
		/// <value>Device's name</value>
		[DataMember(Name="deviceName", EmitDefaultValue=false)]
		public string DeviceName { get; set; }

		/// <summary>
		/// Recommended Devices software version, if known
		/// </summary>
		/// <value>Recommended Devices software version, if known</value>
		[DataMember(Name="recommendedSoftwareVersion", EmitDefaultValue=false)]
		public string RecommendedSoftwareVersion { get; set; }

		/// <summary>
		/// Service attachment status
		/// </summary>
		/// <value>Service attachment status</value>
		[DataMember(Name="serviceAttachmentStatus", EmitDefaultValue=false)]
		public string ServiceAttachmentStatus { get; set; }

		/// <summary>
		/// Service coverage status
		/// </summary>
		/// <value>Service coverage status</value>
		[DataMember(Name="serviceCoverageStatus", EmitDefaultValue=false)]
		public string ServiceCoverageStatus { get; set; }

		/// <summary>
		/// Warranty coverage status
		/// </summary>
		/// <value>Warranty coverage status</value>
		[DataMember(Name="warrantyCoverageStatus", EmitDefaultValue=false)]
		public string WarrantyCoverageStatus { get; set; }

		/// <summary>
		/// Warranty expiration date for this device. Value is what is returned by Cisco device, which is not guaranteed to be a date.
		/// </summary>
		/// <value>Warranty expiration date for this device. Value is what is returned by Cisco device, which is not guaranteed to be a date.</value>
		[DataMember(Name="warrantyExpirationDate", EmitDefaultValue=false)]
		public string WarrantyExpirationDate { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceWarrantyAttributes {\n");
			sb.Append("  ContractRenewalAvailability: ").Append(ContractRenewalAvailability).Append("\n");
			sb.Append("  DeviceName: ").Append(DeviceName).Append("\n");
			sb.Append("  RecommendedSoftwareVersion: ").Append(RecommendedSoftwareVersion).Append("\n");
			sb.Append("  ServiceAttachmentStatus: ").Append(ServiceAttachmentStatus).Append("\n");
			sb.Append("  ServiceCoverageStatus: ").Append(ServiceCoverageStatus).Append("\n");
			sb.Append("  WarrantyCoverageStatus: ").Append(WarrantyCoverageStatus).Append("\n");
			sb.Append("  WarrantyExpirationDate: ").Append(WarrantyExpirationDate).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
