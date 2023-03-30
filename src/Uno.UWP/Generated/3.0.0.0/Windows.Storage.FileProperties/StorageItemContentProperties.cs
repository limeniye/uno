#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage.FileProperties
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class StorageItemContentProperties : global::Windows.Storage.FileProperties.IStorageItemExtraProperties
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.FileProperties.MusicProperties> GetMusicPropertiesAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<MusicProperties> StorageItemContentProperties.GetMusicPropertiesAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CMusicProperties%3E%20StorageItemContentProperties.GetMusicPropertiesAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.FileProperties.VideoProperties> GetVideoPropertiesAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<VideoProperties> StorageItemContentProperties.GetVideoPropertiesAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CVideoProperties%3E%20StorageItemContentProperties.GetVideoPropertiesAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.FileProperties.ImageProperties> GetImagePropertiesAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ImageProperties> StorageItemContentProperties.GetImagePropertiesAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CImageProperties%3E%20StorageItemContentProperties.GetImagePropertiesAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.FileProperties.DocumentProperties> GetDocumentPropertiesAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<DocumentProperties> StorageItemContentProperties.GetDocumentPropertiesAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CDocumentProperties%3E%20StorageItemContentProperties.GetDocumentPropertiesAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IDictionary<string, object>> RetrievePropertiesAsync( global::System.Collections.Generic.IEnumerable<string> propertiesToRetrieve)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IDictionary<string, object>> StorageItemContentProperties.RetrievePropertiesAsync(IEnumerable<string> propertiesToRetrieve) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIDictionary%3Cstring%2C%20object%3E%3E%20StorageItemContentProperties.RetrievePropertiesAsync%28IEnumerable%3Cstring%3E%20propertiesToRetrieve%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction SavePropertiesAsync( global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>> propertiesToSave)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction StorageItemContentProperties.SavePropertiesAsync(IEnumerable<KeyValuePair<string, object>> propertiesToSave) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20StorageItemContentProperties.SavePropertiesAsync%28IEnumerable%3CKeyValuePair%3Cstring%2C%20object%3E%3E%20propertiesToSave%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction SavePropertiesAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction StorageItemContentProperties.SavePropertiesAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20StorageItemContentProperties.SavePropertiesAsync%28%29");
		}
		#endif
		// Processing: Windows.Storage.FileProperties.IStorageItemExtraProperties
	}
}
