#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// Links relating to this interface
/// </summary>
[DataContract]
public class AlertRelationshipsRelatedAlertDataLinks
{
	/// <summary>
	/// Link to this interface's dashboard in the Auvik UI
	/// </summary>
	/// <value>Link to this interface's dashboard in the Auvik UI</value>
	[DataMember(Name = "dashboard", EmitDefaultValue = false)]
	[JsonPropertyName("dashboard")]
	public string Dashboard { get; set; }

	/// <summary>
	/// Link to this alert info
	/// </summary>
	/// <value>Link to this alert info</value>
	[DataMember(Name = "self", EmitDefaultValue = false)]
	[JsonPropertyName("self")]
	public string Self { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}