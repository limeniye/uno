using System.Collections.Generic;
using Uno.UI.Samples.Controls;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Documents;
using Microsoft.UI.Xaml.Media;

namespace UITests.Windows_UI_Xaml_Controls.RichTextBlock
{
	[Sample("RichTextBlock")]
	public sealed partial class RichTextBlock_Paragraph : UserControl
	{
		public RichTextBlock_Paragraph()
		{
			this.InitializeComponent();
			Loaded += TextBlock_LineHeight_Inlines_Loaded;
		}

		private void TextBlock_LineHeight_Inlines_Loaded(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
		{
			RemoveFocusStates(Button0);
			RemoveFocusStates(Button1);
		}

		// For debug
		private void RemoveFocusStates(Button button)
		{
#if !WINDOWS
			var childElement = VisualTreeHelper.GetChild(button, 0) as FrameworkElement;
			List<VisualStateGroup> newVisualStates = new List<VisualStateGroup>(2);
			VisualStateManager.SetVisualStateGroups(childElement, newVisualStates);
#endif
		}

		private bool test0 = false;
		private void Button_Click0(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
		{
			var newRun = new Run();
			newRun.FontSize = 24;
			newRun.Text = "Some Test Text for RichTextBlock";

			var lineBreak0 = new LineBreak();

			var paragraph = new Paragraph();
			paragraph.Inlines.Add(newRun);
			if (test0)
			{
				paragraph.Inlines.Add(lineBreak0);
			}
			test0 = !test0;
			TestRichTextBlock.Blocks.Add(paragraph);
		}

		private bool test = false;
		private void Button_Click1(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
		{
			var newRun = new Run();
			newRun.FontSize = 24;
			newRun.Text = "Some Test Text for TextBlock";

			var lineBreak0 = new LineBreak();
			var lineBreak1 = new LineBreak();

			var span = new Span();
			span.Inlines.Add(newRun);
			span.Inlines.Add(lineBreak0);
			if (test)
			{
				span.Inlines.Add(lineBreak1);
			}
			test = !test;

			TestTextBlock.Inlines.Add(span);
		}
	}
}
