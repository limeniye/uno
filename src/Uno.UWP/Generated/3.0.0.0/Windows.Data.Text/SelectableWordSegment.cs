#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Data.Text
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SelectableWordSegment 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Data.Text.TextSegment SourceTextSegment
		{
			get
			{
				throw new global::System.NotImplementedException("The member TextSegment SelectableWordSegment.SourceTextSegment is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TextSegment%20SelectableWordSegment.SourceTextSegment");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Text
		{
			get
			{
				throw new global::System.NotImplementedException("The member string SelectableWordSegment.Text is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20SelectableWordSegment.Text");
			}
		}
		#endif
		// Forced skipping of method Windows.Data.Text.SelectableWordSegment.Text.get
		// Forced skipping of method Windows.Data.Text.SelectableWordSegment.SourceTextSegment.get
	}
}
