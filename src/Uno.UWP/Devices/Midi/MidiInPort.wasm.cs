﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using Uno;
using Uno.Devices.Enumeration.Internal;
using Uno.Devices.Midi.Internal;
using Uno.Foundation;

using NativeMethods = __Windows.Devices.Midi.MidiInPort.NativeMethods;

namespace Windows.Devices.Midi
{
	public partial class MidiInPort
	{
		private readonly string _managedId;

		private readonly static ConcurrentDictionary<string, MidiInPort> _instanceSubscriptions =
			new ConcurrentDictionary<string, MidiInPort>();

		private MidiInPort(string deviceId, string managedId)
		{
			DeviceId = deviceId;
			_managedId = managedId;
		}

		partial void StartMessageReceived()
		{
			_instanceSubscriptions.TryAdd(_managedId, this);

			NativeMethods.StartMessageListener(_managedId);
		}

		partial void StopMessageReceived()
		{
			_instanceSubscriptions.TryRemove(_managedId, out _);

			NativeMethods.StopMessageListener(_managedId);
		}

		[JSExport]
		public static int DispatchMessage(string managedId, string serializedMessage, double timestamp)
		{
#if DEBUG
			Debug.WriteLine($"Message arrived {managedId}, {serializedMessage}, {timestamp}");
#endif
			if (serializedMessage is null)
			{
				throw new ArgumentNullException(nameof(serializedMessage));
			}

			if (!_instanceSubscriptions.TryGetValue(managedId, out var port))
			{
				throw new InvalidOperationException("This instance is not listening to MIDI input.");
			}

			var managedTimestamp = TimeSpan.FromMilliseconds(timestamp);

			var splitMessage = serializedMessage.Split(':');

			var message = new byte[splitMessage.Length];
			for (int i = 0; i < splitMessage.Length; i++)
			{
				message[i] = byte.Parse(splitMessage[i], CultureInfo.InvariantCulture);
			}

			port.OnMessageReceived(message, 0, message.Length, managedTimestamp);

			return 0;
		}

		partial void DisposeNative()
		{
			NativeMethods.RemovePort(_managedId);
		}

		private static async Task<MidiInPort> FromIdInternalAsync(DeviceIdentifier identifier)
		{
			if (!await WasmMidiAccess.RequestAsync())
			{
				throw new UnauthorizedAccessException("User declined access to MIDI.");
			}
			var managedId = Guid.NewGuid().ToString();

			NativeMethods.CreatePort(managedId, Uri.EscapeDataString(identifier.Id));

			return new MidiInPort(identifier.ToString(), managedId);
		}
	}
}
