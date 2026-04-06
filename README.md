[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

# Auvik.Api

[![Nuget](https://img.shields.io/nuget/v/Auvik.Api)](https://www.nuget.org/packages/Auvik.Api/)
[![Codacy Badge](https://app.codacy.com/project/badge/Grade/e69c5b5373ab4577aef33e06e73e2160)](https://app.codacy.com/gh/panoramicdata/Auvik.Api/dashboard?utm_source=gh&utm_medium=referral&utm_content=&utm_campaign=Badge_grade)

To use the Auvik nuget package:

## Visual Studio

1.	Open your project in Visual Studio
2.  Right-click on the project and click "Manage Nuget packages"
3.  Find the package "Auvik.Api" - install the latest version
4.  Create an API key in your User Profile in Auvik
5.  Note your URL domain, username and API key.

## Example code

```csharp
using Auvik.Api;

namespace My.Project;

public static class Program
{
	public static async Task Main()
	{
		var auvikClient = new AuvikClient(
			new AuvikClientOptions
			{
				// Ensure that the "us3" part of the URI
				// matches your browser navigation bar
				Uri = new Uri("https://auvikapi.us3.my.auvik.com"),
				Username = "you@yourdomain.com",
				ApiKey = "YOUR API KEY GOES HERE"
			}
		);

		await auvikClient
			.Credentials
			.VerifyCredentials();
	}
}
```

## API Documentation

The Auvik API documentation can be found here:

-	[Auvik API documentation](https://auvikapi.us1.my.auvik.com/docs)
