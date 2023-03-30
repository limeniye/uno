#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Perception.Spatial
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public static partial class SpatialAnchorTransferManager 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyDictionary<string, global::Windows.Perception.Spatial.SpatialAnchor>> TryImportAnchorsAsync( global::Windows.Storage.Streams.IInputStream stream)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyDictionary<string, SpatialAnchor>> SpatialAnchorTransferManager.TryImportAnchorsAsync(IInputStream stream) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIReadOnlyDictionary%3Cstring%2C%20SpatialAnchor%3E%3E%20SpatialAnchorTransferManager.TryImportAnchorsAsync%28IInputStream%20stream%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<bool> TryExportAnchorsAsync( global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, global::Windows.Perception.Spatial.SpatialAnchor>> anchors,  global::Windows.Storage.Streams.IOutputStream stream)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> SpatialAnchorTransferManager.TryExportAnchorsAsync(IEnumerable<KeyValuePair<string, SpatialAnchor>> anchors, IOutputStream stream) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3Cbool%3E%20SpatialAnchorTransferManager.TryExportAnchorsAsync%28IEnumerable%3CKeyValuePair%3Cstring%2C%20SpatialAnchor%3E%3E%20anchors%2C%20IOutputStream%20stream%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Perception.Spatial.SpatialPerceptionAccessStatus> RequestAccessAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<SpatialPerceptionAccessStatus> SpatialAnchorTransferManager.RequestAccessAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CSpatialPerceptionAccessStatus%3E%20SpatialAnchorTransferManager.RequestAccessAsync%28%29");
		}
		#endif
	}
}
