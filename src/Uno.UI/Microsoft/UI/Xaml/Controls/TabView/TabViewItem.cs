﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.
// MUX Reference: TabViewItem.cpp, commit 367bb0d512c

using System.Numerics;
using Microsoft.UI.Xaml.Automation.Peers;
using Uno.UI.Helpers.WinUI;
using Windows.System;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Automation;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.Foundation;
using Windows.UI.Xaml.Markup;
using Windows.Graphics.Display;
using Windows.UI.Xaml.Shapes;
using System;

#if HAS_UNO_WINUI
using Microsoft.UI.Input;
#else
using Windows.UI.Xaml.Automation.Peers;
using Windows.Devices.Input;
using Windows.UI.Input;
#endif

namespace Microsoft.UI.Xaml.Controls;

/// <summary>
/// Represents a single tab within a TabView.
/// </summary>
public partial class TabViewItem : ListViewItem
{
	private const string c_overlayCornerRadiusKey = "OverlayCornerRadius";
	private const int c_targetRectWidthIncrement = 2;

	/// <summary>
	/// Initializes a new instance of the TabViewItem class.
	/// </summary>
	public TabViewItem()
	{
		m_dispatcherHelper = new(this);
		//__RP_Marker_ClassById(RuntimeProfiler.ProfId_TabViewItem);

		DefaultStyleKey = typeof(TabViewItem);

		SetValue(TabViewTemplateSettingsProperty, new TabViewItemTemplateSettings());

		Loaded += OnLoaded;

		SizeChanged += OnSizeChanged;

		RegisterPropertyChangedCallback(SelectorItem.IsSelectedProperty, OnIsSelectedPropertyChanged);
		RegisterPropertyChangedCallback(Control.ForegroundProperty, OnForegroundPropertyChanged);
	}

	protected override void OnApplyTemplate()
	{
		base.OnApplyTemplate();

		m_selectedBackgroundPathSizeChangedRevoker.Disposable = null;
		m_closeButtonClickRevoker.Disposable = null;
		m_tabDragStartingRevoker.Disposable = null;
		m_tabDragCompletedRevoker.Disposable = null;

		if (SharedHelpers.Is19H1OrHigher()) // UIElement.ActualOffset introduced in Win10 1903.
		{
			m_selectedBackgroundPath = GetTemplateChild<Path>("SelectedBackgroundPath");

			if (m_selectedBackgroundPath is { } selectedBackgroundPath)
			{
				m_selectedBackgroundPathSizeChangedRevoker = selectedBackgroundPath.SizeChanged(winrt::auto_revoke,

			{
					[this](auto const&, auto const&)
                {
						UpdateSelectedBackgroundPathTranslateTransform();
					}
				});
			}
		}

		m_headerContentPresenter = GetTemplateChild<ContentPresenter>("ContentPresenter");

		var tabView = SharedHelpers.GetAncestorOfType<TabView>(VisualTreeHelper.GetParent(this));
		var internalTabView = tabView ?? null;

		Button GetCloseButton(TabView internalTabView)
		{
			var closeButton = (Button)GetTemplateChild("CloseButton");
			if (closeButton != null)
			{
				// Do localization for the close button automation name
				if (string.IsNullOrEmpty(AutomationProperties.GetName(closeButton)))
				{
					var closeButtonName = ResourceAccessor.GetLocalizedStringResource(ResourceAccessor.SR_TabViewCloseButtonName);
					AutomationProperties.SetName(closeButton, closeButtonName);
				}

				if (internalTabView != null)
				{
					// Setup the tooltip for the close button
					var tooltip = new ToolTip();
					tooltip.Content = internalTabView.GetTabCloseButtonTooltipText();
					ToolTipService.SetToolTip(closeButton, tooltip);
				}

				closeButton.Click += OnCloseButtonClick;
			}
			return closeButton;
		}
		m_closeButton = GetCloseButton(internalTabView);

		OnHeaderChanged();
		OnIconSourceChanged();

		if (tabView != null)
		{
			if (SharedHelpers.IsThemeShadowAvailable())
			{
				if (internalTabView != null)
				{
					var shadow = new ThemeShadow();
					if (!SharedHelpers.Is21H1OrHigher())
					{
						if (internalTabView.GetShadowReceiver() is { } shadowReceiver)
						{
							shadow.Receivers.Add(shadowReceiver);
						}
					}
					m_shadow = shadow;

					double shadowDepth = (double)SharedHelpers.FindInApplicationResources(TabView.c_tabViewShadowDepthName, TabView.c_tabShadowDepth);

					var currentTranslation = Translation;
					var translation = new Vector3(currentTranslation.X, currentTranslation.Y, (float)shadowDepth);
					Translation = translation;

					UpdateShadow();
				}
			}

			tabView.TabDragStarting += OnTabDragStarting;
			tabView.TabDragCompleted += OnTabDragCompleted;
		}

		UpdateCloseButton();
		UpdateForeground();
		UpdateWidthModeVisualState();
		UpdateTabGeometry();
	}

