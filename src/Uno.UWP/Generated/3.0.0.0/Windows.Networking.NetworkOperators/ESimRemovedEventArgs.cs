#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.NetworkOperators
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ESimRemovedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Networking.NetworkOperators.ESim ESim
		{
			get
			{
				throw new global::System.NotImplementedException("The member ESim ESimRemovedEventArgs.ESim is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ESim%20ESimRemovedEventArgs.ESim");
			}
		}
		#endif
		// Forced skipping of method Windows.Networking.NetworkOperators.ESimRemovedEventArgs.ESim.get
	}
}
