using ButenkoLab02.Model;
using ButenkoLab02.Tools.Navigation;
using ButenkoLab02.ViewModels;

using System.Windows.Controls;


namespace ButenkoLab02.Views
{
	/// <summary>
	/// Логика взаимодействия для UserInfoView.xaml
	/// </summary>
	public partial class UserInfoView : UserControl, INavigatable

	{
		internal UserInfoView(Person user)
		{
			InitializeComponent();
			DataContext = new UserInfoViewModel(user);
		}
	}
}
