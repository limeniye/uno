#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Interactions
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InteractionTrackerInteractingStateEnteredArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int RequestId
		{
			get
			{
				throw new global::System.NotImplementedException("The member int InteractionTrackerInteractingStateEnteredArgs.RequestId is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=int%20InteractionTrackerInteractingStateEnteredArgs.RequestId");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsFromBinding
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool InteractionTrackerInteractingStateEnteredArgs.IsFromBinding is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20InteractionTrackerInteractingStateEnteredArgs.IsFromBinding");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Interactions.InteractionTrackerInteractingStateEnteredArgs.RequestId.get
		// Forced skipping of method Microsoft.UI.Composition.Interactions.InteractionTrackerInteractingStateEnteredArgs.IsFromBinding.get
	}
}
