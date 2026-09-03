#nullable disable

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// List of clients' usage (if any) under this client
/// </summary>
[DataContract]
public class ClientUsageRelationshipsClients
{
	/// <summary>
	/// A client's usage for the given usage period
	/// </summary>
	/// <value>A client's usage for the given usage period</value>
	[DataMember(Name = "data", EmitDefaultValue = false)]
	[JsonPropertyName("data")]
	public List<ClientUsageRelationshipsClientsData> Data { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}