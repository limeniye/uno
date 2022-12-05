#nullable enable

using Windows.UI.Xaml.Automation.Peers;

namespace Windows.UI.Xaml.Automation.Provider;

/// <summary>
/// Provides methods and properties that expose basic information about a UI element.
/// IRawElementProviderSimple is a Windows Runtime class, not an interface.
/// </summary>
public partial class IRawElementProviderSimple : DependencyObject
{
	internal IRawElementProviderSimple()
	{
	}

	internal IRawElementProviderSimple(AutomationPeer automationPeer) =>
		AutomationPeer = automationPeer;

	internal AutomationPeer? AutomationPeer { get; set; }
}
