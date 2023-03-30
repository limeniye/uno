#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Perception
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PerceptionTimestamp 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.TimeSpan PredictionAmount
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan PerceptionTimestamp.PredictionAmount is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TimeSpan%20PerceptionTimestamp.PredictionAmount");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.DateTimeOffset TargetTime
		{
			get
			{
				throw new global::System.NotImplementedException("The member DateTimeOffset PerceptionTimestamp.TargetTime is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=DateTimeOffset%20PerceptionTimestamp.TargetTime");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.TimeSpan SystemRelativeTargetTime
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan PerceptionTimestamp.SystemRelativeTargetTime is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TimeSpan%20PerceptionTimestamp.SystemRelativeTargetTime");
			}
		}
		#endif
		// Forced skipping of method Windows.Perception.PerceptionTimestamp.TargetTime.get
		// Forced skipping of method Windows.Perception.PerceptionTimestamp.PredictionAmount.get
		// Forced skipping of method Windows.Perception.PerceptionTimestamp.SystemRelativeTargetTime.get
	}
}
