#nullable disable

using System.Text;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Auvik.Api.Data;

/// <summary>
/// The type-specific properties of the client usage object returned
/// </summary>
[DataContract]
public class DeviceUsageAttributes
{
	/// <summary>
	/// The average billable device days across the usage period
	/// </summary>
	/// <value>The average billable device days across the usage period</value>
	[DataMember(Name="averageDays", EmitDefaultValue=false)]
	[JsonPropertyName("averageDays")]
	public decimal? AverageDays { get; set; }

	/// <summary>
	/// Gets or Sets AverageDaysByClientType
	/// </summary>
	[DataMember(Name="averageDaysByClientType", EmitDefaultValue=false)]
	[JsonPropertyName("averageDaysByClientType")]
	public DeviceUsageAttributesAverageDaysByClientType AverageDaysByClientType { get; set; }

	/// <summary>
	/// Device's name
	/// </summary>
	/// <value>Device's name</value>
	[DataMember(Name="deviceName", EmitDefaultValue=false)]
	[JsonPropertyName("deviceName")]
	public string DeviceName { get; set; }

	/// <summary>
	/// The total billable device days across the usage period
	/// </summary>
	/// <value>The total billable device days across the usage period</value>
	[DataMember(Name="totalDays", EmitDefaultValue=false)]
	[JsonPropertyName("totalDays")]
	public decimal? TotalDays { get; set; }

	/// <summary>
	/// Gets or Sets TotalDaysByClientType
	/// </summary>
	[DataMember(Name="totalDaysByClientType", EmitDefaultValue=false)]
	[JsonPropertyName("totalDaysByClientType")]
	public DeviceUsageAttributesTotalDaysByClientType TotalDaysByClientType { get; set; }

	/// <summary>
	/// Gets or Sets UsagePeriod
	/// </summary>
	[DataMember(Name="usagePeriod", EmitDefaultValue=false)]
	[JsonPropertyName("usagePeriod")]
	public ClientUsageAttributesUsagePeriod UsagePeriod { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class DeviceUsageAttributes {\n");
		sb.Append("  AverageDays: ").Append(AverageDays).Append("\n");
		sb.Append("  AverageDaysByClientType: ").Append(AverageDaysByClientType).Append("\n");
		sb.Append("  DeviceName: ").Append(DeviceName).Append("\n");
		sb.Append("  TotalDays: ").Append(TotalDays).Append("\n");
		sb.Append("  TotalDaysByClientType: ").Append(TotalDaysByClientType).Append("\n");
		sb.Append("  UsagePeriod: ").Append(UsagePeriod).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
