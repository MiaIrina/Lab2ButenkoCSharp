﻿using ButenkoLab02.Tools;
using ButenkoLab02.Tools.Managers;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using ButenkoLab02.Model;
using ButenkoLab02.Tools.Navigation;

namespace ButenkoLab02.ViewModels
{
	internal class HoroscopViewModel : BaseViewModel
	{

		#region Fields
		private String _email;
		private String _name;
		private String _surname;
		private DateTime _dateOfBirth = DateTime.Today;
		private RelayCommand<object> _exitCommand;
		private RelayCommand<object> _beginCommand;
		private Person _user;
		#endregion



		public String Email
		{
			get
			{
				return _email;
			}
			set
			{
				_email = value;
				OnPropertyChanged();
			}
		}
		public String Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
				OnPropertyChanged();
			}
		}
		public String Surname
		{
			get
			{
				return _surname;
			}
			set
			{
				_surname = value;
				OnPropertyChanged();
			}
		}
		public DateTime DateOfBirth
		{
			get
			{
				return _dateOfBirth;
			}
			set
			{
				_dateOfBirth = value;
				OnPropertyChanged();
			}
		}

		private async void StartDefining(object obj)
		{
			LoaderManager.Instance.ShowLoader();
			await Task.Run(() => Thread.Sleep(2000));


			bool result = await Task.Run(() => {
				try
				{
					_user = new Person(_name, _surname, _dateOfBirth, _email);
					if (_user.IsBirthDay)
					{
						MessageBox.Show("Happy birthday!");
					}
				}
				catch (Exception)
				{
					MessageBox.Show("Wrong date!");
					return false;
				}
				if (_user == null)
				{
					return false;
				}
				return true;
			});

			if (result)
			{
				NavigationManager.Instance.Navigate(ViewType.FormUser, _user);
			}


			LoaderManager.Instance.HideLoader();





		}




		public RelayCommand<Object> BeginCommand
		{
			get
			{
				return _beginCommand ?? (_beginCommand = new RelayCommand<object>(
						  StartDefining, o => CanExecuteCommand()));
			}
		}
		public RelayCommand<Object> ExitCommand
		{
			get
			{
				return _exitCommand ?? (_exitCommand = new RelayCommand<object>(o => Environment.Exit(0)));
			}
		}


		private bool CanExecuteCommand() => (!string.IsNullOrEmpty(_email)
				&& !string.IsNullOrEmpty(_name) && !string.IsNullOrEmpty(_surname)

				);

	}

}
