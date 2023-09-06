using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace TextBlockBindableInlines
{
	class TextBlockExtensions
	{
		public static ObservableCollection<Inline> GetBindableInlines(DependencyObject obj)
		{
			return (ObservableCollection<Inline>)obj.GetValue(BindableInlinesProperty);
		}

		public static void SetBindableInlines(DependencyObject obj, ObservableCollection<Inline> value)
		{
			obj.SetValue(BindableInlinesProperty, value);
		}

		public static readonly DependencyProperty BindableInlinesProperty =
			DependencyProperty.RegisterAttached("BindableInlines", typeof(ObservableCollection<Inline>), typeof(TextBlockExtensions), new PropertyMetadata(null, OnBindableInlinesChanged));

		private static void OnBindableInlinesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			var Target = d as TextBlock;

			if (Target != null)
			{
				Target.Inlines.Clear();
				Target.Inlines.AddRange((System.Collections.IEnumerable)e.NewValue);
			}
		}
	}
}
