using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The type-specific properties of the networks object returned
	/// </summary>
	[DataContract]
	public class NetworkDetailsAttributes
	{
		/// <summary>
		/// How collectors for this network are selected
		/// </summary>
		/// <value>How collectors for this network are selected</value>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum CollectorSelectionEnum
		{

			/// <summary>
			/// Enum Automatic for "automatic"
			/// </summary>
			[EnumMember(Value = "automatic")]
			Automatic,

			/// <summary>
			/// Enum Manual for "manual"
			/// </summary>
			[EnumMember(Value = "manual")]
			Manual
		}

		/// <summary>
		/// Whether this network is a private or public network
		/// </summary>
		/// <value>Whether this network is a private or public network</value>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum ScopeEnum
		{

			/// <summary>
			/// Enum Private for "private"
			/// </summary>
			[EnumMember(Value = "private")]
			Private,

			/// <summary>
			/// Enum Public for "public"
			/// </summary>
			[EnumMember(Value = "public")]
			Public
		}

		/// <summary>
		/// How collectors for this network are selected
		/// </summary>
		/// <value>How collectors for this network are selected</value>
		[DataMember(Name="collectorSelection", EmitDefaultValue=false)]
		public CollectorSelectionEnum? CollectorSelection { get; set; }

		/// <summary>
		/// Whether this network is a private or public network
		/// </summary>
		/// <value>Whether this network is a private or public network</value>
		[DataMember(Name="scope", EmitDefaultValue=false)]
		public ScopeEnum? Scope { get; set; }

		/// <summary>
		/// IP addresses and IP address ranges on this network that have been excluded from scans
		/// </summary>
		/// <value>IP addresses and IP address ranges on this network that have been excluded from scans</value>
		[DataMember(Name="excludedIpAddresses", EmitDefaultValue=false)]
		public List<string> ExcludedIpAddresses { get; set; }

		/// <summary>
		/// UUID of the primary Auvik collector assigned to this network
		/// </summary>
		/// <value>UUID of the primary Auvik collector assigned to this network</value>
		[DataMember(Name="primaryCollector", EmitDefaultValue=false)]
		public string PrimaryCollector { get; set; }

		/// <summary>
		/// List of UUIDs of secondary Auvik collectors assigned to this network, if any
		/// </summary>
		/// <value>List of UUIDs of secondary Auvik collectors assigned to this network, if any</value>
		[DataMember(Name="secondaryCollectors", EmitDefaultValue=false)]
		public List<string> SecondaryCollectors { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class NetworkDetailsAttributes {\n");
			sb.Append("  CollectorSelection: ").Append(CollectorSelection).Append("\n");
			sb.Append("  ExcludedIpAddresses: ").Append(ExcludedIpAddresses).Append("\n");
			sb.Append("  PrimaryCollector: ").Append(PrimaryCollector).Append("\n");
			sb.Append("  Scope: ").Append(Scope).Append("\n");
			sb.Append("  SecondaryCollectors: ").Append(SecondaryCollectors).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
