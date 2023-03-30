#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RatingItemFontInfo : global::Windows.UI.Xaml.Controls.RatingItemInfo
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string UnsetGlyph
		{
			get
			{
				return (string)this.GetValue(UnsetGlyphProperty);
			}
			set
			{
				this.SetValue(UnsetGlyphProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string PointerOverPlaceholderGlyph
		{
			get
			{
				return (string)this.GetValue(PointerOverPlaceholderGlyphProperty);
			}
			set
			{
				this.SetValue(PointerOverPlaceholderGlyphProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string PointerOverGlyph
		{
			get
			{
				return (string)this.GetValue(PointerOverGlyphProperty);
			}
			set
			{
				this.SetValue(PointerOverGlyphProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string PlaceholderGlyph
		{
			get
			{
				return (string)this.GetValue(PlaceholderGlyphProperty);
			}
			set
			{
				this.SetValue(PlaceholderGlyphProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Glyph
		{
			get
			{
				return (string)this.GetValue(GlyphProperty);
			}
			set
			{
				this.SetValue(GlyphProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string DisabledGlyph
		{
			get
			{
				return (string)this.GetValue(DisabledGlyphProperty);
			}
			set
			{
				this.SetValue(DisabledGlyphProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty DisabledGlyphProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(DisabledGlyph), typeof(string), 
			typeof(global::Windows.UI.Xaml.Controls.RatingItemFontInfo), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty GlyphProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Glyph), typeof(string), 
			typeof(global::Windows.UI.Xaml.Controls.RatingItemFontInfo), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty PlaceholderGlyphProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(PlaceholderGlyph), typeof(string), 
			typeof(global::Windows.UI.Xaml.Controls.RatingItemFontInfo), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty PointerOverGlyphProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(PointerOverGlyph), typeof(string), 
			typeof(global::Windows.UI.Xaml.Controls.RatingItemFontInfo), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty PointerOverPlaceholderGlyphProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(PointerOverPlaceholderGlyph), typeof(string), 
			typeof(global::Windows.UI.Xaml.Controls.RatingItemFontInfo), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty UnsetGlyphProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(UnsetGlyph), typeof(string), 
			typeof(global::Windows.UI.Xaml.Controls.RatingItemFontInfo), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public RatingItemFontInfo() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.RatingItemFontInfo", "RatingItemFontInfo.RatingItemFontInfo()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingItemFontInfo.RatingItemFontInfo()
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingItemFontInfo.DisabledGlyph.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingItemFontInfo.DisabledGlyph.set
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingItemFontInfo.Glyph.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingItemFontInfo.Glyph.set
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingItemFontInfo.PointerOverGlyph.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingItemFontInfo.PointerOverGlyph.set
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingItemFontInfo.PointerOverPlaceholderGlyph.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingItemFontInfo.PointerOverPlaceholderGlyph.set
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingItemFontInfo.PlaceholderGlyph.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingItemFontInfo.PlaceholderGlyph.set
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingItemFontInfo.UnsetGlyph.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingItemFontInfo.UnsetGlyph.set
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingItemFontInfo.DisabledGlyphProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingItemFontInfo.GlyphProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingItemFontInfo.PlaceholderGlyphProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingItemFontInfo.PointerOverGlyphProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingItemFontInfo.PointerOverPlaceholderGlyphProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingItemFontInfo.UnsetGlyphProperty.get
	}
}
