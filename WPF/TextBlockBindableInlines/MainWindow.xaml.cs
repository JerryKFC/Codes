using System.Windows;

namespace TextBlockBindableInlines
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		MainWindowViewModel viewModel = new MainWindowViewModel();

		public MainWindow()
		{
			InitializeComponent();

			DataContext = viewModel;
		}
	}
}
