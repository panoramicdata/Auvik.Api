#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// Client usage object's relationships to other resources
/// </summary>
[DataContract]
public class DeviceUsageRelationships
{
	/// <summary>
	/// Gets or Sets _Client
	/// </summary>
	[DataMember(Name="client", EmitDefaultValue=false)]
	[JsonPropertyName("client")]
	public DeviceUsageRelationshipsClient _Client { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}
