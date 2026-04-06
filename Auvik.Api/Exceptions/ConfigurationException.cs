using System;

namespace Auvik.Api.Exceptions;

/// <summary>
/// Exception thrown when client configuration is invalid.
/// </summary>
public class ConfigurationException : Exception
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ConfigurationException"/> class.
	/// </summary>
	public ConfigurationException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ConfigurationException"/> class with a message.
	/// </summary>
	/// <param name="message">The exception message.</param>
	public ConfigurationException(string message) : base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ConfigurationException"/> class with a message and inner exception.
	/// </summary>
	/// <param name="message">The exception message.</param>
	/// <param name="innerException">The underlying exception that caused this error.</param>
	public ConfigurationException(string message, Exception innerException) : base(message, innerException)
	{
	}
}
