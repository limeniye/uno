#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Input.Core
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RadialControllerIndependentInputSource 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Input.RadialController Controller
		{
			get
			{
				throw new global::System.NotImplementedException("The member RadialController RadialControllerIndependentInputSource.Controller is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=RadialController%20RadialControllerIndependentInputSource.Controller");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Core.CoreDispatcher Dispatcher
		{
			get
			{
				throw new global::System.NotImplementedException("The member CoreDispatcher RadialControllerIndependentInputSource.Dispatcher is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=CoreDispatcher%20RadialControllerIndependentInputSource.Dispatcher");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.System.DispatcherQueue DispatcherQueue
		{
			get
			{
				throw new global::System.NotImplementedException("The member DispatcherQueue RadialControllerIndependentInputSource.DispatcherQueue is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=DispatcherQueue%20RadialControllerIndependentInputSource.DispatcherQueue");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Input.Core.RadialControllerIndependentInputSource.Controller.get
		// Forced skipping of method Windows.UI.Input.Core.RadialControllerIndependentInputSource.Dispatcher.get
		// Forced skipping of method Windows.UI.Input.Core.RadialControllerIndependentInputSource.DispatcherQueue.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Input.Core.RadialControllerIndependentInputSource CreateForView( global::Windows.ApplicationModel.Core.CoreApplicationView view)
		{
			throw new global::System.NotImplementedException("The member RadialControllerIndependentInputSource RadialControllerIndependentInputSource.CreateForView(CoreApplicationView view) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=RadialControllerIndependentInputSource%20RadialControllerIndependentInputSource.CreateForView%28CoreApplicationView%20view%29");
		}
		#endif
	}
}
