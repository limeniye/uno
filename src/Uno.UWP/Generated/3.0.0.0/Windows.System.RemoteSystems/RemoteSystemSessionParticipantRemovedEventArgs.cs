#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.RemoteSystems
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RemoteSystemSessionParticipantRemovedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.System.RemoteSystems.RemoteSystemSessionParticipant Participant
		{
			get
			{
				throw new global::System.NotImplementedException("The member RemoteSystemSessionParticipant RemoteSystemSessionParticipantRemovedEventArgs.Participant is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=RemoteSystemSessionParticipant%20RemoteSystemSessionParticipantRemovedEventArgs.Participant");
			}
		}
		#endif
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemSessionParticipantRemovedEventArgs.Participant.get
	}
}
