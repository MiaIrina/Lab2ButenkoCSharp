using ButenkoLab02.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButenkoLab02.Tools.Navigation
{
	internal enum ViewType
	{
		FormUser,
		Main
	}

	interface INavigationModel
	{
		void Navigate(ViewType viewType);
		void Navigate(ViewType viewType, Person user);
	}
}
