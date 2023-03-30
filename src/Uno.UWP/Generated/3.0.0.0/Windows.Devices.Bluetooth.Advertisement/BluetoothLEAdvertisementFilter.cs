#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Bluetooth.Advertisement
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class BluetoothLEAdvertisementFilter 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisement Advertisement
		{
			get
			{
				throw new global::System.NotImplementedException("The member BluetoothLEAdvertisement BluetoothLEAdvertisementFilter.Advertisement is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=BluetoothLEAdvertisement%20BluetoothLEAdvertisementFilter.Advertisement");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementFilter", "BluetoothLEAdvertisement BluetoothLEAdvertisementFilter.Advertisement");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<global::Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementBytePattern> BytePatterns
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<BluetoothLEAdvertisementBytePattern> BluetoothLEAdvertisementFilter.BytePatterns is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IList%3CBluetoothLEAdvertisementBytePattern%3E%20BluetoothLEAdvertisementFilter.BytePatterns");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public BluetoothLEAdvertisementFilter() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementFilter", "BluetoothLEAdvertisementFilter.BluetoothLEAdvertisementFilter()");
		}
		#endif
		// Forced skipping of method Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementFilter.BluetoothLEAdvertisementFilter()
		// Forced skipping of method Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementFilter.Advertisement.get
		// Forced skipping of method Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementFilter.Advertisement.set
		// Forced skipping of method Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementFilter.BytePatterns.get
	}
}
