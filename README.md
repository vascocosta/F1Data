Web app providing a simple and clean, yet comprehensive, interface to all sorts of Formula 1 data.

Developed as a SPA using [Blazor](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor), a free and open-source web framework from Microsoft that enables developers to create web apps using C# and HTML, leveraging web assemly, the future of the web.

# Features

* A great amount of F1 stats
* A simple and clean interface
* A desktop friendly interface
* A mobile friendly interface

# Dependencies

* .NET 6 SDK

# Build

```
git clone https://github.com/vascocosta/F1Data.git
cd F1Data
dotnet publish -c Release
```

# Deploy

Copy all the files under `F1Data/bin/Release/net6.0/publish/wwwroot/` to the webroot of any static http server.