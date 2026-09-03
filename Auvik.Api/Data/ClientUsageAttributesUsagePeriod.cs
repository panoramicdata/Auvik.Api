#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// Description of the usage period that's been asked for
/// </summary>
[DataContract]
public class ClientUsageAttributesUsagePeriod
{
	/// <summary>
	/// Date and time the usage period ends
	/// </summary>
	/// <value>Date and time the usage period ends</value>
	[DataMember(Name = "endDate", EmitDefaultValue = false)]
	[JsonPropertyName("endDate")]
	public string EndDate { get; set; }

	/// <summary>
	/// Number of days in the usage period
	/// </summary>
	/// <value>Number of days in the usage period</value>
	[DataMember(Name = "lengthInDays", EmitDefaultValue = false)]
	[JsonPropertyName("lengthInDays")]
	public decimal? LengthInDays { get; set; }

	/// <summary>
	/// Date and time the usage period starts
	/// </summary>
	/// <value>Date and time the usage period starts</value>
	[DataMember(Name = "startDate", EmitDefaultValue = false)]
	[JsonPropertyName("startDate")]
	public string StartDate { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}