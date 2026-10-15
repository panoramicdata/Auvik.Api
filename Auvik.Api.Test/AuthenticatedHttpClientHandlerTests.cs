using Auvik.Api;
using Auvik.Api.Data;
using Auvik.Api.Serialization;
using Auvik.Api.Exceptions;
using AwesomeAssertions;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Auvik.Api.Test;

/// <summary>
/// Tests the hand-written string presentation of <see cref="InterfaceStatisticsRelationships"/>.
/// </summary>
public class InterfaceStatisticsRelationshipsTests
{
	/// <summary>
	/// Both properties appear one per line; unset nested objects render as blank.
	/// </summary>
	[Fact]
	public void ToString_ListsEveryProperty()
	{
		var empty = new InterfaceStatisticsRelationships();

		empty.ToString().Should().Be(
			"class InterfaceStatisticsRelationships {\n"
			+ "  _Interface: \n"
			+ "  Tenant: \n"
			+ "}\n");
	}
}

/// <summary>
/// Pins the string presentation of the shared ObjectDescription-based data objects.
/// </summary>
public class AlertModelToStringTests
{
	/// <summary>
	/// <see cref="AlertAttributes"/> renders each property in ordinal name order.
	/// </summary>
	[Fact]
	public void AlertAttributes_ToString_ListsEveryProperty()
	{
		var attributes = new AlertAttributes
		{
			Severity = AlertAttributes.SeverityEnum.Critical,
			Status = AlertAttributes.StatusEnum.Resolved,
			Description = "desc",
			DetectedOn = "2024-01-01",
			Dismissed = false,
			Dispatched = true,
			Name = "n",
			SpecificationId = "spec-1",
		};

		attributes.ToString().Should().Be(
			"class AlertAttributes {\n"
			+ "  Description: desc\n"
			+ "  DetectedOn: 2024-01-01\n"
			+ "  Dismissed: False\n"
			+ "  Dispatched: True\n"
			+ "  ExternalTicket: \n"
			+ "  Name: n\n"
			+ "  Severity: Critical\n"
			+ "  SpecificationId: spec-1\n"
			+ "  Status: Resolved\n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="AlertAttributesExternalTicket"/> renders both properties.
	/// </summary>
	[Fact]
	public void AlertAttributesExternalTicket_ToString_ListsEveryProperty()
	{
		var ticket = new AlertAttributesExternalTicket
		{
			System = AlertAttributesExternalTicket.SystemEnum.Slack,
			Id = "t-1",
		};

		ticket.ToString().Should().Be(
			"class AlertAttributesExternalTicket {\n"
			+ "  Id: t-1\n"
			+ "  System: Slack\n"
			+ "}\n");
	}

	/// <summary>
	/// <see cref="AlertHistoryInfoReadMultiple"/> renders its three properties in name order.
	/// </summary>
	[Fact]
	public void AlertHistoryInfoReadMultiple_ToString_ListsEveryProperty()
	{
		var payload = new AlertHistoryInfoReadMultiple();

		payload.ToString().Should().Be(
			"class AlertHistoryInfoReadMultiple {\n"
			+ "  Data: \n"
			+ "  Links: \n"
			+ "  Meta: \n"
			+ "}\n");
	}
}

/// <summary>
/// Tests the constructors of <see cref="ConfigurationException"/>.
/// </summary>
public class ConfigurationExceptionTests
{
	/// <summary>
	/// The parameterless constructor produces an exception with no message or inner exception.
	/// </summary>
	[Fact]
	public void Constructor_NoArgs_HasNoMessage()
	{
		new ConfigurationException().InnerException.Should().BeNull();
	}

	/// <summary>
	/// The message constructor carries the message through.
	/// </summary>
	[Fact]
	public void Constructor_Message_PreservesMessage()
	{
		new ConfigurationException("boom").Message.Should().Be("boom");
	}

	/// <summary>
	/// The message and inner exception constructor carries both through.
	/// </summary>
	[Fact]
	public void Constructor_MessageAndInner_PreservesBoth()
	{
		var inner = new InvalidOperationException("inner");
		var ex = new ConfigurationException("outer", inner);

		ex.Message.Should().Be("outer");
		ex.InnerException.Should().BeSameAs(inner);
	}
}

/// <summary>
/// Exercises <see cref="AuthenticatedHttpClientHandler"/> against a loopback <c>TcpListener</c>;
/// no external network is involved.
/// </summary>
public class AuthenticatedHttpClientHandlerTests
{
	/// <summary>
	/// Holds the loopback listener and the captured request bytes as a task that resolves to
	/// the raw request text once the request has been served.
	/// </summary>
	private sealed class LocalEcho : IDisposable
	{
		private readonly TcpListener _listener;
		private readonly Task<string> _requestText;

		public LocalEcho(TcpListener listener, Task<string> requestText)
		{
			_listener = listener;
			_requestText = requestText;
		}

		public int Port => ((IPEndPoint)_listener.LocalEndpoint).Port;
		public Task<string> RequestText => _requestText;

		public void Dispose() => _listener.Stop();
	}

	/// <summary>
	/// Starts a loopback listener that captures the next HTTP request and answers with 200 OK.
	/// </summary>
	private static LocalEcho Start()
	{
		var listener = new TcpListener(IPAddress.Loopback, 0);
		listener.Start();
		int port = ((IPEndPoint)listener.LocalEndpoint).Port;

		var requestText = Task.Run(async () =>
		{
			using var client = await listener.AcceptTcpClientAsync();
			using var stream = client.GetStream();
			var buffer = new byte[8192];
			var read = await stream.ReadAsync(buffer, CancellationToken.None);
			var captured = Encoding.ASCII.GetString(buffer, 0, read);
			var response = Encoding.ASCII.GetBytes("HTTP/1.1 200 OK\r\nContent-Type: text/plain\r\nContent-Length: 2\r\n\r\nok");
			await stream.WriteAsync(response, CancellationToken.None);
			return captured;
		});

		return new LocalEcho(listener, requestText);
	}

	/// <summary>
	/// The handler attaches the Basic credentials; the loopback response is returned to the caller.
	/// </summary>
	[Fact]
	public async Task Send_Request_GetsBasicAuthAndReturnsResponse()
	{
		using var echo = Start();
		var handler = new AuthenticatedHttpClientHandler(new AuvikClientOptions
		{
			Username = "u",
			ApiKey = "k",
			Uri = new Uri("https://auvikapi.us1.my.auvik.com"),
		});

		using var client = new HttpClient(handler) { BaseAddress = new Uri($"http://127.0.0.1:{echo.Port}") };
		var response = await client.SendAsync(
			new HttpRequestMessage(HttpMethod.Get, "anything"),
			CancellationToken.None);

		response.StatusCode.Should().Be(HttpStatusCode.OK);
		(await response.Content.ReadAsStringAsync(CancellationToken.None)).Should().Be("ok");

		var expected = Convert.ToBase64String(Encoding.ASCII.GetBytes("u:k"));
		(await echo.RequestText).Should().Contain("Authorization: Basic " + expected);
	}
}
