#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Graphics.Imaging
{
	#if false || false || IS_UNIT_TESTS || __WASM__ || false || __NETSTD_REFERENCE__ || false
	[global::Uno.NotImplemented("IS_UNIT_TESTS", "__WASM__", "__NETSTD_REFERENCE__")]
	#endif
	public  partial class SoftwareBitmap : global::System.IDisposable
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double DpiY
		{
			get
			{
				throw new global::System.NotImplementedException("The member double SoftwareBitmap.DpiY is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=double%20SoftwareBitmap.DpiY");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Graphics.Imaging.SoftwareBitmap", "double SoftwareBitmap.DpiY");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double DpiX
		{
			get
			{
				throw new global::System.NotImplementedException("The member double SoftwareBitmap.DpiX is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=double%20SoftwareBitmap.DpiX");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Graphics.Imaging.SoftwareBitmap", "double SoftwareBitmap.DpiX");
			}
		}
		#endif
		#if false || false || IS_UNIT_TESTS || __WASM__ || false || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__WASM__", "__NETSTD_REFERENCE__")]
		public  global::Windows.Graphics.Imaging.BitmapAlphaMode BitmapAlphaMode
		{
			get
			{
				throw new global::System.NotImplementedException("The member BitmapAlphaMode SoftwareBitmap.BitmapAlphaMode is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=BitmapAlphaMode%20SoftwareBitmap.BitmapAlphaMode");
			}
		}
		#endif
		#if false || false || IS_UNIT_TESTS || __WASM__ || false || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__WASM__", "__NETSTD_REFERENCE__")]
		public  global::Windows.Graphics.Imaging.BitmapPixelFormat BitmapPixelFormat
		{
			get
			{
				throw new global::System.NotImplementedException("The member BitmapPixelFormat SoftwareBitmap.BitmapPixelFormat is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=BitmapPixelFormat%20SoftwareBitmap.BitmapPixelFormat");
			}
		}
		#endif
		#if false || false || IS_UNIT_TESTS || __WASM__ || false || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__WASM__", "__NETSTD_REFERENCE__")]
		public  bool IsReadOnly
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool SoftwareBitmap.IsReadOnly is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20SoftwareBitmap.IsReadOnly");
			}
		}
		#endif
		#if false || false || IS_UNIT_TESTS || __WASM__ || false || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__WASM__", "__NETSTD_REFERENCE__")]
		public  int PixelHeight
		{
			get
			{
				throw new global::System.NotImplementedException("The member int SoftwareBitmap.PixelHeight is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=int%20SoftwareBitmap.PixelHeight");
			}
		}
		#endif
		#if false || false || IS_UNIT_TESTS || __WASM__ || false || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__WASM__", "__NETSTD_REFERENCE__")]
		public  int PixelWidth
		{
			get
			{
				throw new global::System.NotImplementedException("The member int SoftwareBitmap.PixelWidth is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=int%20SoftwareBitmap.PixelWidth");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public SoftwareBitmap( global::Windows.Graphics.Imaging.BitmapPixelFormat format,  int width,  int height) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Graphics.Imaging.SoftwareBitmap", "SoftwareBitmap.SoftwareBitmap(BitmapPixelFormat format, int width, int height)");
		}
		#endif
		// Forced skipping of method Windows.Graphics.Imaging.SoftwareBitmap.SoftwareBitmap(Windows.Graphics.Imaging.BitmapPixelFormat, int, int)
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public SoftwareBitmap( global::Windows.Graphics.Imaging.BitmapPixelFormat format,  int width,  int height,  global::Windows.Graphics.Imaging.BitmapAlphaMode alpha) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Graphics.Imaging.SoftwareBitmap", "SoftwareBitmap.SoftwareBitmap(BitmapPixelFormat format, int width, int height, BitmapAlphaMode alpha)");
		}
		#endif
		// Forced skipping of method Windows.Graphics.Imaging.SoftwareBitmap.SoftwareBitmap(Windows.Graphics.Imaging.BitmapPixelFormat, int, int, Windows.Graphics.Imaging.BitmapAlphaMode)
		// Forced skipping of method Windows.Graphics.Imaging.SoftwareBitmap.BitmapPixelFormat.get
		// Forced skipping of method Windows.Graphics.Imaging.SoftwareBitmap.BitmapAlphaMode.get
		// Forced skipping of method Windows.Graphics.Imaging.SoftwareBitmap.PixelWidth.get
		// Forced skipping of method Windows.Graphics.Imaging.SoftwareBitmap.PixelHeight.get
		// Forced skipping of method Windows.Graphics.Imaging.SoftwareBitmap.IsReadOnly.get
		// Forced skipping of method Windows.Graphics.Imaging.SoftwareBitmap.DpiX.set
		// Forced skipping of method Windows.Graphics.Imaging.SoftwareBitmap.DpiX.get
		// Forced skipping of method Windows.Graphics.Imaging.SoftwareBitmap.DpiY.set
		// Forced skipping of method Windows.Graphics.Imaging.SoftwareBitmap.DpiY.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Graphics.Imaging.BitmapBuffer LockBuffer( global::Windows.Graphics.Imaging.BitmapBufferAccessMode mode)
		{
			throw new global::System.NotImplementedException("The member BitmapBuffer SoftwareBitmap.LockBuffer(BitmapBufferAccessMode mode) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=BitmapBuffer%20SoftwareBitmap.LockBuffer%28BitmapBufferAccessMode%20mode%29");
		}
		#endif
		#if false || false || IS_UNIT_TESTS || __WASM__ || false || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__WASM__", "__NETSTD_REFERENCE__")]
		public  void CopyTo( global::Windows.Graphics.Imaging.SoftwareBitmap bitmap)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Graphics.Imaging.SoftwareBitmap", "void SoftwareBitmap.CopyTo(SoftwareBitmap bitmap)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void CopyFromBuffer( global::Windows.Storage.Streams.IBuffer buffer)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Graphics.Imaging.SoftwareBitmap", "void SoftwareBitmap.CopyFromBuffer(IBuffer buffer)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void CopyToBuffer( global::Windows.Storage.Streams.IBuffer buffer)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Graphics.Imaging.SoftwareBitmap", "void SoftwareBitmap.CopyToBuffer(IBuffer buffer)");
		}
		#endif
		#if false || false || IS_UNIT_TESTS || __WASM__ || false || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__WASM__", "__NETSTD_REFERENCE__")]
		public  global::Windows.Graphics.Imaging.SoftwareBitmap GetReadOnlyView()
		{
			throw new global::System.NotImplementedException("The member SoftwareBitmap SoftwareBitmap.GetReadOnlyView() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=SoftwareBitmap%20SoftwareBitmap.GetReadOnlyView%28%29");
		}
		#endif
		#if false || false || IS_UNIT_TESTS || __WASM__ || false || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__WASM__", "__NETSTD_REFERENCE__")]
		public  void Dispose()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Graphics.Imaging.SoftwareBitmap", "void SoftwareBitmap.Dispose()");
		}
		#endif
		#if false || false || IS_UNIT_TESTS || __WASM__ || false || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__WASM__", "__NETSTD_REFERENCE__")]
		public static global::Windows.Graphics.Imaging.SoftwareBitmap Copy( global::Windows.Graphics.Imaging.SoftwareBitmap source)
		{
			throw new global::System.NotImplementedException("The member SoftwareBitmap SoftwareBitmap.Copy(SoftwareBitmap source) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=SoftwareBitmap%20SoftwareBitmap.Copy%28SoftwareBitmap%20source%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Graphics.Imaging.SoftwareBitmap Convert( global::Windows.Graphics.Imaging.SoftwareBitmap source,  global::Windows.Graphics.Imaging.BitmapPixelFormat format)
		{
			throw new global::System.NotImplementedException("The member SoftwareBitmap SoftwareBitmap.Convert(SoftwareBitmap source, BitmapPixelFormat format) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=SoftwareBitmap%20SoftwareBitmap.Convert%28SoftwareBitmap%20source%2C%20BitmapPixelFormat%20format%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Graphics.Imaging.SoftwareBitmap Convert( global::Windows.Graphics.Imaging.SoftwareBitmap source,  global::Windows.Graphics.Imaging.BitmapPixelFormat format,  global::Windows.Graphics.Imaging.BitmapAlphaMode alpha)
		{
			throw new global::System.NotImplementedException("The member SoftwareBitmap SoftwareBitmap.Convert(SoftwareBitmap source, BitmapPixelFormat format, BitmapAlphaMode alpha) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=SoftwareBitmap%20SoftwareBitmap.Convert%28SoftwareBitmap%20source%2C%20BitmapPixelFormat%20format%2C%20BitmapAlphaMode%20alpha%29");
		}
		#endif
		#if false || false || IS_UNIT_TESTS || __WASM__ || false || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__WASM__", "__NETSTD_REFERENCE__")]
		public static global::Windows.Graphics.Imaging.SoftwareBitmap CreateCopyFromBuffer( global::Windows.Storage.Streams.IBuffer source,  global::Windows.Graphics.Imaging.BitmapPixelFormat format,  int width,  int height)
		{
			throw new global::System.NotImplementedException("The member SoftwareBitmap SoftwareBitmap.CreateCopyFromBuffer(IBuffer source, BitmapPixelFormat format, int width, int height) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=SoftwareBitmap%20SoftwareBitmap.CreateCopyFromBuffer%28IBuffer%20source%2C%20BitmapPixelFormat%20format%2C%20int%20width%2C%20int%20height%29");
		}
		#endif
		#if false || false || IS_UNIT_TESTS || __WASM__ || false || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__WASM__", "__NETSTD_REFERENCE__")]
		public static global::Windows.Graphics.Imaging.SoftwareBitmap CreateCopyFromBuffer( global::Windows.Storage.Streams.IBuffer source,  global::Windows.Graphics.Imaging.BitmapPixelFormat format,  int width,  int height,  global::Windows.Graphics.Imaging.BitmapAlphaMode alpha)
		{
			throw new global::System.NotImplementedException("The member SoftwareBitmap SoftwareBitmap.CreateCopyFromBuffer(IBuffer source, BitmapPixelFormat format, int width, int height, BitmapAlphaMode alpha) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=SoftwareBitmap%20SoftwareBitmap.CreateCopyFromBuffer%28IBuffer%20source%2C%20BitmapPixelFormat%20format%2C%20int%20width%2C%20int%20height%2C%20BitmapAlphaMode%20alpha%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Graphics.Imaging.SoftwareBitmap> CreateCopyFromSurfaceAsync( global::Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface surface)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<SoftwareBitmap> SoftwareBitmap.CreateCopyFromSurfaceAsync(IDirect3DSurface surface) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CSoftwareBitmap%3E%20SoftwareBitmap.CreateCopyFromSurfaceAsync%28IDirect3DSurface%20surface%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Graphics.Imaging.SoftwareBitmap> CreateCopyFromSurfaceAsync( global::Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface surface,  global::Windows.Graphics.Imaging.BitmapAlphaMode alpha)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<SoftwareBitmap> SoftwareBitmap.CreateCopyFromSurfaceAsync(IDirect3DSurface surface, BitmapAlphaMode alpha) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CSoftwareBitmap%3E%20SoftwareBitmap.CreateCopyFromSurfaceAsync%28IDirect3DSurface%20surface%2C%20BitmapAlphaMode%20alpha%29");
		}
		#endif
		// Processing: System.IDisposable
	}
}
