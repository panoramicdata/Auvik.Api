#nullable disable

using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Auvik.Api.Data;

/// <summary>
/// This entity audit's relationships to other resources
/// </summary>
[DataContract]
public class AuditRelationships
{
	/// <summary>
	/// Gets or Sets Device
	/// </summary>
	[DataMember(Name = "device", EmitDefaultValue = false)]
	[JsonPropertyName("device")]
	public AuditRelationshipsDevice Device { get; set; }

	/// <summary>
	/// Gets or Sets Tenant
	/// </summary>
	[DataMember(Name = "tenant", EmitDefaultValue = false)]
	[JsonPropertyName("tenant")]
	public Tenant Tenant { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class AuditRelationships {\n");
		sb.Append("  Device: ").Append(Device).Append("\n");
		sb.Append("  Tenant: ").Append(Tenant).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}