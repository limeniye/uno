#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.Preview
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TwoPanelHingedDevicePosturePreviewReadingChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.System.Preview.TwoPanelHingedDevicePosturePreviewReading Reading
		{
			get
			{
				throw new global::System.NotImplementedException("The member TwoPanelHingedDevicePosturePreviewReading TwoPanelHingedDevicePosturePreviewReadingChangedEventArgs.Reading is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TwoPanelHingedDevicePosturePreviewReading%20TwoPanelHingedDevicePosturePreviewReadingChangedEventArgs.Reading");
			}
		}
		#endif
		// Forced skipping of method Windows.System.Preview.TwoPanelHingedDevicePosturePreviewReadingChangedEventArgs.Reading.get
	}
}
