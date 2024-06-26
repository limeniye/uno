﻿using System;
using Uno.UI.Samples.Controls;
using Windows.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using RefreshVisualizer = Microsoft/* UWP don't rename */.UI.Xaml.Controls.RefreshVisualizer;
using RefreshVisualizerState = Microsoft/* UWP don't rename */.UI.Xaml.Controls.RefreshVisualizerState;
using RefreshRequestedEventArgs = Microsoft/* UWP don't rename */.UI.Xaml.Controls.RefreshRequestedEventArgs;
using RefreshInteractionRatioChangedEventArgs = Microsoft/* UWP don't rename */.UI.Xaml.Controls.RefreshInteractionRatioChangedEventArgs;
using RefreshStateChangedEventArgs = Microsoft/* UWP don't rename */.UI.Xaml.Controls.RefreshStateChangedEventArgs;
using RefreshPullDirection = Microsoft/* UWP don't rename */.UI.Xaml.Controls.RefreshPullDirection;
using System.Threading.Tasks;

namespace UITests.Microsoft_UI_Xaml_Controls.RefreshContainerTests
{
	[Sample("PullToRefresh")]
	public sealed partial class RefreshContainerHorizontalScroll : Page
	{
		private readonly Random _randomizer = new Random();

		public RefreshContainerHorizontalScroll()
		{
			this.InitializeComponent();
			this.RefreshContainer.RefreshRequested += RefreshContainer_RefreshRequested;
		}

		private void RequestRefresh_Click(object sender, RoutedEventArgs args)
		{
			this.RefreshContainer.RequestRefresh();
		}

		private async void RefreshContainer_RefreshRequested(object sender, RefreshRequestedEventArgs e)
		{
			var deferral = e.GetDeferral();
			await Task.Delay(2000);
			deferral.Complete();
		}
	}
}
