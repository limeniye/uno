#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Contacts
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ContactChange 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Contacts.ContactChangeType ChangeType
		{
			get
			{
				throw new global::System.NotImplementedException("The member ContactChangeType ContactChange.ChangeType is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ContactChangeType%20ContactChange.ChangeType");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Contacts.Contact Contact
		{
			get
			{
				throw new global::System.NotImplementedException("The member Contact ContactChange.Contact is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Contact%20ContactChange.Contact");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactChange.ChangeType.get
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactChange.Contact.get
	}
}
