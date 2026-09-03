#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auvik.Api.Internal;

namespace Auvik.Api.Data;

/// <summary>
/// Links relating to this client's usage
/// </summary>
[DataContract]
public class ClientUsageResourceObjectLinks
{
	/// <summary>
	/// Link to the billing usage dashboard in the Auvik UI.
	/// </summary>
	/// <value>Link to the billing usage dashboard in the Auvik UI.</value>
	[DataMember(Name = "dashboard", EmitDefaultValue = false)]
	[JsonPropertyName("dashboard")]
	public string Dashboard { get; set; }

	/// <summary>
	/// Link to this client's usage in the Usage API
	/// </summary>
	/// <value>Link to this client's usage in the Usage API</value>
	[DataMember(Name = "self", EmitDefaultValue = false)]
	[JsonPropertyName("self")]
	public string Self { get; set; }

	/// <summary>
	/// Link to this client's record in the Tenants API
	/// </summary>
	/// <value>Link to this client's record in the Tenants API</value>
	[DataMember(Name = "tenantRecord", EmitDefaultValue = false)]
	[JsonPropertyName("tenantRecord")]
	public string TenantRecord { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString() => ObjectDescription.Describe(this);
}