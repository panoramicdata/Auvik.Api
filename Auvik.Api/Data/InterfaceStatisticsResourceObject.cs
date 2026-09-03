#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// Interface statistics resource object
/// </summary>
[DataContract]
public class InterfaceStatisticsResourceObject
{
	/// <summary>
	/// The type of this resource object
	/// </summary>
	/// <value>The type of this resource object</value>
	[JsonConverter(typeof(EnumMemberJsonConverter))]
	public enum TypeEnum
	{

		/// <summary>
		/// Enum InterfaceStatistics for "interfaceStatistics"
		/// </summary>
		[EnumMember(Value = "interfaceStatistics")]
		InterfaceStatistics
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
	public StatisticsAttributes Attributes { get; set; }

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
	public InterfaceStatisticsResourceObjectLinks Links { get; set; }

	/// <summary>
	/// Gets or Sets Relationships
	/// </summary>
	[DataMember(Name="relationships", EmitDefaultValue=false)]
	[JsonPropertyName("relationships")]
	public InterfaceStatisticsRelationships Relationships { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
