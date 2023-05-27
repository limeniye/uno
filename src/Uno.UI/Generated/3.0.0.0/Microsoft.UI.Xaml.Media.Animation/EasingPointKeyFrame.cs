#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media.Animation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class EasingPointKeyFrame : global::Microsoft.UI.Xaml.Media.Animation.PointKeyFrame
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Media.Animation.EasingFunctionBase EasingFunction
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.Animation.EasingFunctionBase)this.GetValue(EasingFunctionProperty);
			}
			set
			{
				this.SetValue(EasingFunctionProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty EasingFunctionProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(EasingFunction), typeof(global::Microsoft.UI.Xaml.Media.Animation.EasingFunctionBase), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.EasingPointKeyFrame), 
			new Microsoft.UI.Xaml.FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.Animation.EasingFunctionBase)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public EasingPointKeyFrame() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.Animation.EasingPointKeyFrame", "EasingPointKeyFrame.EasingPointKeyFrame()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.EasingPointKeyFrame.EasingPointKeyFrame()
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.EasingPointKeyFrame.EasingFunction.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.EasingPointKeyFrame.EasingFunction.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.EasingPointKeyFrame.EasingFunctionProperty.get
	}
}
