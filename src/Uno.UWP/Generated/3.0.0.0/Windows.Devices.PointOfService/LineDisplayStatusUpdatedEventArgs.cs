#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.PointOfService
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class LineDisplayStatusUpdatedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.PointOfService.LineDisplayPowerStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member LineDisplayPowerStatus LineDisplayStatusUpdatedEventArgs.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=LineDisplayPowerStatus%20LineDisplayStatusUpdatedEventArgs.Status");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.PointOfService.LineDisplayStatusUpdatedEventArgs.Status.get
	}
}
