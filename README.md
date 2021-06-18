# C-Sharp-Slack-Integration

Enables sending messages as a Slack Bot in-line.

 - [Usage](#Usage)
 - [Building](#Building)
 - [Using a different Framework](#Using-a-different-Framework)
 - [I am a Noob (Contribute)](#Contribute)

## Usage

### Adding the Reference

Grab a DLL, whether it is a precompiled one found in [releases](https://github.com/ethanavatar/C-Sharp-Slack-Integration/releases) or one built manually.

You can add the module to your project in Visual Studio by right-clicking on the `References` in the solution explorer, clicking `Add Reference`, and adding a new reference to `SlackIntegration.dll` where you have it stored.

### Using the Module


```cs
using SlackIntegration;

namespace Example
{
    public class ExampleClass
    {
		// Create a new, empty SlackBot 
        readonly SlackBot TestBot = new SlackBot();
		
		// Store the webhooks URL that your Slack Bot uses to interface with a workspace channel
        readonly string ChannelURL = "https://hooks.slack.com/services/Your/Web-Hooks-URL";

        public void Main()
        {
            // int Slackbot.Send(string url, string data) -> int statuscode
            Bot.Send(ChannelURL, "Hello World!");
        }
    }
}
```

## Building

First, clone the source then navigate into it.
```bash
clone https://github.com/ethanavatar/C-Sharp-Slack-Integration.git
cd C-Sharp-Slack-Integration
```

Then build using:

```bash
dotnet build
```

Then dll will be stored in `bin/Debug/<framework>/SlackIntegration.dll`
## Using a different Framework

The provided [precompiled versions](https://github.com/ethanavatar/C-Sharp-Slack-Integration/releases) are built using `.NET Standard 2.0` which should work in most cases nowadays. However, it may not work if your project is targeting a version of `.NET Standard` or `.NET Core` older than `2.0`, or `.NET Framework` older than `4.6.1` (among others that havent been tested). In these cases you can build using a different target framework. 

Open the `SlackIntegration.csproj` file and change the value of `<TargetFramework>` from `netstandard2.0` to a different valid framework version. See [here for a list of valid framework versions](https://docs.microsoft.com/en-us/dotnet/standard/frameworks). **Not all versions within the previously stated "rule of thumb" have been tested. Some may require modifications and/or external toolkits in order to build properly.**

For example, to build using `.NET Framework 4.7.1`, `SlackIntegration.csproj` should look like this:

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net471</TargetFramework>
  </PropertyGroup>

</Project>
```

## Contribute

I am extremely new to C-Sharp so contributions are greatly appreciated, as I will likely learn a lot from any critisism there might be. This is barely what you'd call a project, but I will try to make it as easy and useful as possible in the name of experience, and every piece of input counts.