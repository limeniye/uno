#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionMaskBrush : global::Windows.UI.Composition.CompositionBrush
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Composition.CompositionBrush Source
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionBrush CompositionMaskBrush.Source is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=CompositionBrush%20CompositionMaskBrush.Source");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionMaskBrush", "CompositionBrush CompositionMaskBrush.Source");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Composition.CompositionBrush Mask
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionBrush CompositionMaskBrush.Mask is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=CompositionBrush%20CompositionMaskBrush.Mask");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionMaskBrush", "CompositionBrush CompositionMaskBrush.Mask");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.CompositionMaskBrush.Mask.get
		// Forced skipping of method Windows.UI.Composition.CompositionMaskBrush.Mask.set
		// Forced skipping of method Windows.UI.Composition.CompositionMaskBrush.Source.get
		// Forced skipping of method Windows.UI.Composition.CompositionMaskBrush.Source.set
	}
}
