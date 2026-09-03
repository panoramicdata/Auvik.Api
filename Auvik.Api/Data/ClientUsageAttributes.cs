#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// The type-specific properties of the client usage object returned
/// </summary>
[DataContract]
public class ClientUsageAttributes
{
	/// <summary>
	/// Days this client (and only this client) was billable for across the usage period.
	/// </summary>
	/// <value>Days this client (and only this client) was billable for across the usage period.</value>
	[DataMember(Name = "billableDays", EmitDefaultValue = false)]
	[JsonPropertyName("billableDays")]
	public decimal? BillableDays { get; set; }

	/// <summary>
	/// Gets or Sets ClientUsage
	/// </summary>
	[DataMember(Name = "clientUsage", EmitDefaultValue = false)]
	[JsonPropertyName("clientUsage")]
	public ClientUsageAttributesClientUsage ClientUsage { get; set; }

	/// <summary>
	/// Gets or Sets DeviceUsage
	/// </summary>
	[DataMember(Name = "deviceUsage", EmitDefaultValue = false)]
	[JsonPropertyName("deviceUsage")]
	public ClientUsageAttributesDeviceUsage DeviceUsage { get; set; }

	/// <summary>
	/// Client tenant's domain prefix/name
	/// </summary>
	/// <value>Client tenant's domain prefix/name</value>
	[DataMember(Name = "domainPrefix", EmitDefaultValue = false)]
	[JsonPropertyName("domainPrefix")]
	public string DomainPrefix { get; set; }

	/// <summary>
	/// Gets or Sets UsagePeriod
	/// </summary>
	[DataMember(Name = "usagePeriod", EmitDefaultValue = false)]
	[JsonPropertyName("usagePeriod")]
	public ClientUsageAttributesUsagePeriod UsagePeriod { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}