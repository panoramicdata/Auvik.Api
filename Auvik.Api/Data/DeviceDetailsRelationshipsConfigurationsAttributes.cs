using System.IO;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The type-specific properties of the configuration object returned
	/// </summary>
	[DataContract]
	public class DeviceDetailsRelationshipsConfigurationsAttributes
	{
		/// <summary>
		/// Last backup time of the configuration
		/// </summary>
		/// <value>Last backup time of the configuration</value>
		[DataMember(Name="backupTime", EmitDefaultValue=false)]
		public string BackupTime { get; set; }

		/// <summary>
		/// Whether the configuration is currently running
		/// </summary>
		/// <value>Whether the configuration is currently running</value>
		[DataMember(Name="isRunning", EmitDefaultValue=false)]
		public bool? IsRunning { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceDetailsRelationshipsConfigurationsAttributes {\n");
			sb.Append("  BackupTime: ").Append(BackupTime).Append("\n");
			sb.Append("  IsRunning: ").Append(IsRunning).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
