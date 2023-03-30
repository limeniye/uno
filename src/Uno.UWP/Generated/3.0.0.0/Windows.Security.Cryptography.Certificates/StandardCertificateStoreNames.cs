#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Security.Cryptography.Certificates
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public static partial class StandardCertificateStoreNames 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string IntermediateCertificationAuthorities
		{
			get
			{
				throw new global::System.NotImplementedException("The member string StandardCertificateStoreNames.IntermediateCertificationAuthorities is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20StandardCertificateStoreNames.IntermediateCertificationAuthorities");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string Personal
		{
			get
			{
				throw new global::System.NotImplementedException("The member string StandardCertificateStoreNames.Personal is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20StandardCertificateStoreNames.Personal");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string TrustedRootCertificationAuthorities
		{
			get
			{
				throw new global::System.NotImplementedException("The member string StandardCertificateStoreNames.TrustedRootCertificationAuthorities is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20StandardCertificateStoreNames.TrustedRootCertificationAuthorities");
			}
		}
		#endif
		// Forced skipping of method Windows.Security.Cryptography.Certificates.StandardCertificateStoreNames.Personal.get
		// Forced skipping of method Windows.Security.Cryptography.Certificates.StandardCertificateStoreNames.TrustedRootCertificationAuthorities.get
		// Forced skipping of method Windows.Security.Cryptography.Certificates.StandardCertificateStoreNames.IntermediateCertificationAuthorities.get
	}
}
