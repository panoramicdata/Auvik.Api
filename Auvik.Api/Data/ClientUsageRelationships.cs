#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// Client usage object's relationships to other resources
/// </summary>
[DataContract]
public class ClientUsageRelationships
{
	/// <summary>
	/// Gets or Sets Clients
	/// </summary>
	[DataMember(Name = "clients", EmitDefaultValue = false)]
	[JsonPropertyName("clients")]
	public ClientUsageRelationshipsClients Clients { get; set; }

	/// <summary>
	/// Gets or Sets Devices
	/// </summary>
	[DataMember(Name = "devices", EmitDefaultValue = false)]
	[JsonPropertyName("devices")]
	public ClientUsageRelationshipsDevices Devices { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}