	private void UpdateTabGeometry()
	{
		var templateSettings = TabViewTemplateSettings;
		var scaleFactor = SharedHelpers.Is19H1OrHigher() ?
			XamlRoot.RasterizationScale :
			DisplayInformation.GetForCurrentView().RawPixelsPerViewPixel;
		var height = ActualHeight;
		var popupRadius = (CornerRadius)ResourceAccessor.ResourceLookup(this, c_overlayCornerRadiusKey);
		var leftCorner = popupRadius.TopLeft;
		var rightCorner = popupRadius.TopRight;

		// Assumes 4px curving-out corners, which are hardcoded in the markup
		var data = "<Geometry xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation'>F1 M0,%f  a 4,4 0 0 0 4,-4  L 4,%f  a %f,%f 0 0 1 %f,-%f  l %f,0  a %f,%f 0 0 1 %f,%f  l 0,%f  a 4,4 0 0 0 4,4 Z</Geometry>";

		//WCHAR strOut[1024];
		StringCchPrintf(strOut, ARRAYSIZE(strOut), data,
			height - 1.0f,
			leftCorner, leftCorner, leftCorner, leftCorner, leftCorner,
			ActualWidth - (leftCorner + rightCorner + 1.0f / scaleFactor),
			rightCorner, rightCorner, rightCorner, rightCorner,
			height - (5 + rightCorner));

		var geometry = XamlReader.Load(strOut) as Geometry;

		templateSettings.TabGeometry = geometry;
	}

	private void OnLoaded(object sender, RoutedEventArgs args)
	{
		if (GetParentTabView() is TabView tabView)
		{
			var internalTabView = tabView;
			var index = internalTabView.IndexFromContainer(this);
			internalTabView.SetTabSeparatorOpacity(index);
		}
	}

	private void OnSizeChanged(object sender, SizeChangedEventArgs args)
	{
		m_dispatcherHelper.RunAsync(() => UpdateTabGeometry());
		UpdateTabGeometry();
	}

	private void OnIsSelectedPropertyChanged(DependencyObject sender, DependencyProperty args)
	{
		var peer = FrameworkElementAutomationPeer.CreatePeerForElement(this);
		if (peer != null)
		{
			peer.RaiseAutomationEvent(AutomationEvents.SelectionItemPatternOnElementSelected);
		}

		if (IsSelected)
		{
			SetValue(Canvas.ZIndexProperty, 20);
			StartBringTabIntoView();
		}
		else
		{
			SetValue(Canvas.ZIndexProperty, 0);
		}

		UpdateShadow();
		UpdateWidthModeVisualState();

		UpdateCloseButton();
		UpdateForeground();
	}

	private void OnForegroundPropertyChanged(DependencyObject sender, DependencyProperty property)
	{
		UpdateForeground();
	}

	private void UpdateForeground()
	{
		// We only need to set the foreground state when the TabViewItem is in rest state and not selected.
		if (!IsSelected && !m_isPointerOver)
		{
			// If Foreground is set, then change icon and header foreground to match.
			VisualStateManager.GoToState(
				this,
				ReadLocalValue(ForegroundProperty) == DependencyProperty.UnsetValue ? "ForegroundNotSet" : "ForegroundSet",
				false /*useTransitions*/);
		}
	}

