﻿using ButenkoLab02.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButenkoLab02.Tools.Navigation
{
	internal abstract class BaseNavigationModel : INavigationModel
	{
		private readonly IContentOwner _contentOwner;
		private readonly Dictionary<ViewType, INavigatable> _viewsDictionary;

		protected BaseNavigationModel(IContentOwner contentOwner)
		{
			_contentOwner = contentOwner;
			_viewsDictionary = new Dictionary<ViewType, INavigatable>();
		}

		protected IContentOwner ContentOwner
		{
			get { return _contentOwner; }
		}

		protected Dictionary<ViewType, INavigatable> ViewsDictionary
		{
			get { return _viewsDictionary; }
		}

		public void Navigate(ViewType viewType)
		{
			if (!ViewsDictionary.ContainsKey(viewType))
				InitializeView(viewType);
			ContentOwner.ContentControl.Content = ViewsDictionary[viewType];
		}

		public void Navigate(ViewType viewType, Person user)
		{
			if (ViewsDictionary.ContainsKey(viewType))
			{
				ViewsDictionary.Remove(viewType);
			}
			InitializeView(viewType, user);

			ContentOwner.ContentControl.Content = ViewsDictionary[viewType];
		}
		protected abstract void InitializeView(ViewType viewType);
		protected abstract void InitializeView(ViewType viewType, Person user);
	}
}
