#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Email.DataProvider
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class EmailMailboxEmptyFolderRequestEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Email.DataProvider.EmailMailboxEmptyFolderRequest Request
		{
			get
			{
				throw new global::System.NotImplementedException("The member EmailMailboxEmptyFolderRequest EmailMailboxEmptyFolderRequestEventArgs.Request is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=EmailMailboxEmptyFolderRequest%20EmailMailboxEmptyFolderRequestEventArgs.Request");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Email.DataProvider.EmailMailboxEmptyFolderRequestEventArgs.Request.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Deferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member Deferral EmailMailboxEmptyFolderRequestEventArgs.GetDeferral() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Deferral%20EmailMailboxEmptyFolderRequestEventArgs.GetDeferral%28%29");
		}
		#endif
	}
}