	private void UpdateShadow()
	{
		if (SharedHelpers.IsThemeShadowAvailable())
		// TODO Uno: Can't access XamlControlsResources from Uno.UI
		//&& !Microsoft.UI.Xaml.Controls.XamlControlsResources.IsUsingControlsResourcesVersion2)
		{
			if (IsSelected && !m_isDragging)
			{
				Shadow = (ThemeShadow)m_shadow;
			}
			else
			{
				Shadow = null;
			}
		}
	}

	private void UpdateSelectedBackgroundPathTranslateTransform()
	{
		MUX_ASSERT(SharedHelpers.Is19H1OrHigher());

		if (m_selectedBackgroundPath is { } selectedBackgroundPath)
		{
			var selectedBackgroundPathActualOffset = selectedBackgroundPath.ActualOffset;
			var roundedSelectedBackgroundPathActualOffsetY = Math.Round(selectedBackgroundPathActualOffset.Y);

			if (roundedSelectedBackgroundPathActualOffsetY > selectedBackgroundPathActualOffset.y)
			{
				// Move the SelectedBackgroundPath element down by a fraction of a pixel to avoid a faint gap line
				// between the selected TabViewItem and its content.
				TranslateTransform translateTransform = new();

				translateTransform.Y = roundedSelectedBackgroundPathActualOffsetY - selectedBackgroundPathActualOffset.y;

				selectedBackgroundPath.RenderTransform = translateTransform;
			}
			else if (selectedBackgroundPath.RenderTransform is not null)
			{
				// Reset any TranslateTransform that may have been set above.
				selectedBackgroundPath.RenderTransform = null;
			}
		}
	}

	private void OnTabDragStarting(object sender, TabViewTabDragStartingEventArgs args)
	{
		m_isDragging = true;
		UpdateShadow();
	}

	private void OnTabDragCompleted(object sender, TabViewTabDragCompletedEventArgs args)
	{
		m_isDragging = false;
		UpdateShadow();
		UpdateForeground();
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new TabViewItemAutomationPeer(this);
	}

	internal void OnCloseButtonOverlayModeChanged(TabViewCloseButtonOverlayMode mode)
	{
		m_closeButtonOverlayMode = mode;
		UpdateCloseButton();
	}

	internal TabView GetParentTabView()
	{
		return m_parentTabView;
	}

	internal void SetParentTabView(TabView tabView)
	{
		m_parentTabView = tabView;
	}

	internal void OnTabViewWidthModeChanged(TabViewWidthMode mode)
	{
		m_tabViewWidthMode = mode;
		UpdateWidthModeVisualState();
	}


	private void UpdateCloseButton()
	{
		if (!IsClosable)
		{
			VisualStateManager.GoToState(this, "CloseButtonCollapsed", false);
		}
		else
		{
			switch (m_closeButtonOverlayMode)
			{
				case TabViewCloseButtonOverlayMode.OnPointerOver:
					{
						// If we only want to show the button on hover, we also show it when we are selected, otherwise hide it
						if (IsSelected || m_isPointerOver)
						{
							VisualStateManager.GoToState(this, "CloseButtonVisible", false);
						}
						else
						{
							VisualStateManager.GoToState(this, "CloseButtonCollapsed", false);
						}
						break;
					}
				default:
					{
						// Default, use "Auto"
						VisualStateManager.GoToState(this, "CloseButtonVisible", false);
						break;
					}
			}
		}
	}

	private void UpdateWidthModeVisualState()
	{
		// Handling compact/non compact width mode
		if (!IsSelected && m_tabViewWidthMode == TabViewWidthMode.Compact)
		{
			VisualStateManager.GoToState(this, "Compact", false);
		}
		else
		{
			VisualStateManager.GoToState(this, "StandardWidth", false);
		}
	}

