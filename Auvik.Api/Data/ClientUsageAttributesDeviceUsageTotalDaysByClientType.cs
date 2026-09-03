#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// The total billable device days for this client and all of its children across the usage period, separate by devices' owning client type
/// </summary>
[DataContract]
public class ClientUsageAttributesDeviceUsageTotalDaysByClientType
{
	/// <summary>
	/// Billable devices days for devices on a client set to Essentials
	/// </summary>
	/// <value>Billable devices days for devices on a client set to Essentials</value>
	[DataMember(Name = "essentials", EmitDefaultValue = false)]
	[JsonPropertyName("essentials")]
	public decimal? Essentials { get; set; }

	/// <summary>
	/// Billable devices days for devices on a client with no set client type
	/// </summary>
	/// <value>Billable devices days for devices on a client with no set client type</value>
	[DataMember(Name = "notier", EmitDefaultValue = false)]
	[JsonPropertyName("notier")]
	public decimal? Notier { get; set; }

	/// <summary>
	/// Billable devices days for devices on a client set to Performance
	/// </summary>
	/// <value>Billable devices days for devices on a client set to Performance</value>
	[DataMember(Name = "performance", EmitDefaultValue = false)]
	[JsonPropertyName("performance")]
	public decimal? Performance { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}