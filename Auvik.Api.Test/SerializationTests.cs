using Auvik.Api.Data;
using Auvik.Api.Serialization;
using AwesomeAssertions;
using System.Text.Json;
using Xunit;

namespace Auvik.Api.Test;

/// <summary>
/// Unit tests for the System.Text.Json contract the client uses. These need no API credentials.
/// </summary>
public class SerializationTests
{
	private static JsonSerializerOptions Options => AuvikJsonSerializerOptions.Default;

	/// <summary>
	/// Enum values arrive as the strings declared by EnumMember, not as C# member names.
	/// </summary>
	[Fact]
	public void Deserialize_EnumMemberValue_BindsToEnum()
	{
		var deserialized = JsonSerializer.Deserialize<DeviceTypeSchema>("\"l3Switch\"", Options);

		deserialized.Should().Be(DeviceTypeSchema.L3Switch);
	}

	/// <summary>
	/// Writing an enum uses the EnumMember value.
	/// </summary>
	[Fact]
	public void Serialize_Enum_WritesEnumMemberValue()
	{
		var serialized = JsonSerializer.Serialize(DeviceTypeSchema.L3Switch, Options);

		serialized.Should().Be("\"l3Switch\"");
	}

	/// <summary>
	/// A nested, nullable enum property is covered by the converter too.
	/// </summary>
	[Fact]
	public void Deserialize_NullableEnumProperty_BindsToEnum()
	{
		var deserialized = JsonSerializer.Deserialize<TenantData>(
			"""{"type":"tenant","id":"123"}""",
			Options);

		deserialized.Should().NotBeNull();
		deserialized!.Type.Should().Be(TenantData.TypeEnum.Tenant);
		deserialized.Id.Should().Be("123");
	}

	/// <summary>
	/// An unrecognised enum string is an error rather than a silent default.
	/// </summary>
	[Fact]
	public void Deserialize_UnknownEnumValue_Throws()
	{
		var act = () => JsonSerializer.Deserialize<DeviceTypeSchema>("\"notADeviceType\"", Options);

		act.Should().Throw<JsonException>();
	}

	/// <summary>
	/// Property names come from the JSON names on the DTOs, including those that are not
	/// a camelCase transform of the C# property name.
	/// </summary>
	[Fact]
	public void Deserialize_NonCamelCasePropertyNames_Bind()
	{
		var deserialized = JsonSerializer.Deserialize<TenantDetailAttributesAddress>(
			"""{"State/Province":"Dorset","ZIP/PostalCode":"BH1 1AA","city":"Bournemouth"}""",
			Options);

		deserialized.Should().NotBeNull();
		deserialized!.StateProvince.Should().Be("Dorset");
		deserialized.ZIPPostalCode.Should().Be("BH1 1AA");
		deserialized.City.Should().Be("Bournemouth");
	}

	/// <summary>
	/// A property whose JSON name matches nothing must not silently bind to another member.
	/// </summary>
	[Fact]
	public void Serialize_UsesJsonPropertyNames_AndOmitsUnsetMembers()
	{
		var address = new TenantDetailAttributesAddress
		{
			StateProvince = "Dorset",
			ZIPPostalCode = "BH1 1AA"
		};

		var serialized = JsonSerializer.Serialize(address, Options);

		serialized.Should().Be("""{"State/Province":"Dorset","ZIP/PostalCode":"BH1 1AA"}""");
	}

	/// <summary>
	/// A deeply nested response binds end to end.
	/// </summary>
	[Fact]
	public void Deserialize_NestedResponse_BindsAllLevels()
	{
		var deserialized = JsonSerializer.Deserialize<DeviceInfoReadSingle>(
			"""
			{
				"data": {
					"id": "abc",
					"type": "device",
					"attributes": { "deviceName": "switch-1", "deviceType": "l3Switch", "onlineStatus": "online" }
				}
			}
			""",
			Options);

		deserialized.Should().NotBeNull();
		deserialized!.Data.Should().NotBeNull();
		deserialized.Data.Id.Should().Be("abc");
		deserialized.Data.Type.Should().Be(DevicesResourceObject.TypeEnum.Device);
		deserialized.Data.Attributes.Should().NotBeNull();
		deserialized.Data.Attributes.DeviceName.Should().Be("switch-1");
		deserialized.Data.Attributes.DeviceType.Should().Be(DeviceAttributes.DeviceTypeEnum.L3Switch);
	}
}