	private void RequestClose()
	{
		var tabView = SharedHelpers.GetAncestorOfType<TabView>(VisualTreeHelper.GetParent(this));
		if (tabView != null)
		{
			var internalTabView = tabView;
			if (internalTabView != null)
			{
				internalTabView.RequestCloseTab(this, false);
			}
		}
	}

	internal void RaiseRequestClose(TabViewTabCloseRequestedEventArgs args)
	{
		// This should only be called from TabView, to ensure that both this event and the TabView TabRequestedClose event are raised
		CloseRequested?.Invoke(this, args);
	}

	private void OnCloseButtonClick(object sender, RoutedEventArgs args)
	{
		RequestClose();
	}

	private void OnIsClosablePropertyChanged(DependencyPropertyChangedEventArgs args)
	{
		UpdateCloseButton();
	}


	private void OnHeaderPropertyChanged(DependencyPropertyChangedEventArgs args)
	{
		OnHeaderChanged();
	}

	private void OnHeaderChanged()
	{
		if (m_headerContentPresenter is { } headerContentPresenter)
		{
			headerContentPresenter.Content = Header;
		}

		if (m_firstTimeSettingToolTip)
		{
			m_firstTimeSettingToolTip = false;

			if (ToolTipService.GetToolTip(this) == null)
			{
				// App author has not specified a tooltip; use our own
				ToolTip CreateToolTip()
				{
					var toolTip = new ToolTip();
					toolTip.Placement = PlacementMode.Mouse;
					ToolTipService.SetToolTip(this, toolTip);
					return toolTip;
				}

				m_toolTip = CreateToolTip();
			}
		}

		var toolTip = m_toolTip;
		if (toolTip != null)
		{
			// Update tooltip text to new header text
			var headerContent = Header;

			// Only show tooltip if header is a non-empty string.
			if (headerContent is string headerString && !string.IsNullOrEmpty(headerString))
			{
				toolTip.Content = headerString;
				toolTip.IsEnabled = true;
			}
			else
			{
				toolTip.Content = null;
				toolTip.IsEnabled = false;
			}
		}
	}

	protected override void OnPointerPressed(PointerRoutedEventArgs args)
	{
		if (IsSelected && (PointerDeviceType)args.Pointer.PointerDeviceType == PointerDeviceType.Mouse)
		{
			var pointerPoint = args.GetCurrentPoint(this);
			if (pointerPoint.Properties.IsLeftButtonPressed)
			{
				var isCtrlDown = (Windows.UI.Xaml.Window.Current.CoreWindow.GetKeyState(VirtualKey.Control) & CoreVirtualKeyStates.Down) == CoreVirtualKeyStates.Down;
				if (isCtrlDown)
				{
					// Return here so the base class will not pick it up, but let it remain unhandled so someone else could handle it.
					return;
				}
			}
		}

		base.OnPointerPressed(args);

		if (args.GetCurrentPoint(null).Properties.PointerUpdateKind == PointerUpdateKind.MiddleButtonPressed)
		{
			if (CapturePointer(args.Pointer))
			{
				m_hasPointerCapture = true;
				m_isMiddlePointerButtonPressed = true;
			}
		}
	}

	protected override void OnPointerReleased(PointerRoutedEventArgs args)
	{
		base.OnPointerReleased(args);

		if (m_hasPointerCapture)
		{
			if (args.GetCurrentPoint(null).Properties.PointerUpdateKind == PointerUpdateKind.MiddleButtonReleased)
			{
				bool wasPressed = m_isMiddlePointerButtonPressed;
				m_isMiddlePointerButtonPressed = false;
				ReleasePointerCapture(args.Pointer);

				if (wasPressed)
				{
					if (IsClosable)
					{
						RequestClose();
					}
				}
			}
		}
	}

	private void HideLeftAdjacentTabSeparator()
	{
		if (GetParentTabView() is TabView tabView)
		{
			var internalTabView = tabView;
			var index = internalTabView.IndexFromContainer(this);
			internalTabView.SetTabSeparatorOpacity(index - 1, 0);
		}
	}

