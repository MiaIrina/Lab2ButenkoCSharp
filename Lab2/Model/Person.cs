﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ButenkoLab02.Model
{
	class Person
	{
		#region Fields
		private string _name;
		private int _age;
		private string _surname;
		private DateTime _birthDay = DateTime.Today;
		private string _email;
		public static readonly String[] ChineseYear = { "Monkey", "Rooster", "Dog", "Pig", "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat" };
		private string _chineseHoroscope;
		private string _westHoroscope;
	


		#endregion



		public int Age
		{
			get
			{
				return _age;
			}
			private set
			{
				_age = value;
				if (_age > 135 || _birthDay > DateTime.Today)
				{
					throw new Exception("Wrong date of birthday");
				}
			}
		}
		public string Name
		{
			get
			{
				return _name;
			}
			private set
			{
				_name = value;


			}
		}
		public string Surname
		{
			get
			{
				return _surname;
			}
			private set
			{
				_surname = value;

			}
		}
		public DateTime BirthDay
		{
			get
			{
				return _birthDay;
			}
			private set
			{
				_birthDay = value;


			}
		}
		public string Email
		{
			get
			{
				return _email;
			}
			private set
			{
				_email = value;


			}
		}
		public bool isAdult
		{
			get
			{
				return (Age >= 18);
			}
		}
		public bool IsBirthDay
		{
			get
			{
				return (_birthDay == DateTime.Today);
			}
		}

		public string WestHoroscope
		{
			get
			{
				return _westHoroscope;
			}
			private set
			{
				_westHoroscope = value;

			}
		}
		public string ChineseHoroscope
		{
			get
			{
				return _chineseHoroscope;
			}
			private set
			{
				_chineseHoroscope = value;

			}

		}

		public Person(string _name, string _surname, DateTime _birthDay, string _email)
		{
			this._name = _name;
			this._surname = _surname;
			this._birthDay = _birthDay;
			this._email = _email;
			DefineAge();
			DefineChineseHoroscope();
			DefineTheWestHoroscope();


		}
		public Person(string _name, string _surname, string _email)
		{
			this._name = _name;
			this._surname = _surname;
			this._email = _email;
			DefineAge();
			DefineChineseHoroscope();
			DefineTheWestHoroscope();
		}
		public Person(string _name, string _surname, DateTime _birthDay)
		{
			this._name = _name;
			this._surname = _surname;
			this._birthDay = _birthDay;
			_email = "unknown@gmail.com";
			DefineAge();
			DefineTheWestHoroscope();
			DefineChineseHoroscope();
		}
		private void DefineTheWestHoroscope()
		{

			int day = _birthDay.Day;
			int month = _birthDay.Month;
			if (day >= 22 && month == 12 || day <= 20 && month == 1)
			{
				WestHoroscope = "Capricorn";
			}
			else if (day >= 21 && month == 1 || day <= 19 && month == 2)
			{
				WestHoroscope = "Aquarius";
			}
			else if (day >= 20 && month == 2 || day <= 20 && month == 3)
			{
				WestHoroscope = "Pisces";
			}
			else if (day >= 21 && month == 3 || day <= 19 && month == 4)
			{
				WestHoroscope = "Aries";
			}
			else if (day >= 20 && month == 4 || day <= 20 && month == 5)
			{
				WestHoroscope = "Taurus";
			}
			else if (day >= 21 && month == 5 || day <= 21 && month == 6)
			{
				WestHoroscope = "Gemini";
			}
			else if (day >= 22 && month == 6 || day <= 23 && month == 7)
			{
				WestHoroscope = "Cancer";
			}
			else if (day >= 24 && month == 7 || day <= 23 && month == 8)
			{
				WestHoroscope = "Leo";
			}
			else if (day >= 24 && month == 8 || day <= 22 && month == 9)
			{
				WestHoroscope = "Virgo";
			}
			else if (day >= 23 && month == 9 || day <= 22 && month == 10)
			{
				WestHoroscope = "Libra";
			}
			else if (day >= 23 && month == 10 || day <= 22 && month == 11)
			{
				WestHoroscope = "Scorpio";
			}
			else WestHoroscope = "Sagittarius";

		}
		private void DefineChineseHoroscope()
		{

			ChineseHoroscope = ChineseYear[_birthDay.Year % 12];
		}
		private void DefineAge()
		{
			Age = (int)((DateTime.Today - _birthDay).Days / 365);
		}


	}
}
