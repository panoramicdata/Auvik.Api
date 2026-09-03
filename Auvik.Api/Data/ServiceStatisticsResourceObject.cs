#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// Service statistics resource object
/// </summary>
[DataContract]
public class ServiceStatisticsResourceObject
{
	/// <summary>
	/// The type of this resource object
	/// </summary>
	/// <value>The type of this resource object</value>
	[JsonConverter(typeof(EnumMemberJsonConverter))]
	public enum TypeEnum
	{

		/// <summary>
		/// Enum ServiceStatistics for "serviceStatistics"
		/// </summary>
		[EnumMember(Value = "serviceStatistics")]
		ServiceStatistics
	}

	/// <summary>
	/// The type of this resource object
	/// </summary>
	/// <value>The type of this resource object</value>
	[DataMember(Name="type", EmitDefaultValue=false)]
	[JsonPropertyName("type")]
	public TypeEnum? Type { get; set; }

	/// <summary>
	/// Gets or Sets Attributes
	/// </summary>
	[DataMember(Name="attributes", EmitDefaultValue=false)]
	[JsonPropertyName("attributes")]
	public ServiceStatisticsAttributes Attributes { get; set; }

	/// <summary>
	/// ID for this statistic
	/// </summary>
	/// <value>ID for this statistic</value>
	[DataMember(Name="id", EmitDefaultValue=false)]
	[JsonPropertyName("id")]
	public string Id { get; set; }

	/// <summary>
	/// Gets or Sets Links
	/// </summary>
	[DataMember(Name="links", EmitDefaultValue=false)]
	[JsonPropertyName("links")]
	public ServiceStatisticsResourceObjectLinks Links { get; set; }

	/// <summary>
	/// Gets or Sets Relationships
	/// </summary>
	[DataMember(Name="relationships", EmitDefaultValue=false)]
	[JsonPropertyName("relationships")]
	public ServiceStatisticsRelationships Relationships { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