	private void RestoreLeftAdjacentTabSeparatorVisibility()
	{
		if (GetParentTabView() is TabView tabView)
		{
			var internalTabView = tabView;
			var index = internalTabView.IndexFromContainer(this);
			internalTabView.SetTabSeparatorOpacity(index - 1);
		}
	}

	protected override void OnPointerEntered(PointerRoutedEventArgs args)
	{
		base.OnPointerEntered(args);

		m_isPointerOver = true;

		if (m_hasPointerCapture)
		{
			m_isMiddlePointerButtonPressed = true;
		}

		UpdateCloseButton();
		HideLeftAdjacentTabSeparator();
	}

	protected override void OnPointerExited(PointerRoutedEventArgs args)
	{
		base.OnPointerExited(args);

		m_isPointerOver = false;
		m_isMiddlePointerButtonPressed = false;

		UpdateCloseButton();
		UpdateForeground();
		RestoreLeftAdjacentTabSeparatorVisibility();
	}

	protected override void OnPointerCanceled(PointerRoutedEventArgs args)
	{
		base.OnPointerCanceled(args);

		if (m_hasPointerCapture)
		{
			ReleasePointerCapture(args.Pointer);
			m_isMiddlePointerButtonPressed = false;
		}
		RestoreLeftAdjacentTabSeparatorVisibility();
	}

	protected override void OnPointerCaptureLost(PointerRoutedEventArgs args)
	{
		base.OnPointerCaptureLost(args);

		m_hasPointerCapture = false;
		m_isMiddlePointerButtonPressed = false;
		RestoreLeftAdjacentTabSeparatorVisibility();
	}

	// Note that the ItemsView will handle the left and right arrow keys if we don't do so before it does,
	// so this needs to be handled below the items view. That's why we can't put this in TabView's OnKeyDown.
	private void OnKeyDown(KeyRoutedEventArgs args)
	{
		if (!args.Handled && (args.Key == VirtualKey.Left || args.Key == VirtualKey.Right))
		{
			// Alt+Shift+Arrow reorders tabs, so we don't want to handle that combination.
			// ListView also handles Alt+Arrow  (no Shift) by just doing regular XY focus,
			// same as how it handles Arrow without any modifier keys, so in that case
			// we do want to handle things so we get the improved keyboarding experience.
			var isAltDown = (Window.Current.CoreWindow.GetKeyState(VirtualKey.Menu) & CoreVirtualKeyStates.Down) == CoreVirtualKeyStates.Down;
			var isShiftDown = (Window.Current.CoreWindow.GetKeyState(VirtualKey.Shift) & CoreVirtualKeyStates.Down) == CoreVirtualKeyStates.Down;
			
			if (!isAltDown || !isShiftDown)
			{
				var bool moveForward =
					(FlowDirection == FlowDirection.LeftToRight && args.Key == VirtualKey.Right) ||
					(FlowDirection == FlowDirection.RightToLeft && args.Key == VirtualKey.Left);

				args.Handled = GetParentTabView().MoveFocus(moveForward);
			}
		}

		if (!args.Handled)
		{
			base.OnKeyDown(args);
		}
	}

	private void OnIconSourcePropertyChanged(DependencyPropertyChangedEventArgs args)
	{
		OnIconSourceChanged();
	}

	private void OnIconSourceChanged()
	{
		var templateSettings = TabViewTemplateSettings;
		var source = this.IconSource;
		if (source != null)
		{
			templateSettings.IconElement = SharedHelpers.MakeIconElementFrom(source);
			VisualStateManager.GoToState(this, "Icon", false);
		}

		else
		{
			templateSettings.IconElement = null;
			VisualStateManager.GoToState(this, "NoIcon", false);
		}
	}

	internal void StartBringTabIntoView()
	{
		// we need to set the TargetRect to be slightly wider than the TabViewItem size in order to avoid cutting off the end of the Tab
		BringIntoViewOptions options = new();
		options.TargetRect = new Rect(0, 0, DesiredSize.Width + c_targetRectWidthIncrement, DesiredSize.Height);
		StartBringIntoView(options);
	}
}
