using Auvik.Api;
using Auvik.Api.Data;
using Auvik.Api.Serialization;
using AwesomeAssertions;
using System;
using System.Reflection;
using Xunit;

namespace Auvik.Api.Test;

/// <summary>
/// Tests the <see cref="AuvikClientOptions"/> surface and validation rules that the
/// <see cref="AuvikClient"/> exercises only partially.
/// </summary>
public class AuvikClientOptionsTests
{
	/// <summary>
	/// The default HttpClient is null.
	/// </summary>
	[Fact]
	public void Default_HttpClient_IsNull()
	{
		new AuvikClientOptions().HttpClient.Should().BeNull();
	}

	/// <summary>
	/// Each required option's absence is detected by Validate.
	/// </summary>
	[Theory]
	[InlineData(null, "u", "k")]
	[InlineData("https://x.example", null, "k")]
	[InlineData("https://x.example", "u", null)]
	public void Validate_MissingOption_Throws(string? uri, string? username, string? apiKey)
	{
		var options = new AuvikClientOptions
		{
			Uri = uri is null ? null! : new Uri(uri),
			Username = username!,
			ApiKey = apiKey!,
		};

		var method = typeof(AuvikClientOptions).GetMethod("Validate", BindingFlags.Instance | BindingFlags.NonPublic)!;
		Exception? inner = null;
		try
		{
			method.Invoke(options, null);
		}
		catch (TargetInvocationException ex)
		{
			inner = ex.InnerException;
		}

		inner.Should().BeOfType<Auvik.Api.Exceptions.ConfigurationException>();
	}

	/// <summary>
	/// A fully populated options object passes validation.
	/// </summary>
	[Fact]
	public void Validate_ValidOptions_Passes()
	{
		var options = new AuvikClientOptions
		{
			Uri = new Uri("https://auvikapi.us1.my.auvik.com"),
			Username = "u",
			ApiKey = "k",
		};

		var method = typeof(AuvikClientOptions).GetMethod("Validate", BindingFlags.Instance | BindingFlags.NonPublic)!;
		method.Invoke(options, null).Should().BeNull();
	}
}

/// <summary>
/// Pins the string presentation of the alert resource objects.
/// </summary>
public class ResourceObjectToStringTests
{
	/// <summary>
	/// <see cref="AlertsResourceObject"/> renders its five properties in name order.
	/// </summary>
	[Fact]
	public void AlertsResourceObject_ToString_ListsEveryProperty()
	{
		var obj = new AlertsResourceObject
		{
			Type = AlertsResourceObject.TypeEnum.Alert,
			Id = "a-1",
		};

		obj.ToString().Should().Be(
			"class AlertsResourceObject {\n"
			+ "  Attributes: \n"
			+ "  Id: a-1\n"
			+ "  Links: \n"
			+ "  Relationships: \n"
			+ "  Type: Alert\n"
			+ "}\n");
	}
}
