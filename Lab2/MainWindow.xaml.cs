
using ButenkoLab02.Tools.Managers;
using ButenkoLab02.Tools.Navigation;
using ButenkoLab02.ViewModels;
using System.Windows;
using System.Windows.Controls;


namespace Lab2
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window, IContentOwner
	{


		public ContentControl ContentControl => _contentControl;

		public MainWindow()
		{
			InitializeComponent();
			DataContext = new MainViewModel();
			InitializeApplication();
		}
		private void InitializeApplication()
		{

			NavigationManager.Instance.Initialize(new InitializationNavigationModel(this));
			NavigationManager.Instance.Navigate(ViewType.Main);
		}
	}
}
