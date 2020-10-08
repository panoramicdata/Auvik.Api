using Newtonsoft.Json;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The type-specific properties of the configuration object returned
	/// </summary>
	[DataContract]
	public class ConfigAttributes
	{
		/// <summary>
		/// The time at which this configuration was backed up.
		/// </summary>
		/// <value>The time at which this configuration was backed up.</value>
		[DataMember(Name = "backupTime", EmitDefaultValue = false)]
		public string BackupTime { get; set; }

		/// <summary>
		/// Whether or not the configuration is currently running on the device.
		/// </summary>
		/// <value>Whether or not the configuration is currently running on the device.</value>
		[DataMember(Name = "isRunning", EmitDefaultValue = false)]
		public bool? IsRunning { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConfigAttributes {\n");
			sb.Append("  BackupTime: ").Append(BackupTime).Append("\n");
			sb.Append("  IsRunning: ").Append(IsRunning).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}