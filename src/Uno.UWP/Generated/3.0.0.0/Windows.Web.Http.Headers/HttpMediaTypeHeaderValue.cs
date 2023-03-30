#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Web.Http.Headers
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class HttpMediaTypeHeaderValue : global::Windows.Foundation.IStringable
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string MediaType
		{
			get
			{
				throw new global::System.NotImplementedException("The member string HttpMediaTypeHeaderValue.MediaType is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20HttpMediaTypeHeaderValue.MediaType");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Web.Http.Headers.HttpMediaTypeHeaderValue", "string HttpMediaTypeHeaderValue.MediaType");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string CharSet
		{
			get
			{
				throw new global::System.NotImplementedException("The member string HttpMediaTypeHeaderValue.CharSet is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20HttpMediaTypeHeaderValue.CharSet");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Web.Http.Headers.HttpMediaTypeHeaderValue", "string HttpMediaTypeHeaderValue.CharSet");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<global::Windows.Web.Http.Headers.HttpNameValueHeaderValue> Parameters
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<HttpNameValueHeaderValue> HttpMediaTypeHeaderValue.Parameters is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IList%3CHttpNameValueHeaderValue%3E%20HttpMediaTypeHeaderValue.Parameters");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public HttpMediaTypeHeaderValue( string mediaType) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Web.Http.Headers.HttpMediaTypeHeaderValue", "HttpMediaTypeHeaderValue.HttpMediaTypeHeaderValue(string mediaType)");
		}
		#endif
		// Forced skipping of method Windows.Web.Http.Headers.HttpMediaTypeHeaderValue.HttpMediaTypeHeaderValue(string)
		// Forced skipping of method Windows.Web.Http.Headers.HttpMediaTypeHeaderValue.CharSet.get
		// Forced skipping of method Windows.Web.Http.Headers.HttpMediaTypeHeaderValue.CharSet.set
		// Forced skipping of method Windows.Web.Http.Headers.HttpMediaTypeHeaderValue.MediaType.get
		// Forced skipping of method Windows.Web.Http.Headers.HttpMediaTypeHeaderValue.MediaType.set
		// Forced skipping of method Windows.Web.Http.Headers.HttpMediaTypeHeaderValue.Parameters.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public override string ToString()
		{
			throw new global::System.NotImplementedException("The member string HttpMediaTypeHeaderValue.ToString() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20HttpMediaTypeHeaderValue.ToString%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Web.Http.Headers.HttpMediaTypeHeaderValue Parse( string input)
		{
			throw new global::System.NotImplementedException("The member HttpMediaTypeHeaderValue HttpMediaTypeHeaderValue.Parse(string input) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=HttpMediaTypeHeaderValue%20HttpMediaTypeHeaderValue.Parse%28string%20input%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool TryParse( string input, out global::Windows.Web.Http.Headers.HttpMediaTypeHeaderValue mediaTypeHeaderValue)
		{
			throw new global::System.NotImplementedException("The member bool HttpMediaTypeHeaderValue.TryParse(string input, out HttpMediaTypeHeaderValue mediaTypeHeaderValue) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20HttpMediaTypeHeaderValue.TryParse%28string%20input%2C%20out%20HttpMediaTypeHeaderValue%20mediaTypeHeaderValue%29");
		}
		#endif
	}
}
