# AtlantisForProxyman.Net
[Proxyman](https://proxyman.io/) is a fantastic tool for intercepting and manipulating network traffic.

AtlantisForProxyman.Net is a dotnet binding to the fantastic [Atlantis library for Proxyman](https://github.com/ProxymanApp/atlantis). This library makes it ridiculously easy to intercept and view all network traffic to/from your app without mucking about with HTTPS certificates and proxy settings.

## Configuration

1) Add the AtlantisForProxyman.Net nuget to your .Net for iOS application project.
2) Add the following lines to your Info.plist:
    ```
   <key>NSLocalNetworkUsageDescription</key><string>Atlantis would use Bonjour Service to discover Proxyman app from your local network.</string>
   <key>NSBonjourServices</key>
   <array>
   <string>_Proxyman._tcp</string>
   </array>
   ```
3) Start Atlantis in your AppDelegate:

   ```
   #if DEBUG
   Atlantis.Start()
   #endif
   ```

## Caveats
Atlantis for Proxyman uses [method swizzling](https://nshipster.com/method-swizzling/) of the native NSURLSession calls, so AtlantisForProxyman.Net will only work with your dotnet project if it uses native network calls.

You therefore need to either:
1) set the "HttpClient Default Handler" in your project settings to use the "NSURLSession" implementation (and only construct the HttpClient with the default constructor), or 
2) use a HttpMessageHandler that inherits from NSUrlSessionHandler when constructing your HttpClient.