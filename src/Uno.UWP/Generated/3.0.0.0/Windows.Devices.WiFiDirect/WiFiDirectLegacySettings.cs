#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.WiFiDirect
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WiFiDirectLegacySettings 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Ssid
		{
			get
			{
				throw new global::System.NotImplementedException("The member string WiFiDirectLegacySettings.Ssid is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20WiFiDirectLegacySettings.Ssid");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.WiFiDirect.WiFiDirectLegacySettings", "string WiFiDirectLegacySettings.Ssid");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Security.Credentials.PasswordCredential Passphrase
		{
			get
			{
				throw new global::System.NotImplementedException("The member PasswordCredential WiFiDirectLegacySettings.Passphrase is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=PasswordCredential%20WiFiDirectLegacySettings.Passphrase");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.WiFiDirect.WiFiDirectLegacySettings", "PasswordCredential WiFiDirectLegacySettings.Passphrase");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsEnabled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool WiFiDirectLegacySettings.IsEnabled is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20WiFiDirectLegacySettings.IsEnabled");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.WiFiDirect.WiFiDirectLegacySettings", "bool WiFiDirectLegacySettings.IsEnabled");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.WiFiDirect.WiFiDirectLegacySettings.IsEnabled.get
		// Forced skipping of method Windows.Devices.WiFiDirect.WiFiDirectLegacySettings.IsEnabled.set
		// Forced skipping of method Windows.Devices.WiFiDirect.WiFiDirectLegacySettings.Ssid.get
		// Forced skipping of method Windows.Devices.WiFiDirect.WiFiDirectLegacySettings.Ssid.set
		// Forced skipping of method Windows.Devices.WiFiDirect.WiFiDirectLegacySettings.Passphrase.get
		// Forced skipping of method Windows.Devices.WiFiDirect.WiFiDirectLegacySettings.Passphrase.set
	}
}
