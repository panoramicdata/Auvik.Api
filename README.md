# Auvik.Api

[![Nuget](https://img.shields.io/nuget/v/Auvik.Api)](https://www.nuget.org/packages/Auvik.Api/)

To use the Auvik nuget package:

## Visual Studio

1. Open your project in Visual Studio
1. Right-click on the project and click "Manage Nuget packages"
1. Find the package "Auvik.Api" - install the latest version
1. Create an API key in your User Profile in Auvik
1. Note your URL domain, username and API key.

## Example code (C# 8.0):

``` C#
using Auvik.Api;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace My.Project
{
	public static class Program
	{
		public static async Task Main()
		{
			var auvikClient = new AuvikClient(
				new AuvikClientOptions
				{
					// Ensure that the "us3" part of the URI
					// matches your browser navigation bar
					Uri = new Uri("https://auvikapi.us3.my.auvik.com;"),
					Username = "you@yourdomain.com",
					ApiKey = "YOUR API KEY GOES HERE"
				}
			);

			await auvikClient
				.Credentials
				.VerifyCredentials()
				.ConfigureAwait(false);
		}
	}
}
````

## API Documentation

The Auvik API documentation can be found here:

- [Auvik API documentation](https://auvikapi.us1.my.auvik.com/docs)
