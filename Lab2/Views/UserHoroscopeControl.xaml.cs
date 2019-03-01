
using System.Windows.Controls;
using ButenkoLab02.Tools.Navigation;
using ButenkoLab02.ViewModels;
namespace ButenkoLab02.Views
{
	/// <summary>
	/// Логика взаимодействия для UserHoroscopeControl.xaml
	/// </summary>
	public partial class UserHoroscopeControl : UserControl, INavigatable
	{
		public UserHoroscopeControl()
		{
			InitializeComponent();
			DataContext = new HoroscopViewModel();
		}
	}
}
