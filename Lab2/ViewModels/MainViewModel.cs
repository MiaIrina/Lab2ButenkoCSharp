﻿using ButenkoLab02.Tools;
using ButenkoLab02.Tools.Managers;
using ButenkoLab02.Tools.Navigation;
using System.Windows;

namespace ButenkoLab02.ViewModels
{
	class MainViewModel : BaseViewModel, ILoaderOwner, INavigatable
	{
		#region Fields
		private Visibility _loaderVisibility = Visibility.Hidden;
		private bool _isControlEnabled = true;
		#endregion

		#region Properties
		public Visibility LoaderVisibility
		{
			get { return _loaderVisibility; }
			set
			{
				_loaderVisibility = value;
				OnPropertyChanged();
			}
		}
		public bool IsControlEnabled
		{
			get { return _isControlEnabled; }
			set
			{
				_isControlEnabled = value;
				OnPropertyChanged();
			}
		}
		#endregion

		internal MainViewModel()
		{
			LoaderManager.Instance.Initialize(this);
		}
	}

}

