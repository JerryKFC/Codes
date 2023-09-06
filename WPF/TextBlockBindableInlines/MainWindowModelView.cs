using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Documents;
using System.Windows.Media;

namespace TextBlockBindableInlines
{
	class MainWindowViewModel : INotifyPropertyChanged
	{
		public ObservableCollection<Inline> Inlines { get; private set; }
		public event PropertyChangedEventHandler PropertyChanged;

		public MainWindowViewModel()
		{
			Inlines = new ObservableCollection<Inline>();
			Inlines.Add(new Run("root") { Foreground = Brushes.Yellow });
			Inlines.Add(new Run("@"));
			Inlines.Add(new Run("localhost") { Foreground = Brushes.Blue });
			Inlines.Add(new Run(":"));
			Inlines.Add(new Run("/tmp") { Foreground = Brushes.Cyan });
			Inlines.Add(new Run("# ") { Foreground = Brushes.Green });
			Inlines.Add(new Run("ls"));
		}

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
