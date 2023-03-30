#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Wallet
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WalletItemStore 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction AddAsync( string id,  global::Windows.ApplicationModel.Wallet.WalletItem item)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction WalletItemStore.AddAsync(string id, WalletItem item) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20WalletItemStore.AddAsync%28string%20id%2C%20WalletItem%20item%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction ClearAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction WalletItemStore.ClearAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20WalletItemStore.ClearAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Wallet.WalletItem> GetWalletItemAsync( string id)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<WalletItem> WalletItemStore.GetWalletItemAsync(string id) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CWalletItem%3E%20WalletItemStore.GetWalletItemAsync%28string%20id%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Wallet.WalletItem>> GetItemsAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<WalletItem>> WalletItemStore.GetItemsAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIReadOnlyList%3CWalletItem%3E%3E%20WalletItemStore.GetItemsAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Wallet.WalletItem>> GetItemsAsync( global::Windows.ApplicationModel.Wallet.WalletItemKind kind)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<WalletItem>> WalletItemStore.GetItemsAsync(WalletItemKind kind) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIReadOnlyList%3CWalletItem%3E%3E%20WalletItemStore.GetItemsAsync%28WalletItemKind%20kind%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Wallet.WalletItem> ImportItemAsync( global::Windows.Storage.Streams.IRandomAccessStreamReference stream)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<WalletItem> WalletItemStore.ImportItemAsync(IRandomAccessStreamReference stream) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CWalletItem%3E%20WalletItemStore.ImportItemAsync%28IRandomAccessStreamReference%20stream%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction DeleteAsync( string id)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction WalletItemStore.DeleteAsync(string id) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20WalletItemStore.DeleteAsync%28string%20id%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction ShowAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction WalletItemStore.ShowAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20WalletItemStore.ShowAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction ShowAsync( string id)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction WalletItemStore.ShowAsync(string id) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20WalletItemStore.ShowAsync%28string%20id%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction UpdateAsync( global::Windows.ApplicationModel.Wallet.WalletItem item)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction WalletItemStore.UpdateAsync(WalletItem item) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20WalletItemStore.UpdateAsync%28WalletItem%20item%29");
		}
		#endif
	}
}
