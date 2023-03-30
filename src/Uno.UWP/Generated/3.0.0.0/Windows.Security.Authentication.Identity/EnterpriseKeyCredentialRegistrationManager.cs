#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Security.Authentication.Identity
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class EnterpriseKeyCredentialRegistrationManager 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Security.Authentication.Identity.EnterpriseKeyCredentialRegistrationManager Current
		{
			get
			{
				throw new global::System.NotImplementedException("The member EnterpriseKeyCredentialRegistrationManager EnterpriseKeyCredentialRegistrationManager.Current is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=EnterpriseKeyCredentialRegistrationManager%20EnterpriseKeyCredentialRegistrationManager.Current");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.Security.Authentication.Identity.EnterpriseKeyCredentialRegistrationInfo>> GetRegistrationsAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<EnterpriseKeyCredentialRegistrationInfo>> EnterpriseKeyCredentialRegistrationManager.GetRegistrationsAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIReadOnlyList%3CEnterpriseKeyCredentialRegistrationInfo%3E%3E%20EnterpriseKeyCredentialRegistrationManager.GetRegistrationsAsync%28%29");
		}
		#endif
		// Forced skipping of method Windows.Security.Authentication.Identity.EnterpriseKeyCredentialRegistrationManager.Current.get
	}
}
