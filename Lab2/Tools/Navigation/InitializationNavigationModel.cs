using ButenkoLab02.Model;
using ButenkoLab02.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButenkoLab02.Tools.Navigation
{
	internal class InitializationNavigationModel : BaseNavigationModel
	{
		public InitializationNavigationModel(IContentOwner contentOwner) : base(contentOwner)
		{

		}

		protected override void InitializeView(ViewType viewType)
		{
			switch (viewType)
			{



				case ViewType.Main:
					ViewsDictionary.Add(viewType, new UserHoroscopeControl());
					break;
				default:
					throw new ArgumentOutOfRangeException(nameof(viewType), viewType, null);
			}
		}
		protected override void InitializeView(ViewType viewType, Person user)
		{
			switch (viewType)
			{


				case ViewType.FormUser:
					ViewsDictionary.Add(viewType, new UserInfoView(user));
					break;
				default:
					throw new ArgumentOutOfRangeException(nameof(viewType), viewType, null);
			}
		}
	}
}
