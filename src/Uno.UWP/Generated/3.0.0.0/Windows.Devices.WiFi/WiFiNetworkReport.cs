#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.WiFi
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WiFiNetworkReport 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.Devices.WiFi.WiFiAvailableNetwork> AvailableNetworks
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<WiFiAvailableNetwork> WiFiNetworkReport.AvailableNetworks is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IReadOnlyList%3CWiFiAvailableNetwork%3E%20WiFiNetworkReport.AvailableNetworks");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.DateTimeOffset Timestamp
		{
			get
			{
				throw new global::System.NotImplementedException("The member DateTimeOffset WiFiNetworkReport.Timestamp is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=DateTimeOffset%20WiFiNetworkReport.Timestamp");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.WiFi.WiFiNetworkReport.Timestamp.get
		// Forced skipping of method Windows.Devices.WiFi.WiFiNetworkReport.AvailableNetworks.get
	}
}
