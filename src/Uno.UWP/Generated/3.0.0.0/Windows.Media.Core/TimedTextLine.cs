#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Core
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TimedTextLine 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Text
		{
			get
			{
				throw new global::System.NotImplementedException("The member string TimedTextLine.Text is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20TimedTextLine.Text");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Core.TimedTextLine", "string TimedTextLine.Text");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<global::Windows.Media.Core.TimedTextSubformat> Subformats
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<TimedTextSubformat> TimedTextLine.Subformats is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IList%3CTimedTextSubformat%3E%20TimedTextLine.Subformats");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public TimedTextLine() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Core.TimedTextLine", "TimedTextLine.TimedTextLine()");
		}
		#endif
		// Forced skipping of method Windows.Media.Core.TimedTextLine.TimedTextLine()
		// Forced skipping of method Windows.Media.Core.TimedTextLine.Text.get
		// Forced skipping of method Windows.Media.Core.TimedTextLine.Text.set
		// Forced skipping of method Windows.Media.Core.TimedTextLine.Subformats.get
	}
}
