#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// The average billable device days for all clients across the usage period, separate by devices' owning client type
/// </summary>
[DataContract]
public class DeviceUsageAttributesAverageDaysByClientType
{
	/// <summary>
	/// Average billable devices days for the device when its client was set to Essentials
	/// </summary>
	/// <value>Average billable devices days for the device when its client was set to Essentials</value>
	[DataMember(Name="essentials", EmitDefaultValue=false)]
	[JsonPropertyName("essentials")]
	public decimal? Essentials { get; set; }

	/// <summary>
	/// Average billable devices days for the device when its client had no set client type
	/// </summary>
	/// <value>Average billable devices days for the device when its client had no set client type</value>
	[DataMember(Name="notier", EmitDefaultValue=false)]
	[JsonPropertyName("notier")]
	public decimal? Notier { get; set; }

	/// <summary>
	/// Average billable devices days for the device when its client was set to Performance
	/// </summary>
	/// <value>Average billable devices days for the device when its client was set to Performance</value>
	[DataMember(Name="performance", EmitDefaultValue=false)]
	[JsonPropertyName("performance")]
	public decimal? Performance { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
