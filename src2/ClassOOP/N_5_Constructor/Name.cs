using System;
using System.Diagnostics.CodeAnalysis;

namespace ClassOOP.N_5_Constructor
{
	[SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
	public class Name : IDisposable
	{
		private string _fullName; //field (поле)
		public string FirstName { get; private set; } //immutable property (неизменяемый)
		public string LastName { get; private set; }

		/// <summary>
		/// Конструктор по умолчанию (default constructor)
		/// </summary>
		public Name()
		{
			FirstName = "Jonni";
			LastName = "Deph";
			_fullName = FirstName + " " + LastName;
		}

		public Name(string firstName, string lastName)
		{
			FirstName = firstName;
			LastName = lastName;
			_fullName = FirstName + " " + LastName;
		}

		public void ChangeName(string firstName, string lastName)
		{
			if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
			{
				return;
			}

			FirstName = firstName;
			LastName = lastName;
			_fullName = FirstName + " " + LastName;
		}

		public void Print()
		{
			Console.WriteLine("Print " + _fullName);
		}

		// вызывается для очистки ресурсов когда используешь using(){}
		public void Dispose()
		{
			Console.WriteLine("Объект disposed " + _fullName);
		}

		// вызывается для очистки ресурсов когда-то
		~Name()
		{
			Console.WriteLine("Объект destructed " + _fullName);
		}
	}
}