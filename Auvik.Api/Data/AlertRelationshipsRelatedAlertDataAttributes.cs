#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// The attribute of the related alert
/// </summary>
[DataContract]
public class AlertRelationshipsRelatedAlertDataAttributes
{
	/// <summary>
	/// The name of related alert
	/// </summary>
	/// <value>The name of related alert</value>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}