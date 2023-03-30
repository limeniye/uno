#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Background
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SocketActivityTrigger : global::Windows.ApplicationModel.Background.IBackgroundTrigger
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsWakeFromLowPowerSupported
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool SocketActivityTrigger.IsWakeFromLowPowerSupported is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20SocketActivityTrigger.IsWakeFromLowPowerSupported");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public SocketActivityTrigger() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Background.SocketActivityTrigger", "SocketActivityTrigger.SocketActivityTrigger()");
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Background.SocketActivityTrigger.SocketActivityTrigger()
		// Forced skipping of method Windows.ApplicationModel.Background.SocketActivityTrigger.IsWakeFromLowPowerSupported.get
		// Processing: Windows.ApplicationModel.Background.IBackgroundTrigger
	}
}
