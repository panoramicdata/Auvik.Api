#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// The body a statistics resource object shares, whatever kind of statistic it carries. The
/// resource type itself is declared by each derived object.
/// </summary>
[DataContract]
public abstract class StatisticsResourceObject
{
	/// <summary>
	/// Gets or Sets Attributes
	/// </summary>
	[DataMember(Name = "attributes", EmitDefaultValue = false)]
	[JsonPropertyName("attributes")]
	public StatisticsAttributes Attributes { get; set; }

	/// <summary>
	/// ID for this statistic
	/// </summary>
	/// <value>ID for this statistic</value>
	[DataMember(Name = "id", EmitDefaultValue = false)]
	[JsonPropertyName("id")]
	public string Id { get; set; }

	/// <summary>
	/// Gets or Sets Links
	/// </summary>
	[DataMember(Name = "links", EmitDefaultValue = false)]
	[JsonPropertyName("links")]
	public DeviceStatisticsResourceObjectLinks Links { get; set; }

	/// <summary>
	/// Gets or Sets Relationships
	/// </summary>
	[DataMember(Name = "relationships", EmitDefaultValue = false)]
	[JsonPropertyName("relationships")]
	public DeviceStatisticsRelationships Relationships { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
