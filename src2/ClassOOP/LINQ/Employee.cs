using System;

namespace ClassOOP.LINQ
{
	public class Employee
	{
		public string Surname { get; private set; }
		public string Name { get; private set; }
		public string MiddleName { get; private set; }
		public string FullName { get; private set; }
		public int Age { get; private set; }
		public Gender Gender { get; private set; }
		public string Position { get; private set; }
		public DateTime DateOfEmployment { get; private set; }
		public int Salary { get; private set; }

		public Employee(string surname, string name, string middleName, int age, Gender gender, string position, DateTime dateOfEmployment, int salary)
		{
			Surname = surname;
			Name = name;
			MiddleName = middleName;
			FullName = Surname + " " + Name + " " + MiddleName;
			Age = age;
			Gender = gender;
			Position = position;
			DateOfEmployment = dateOfEmployment;
			Salary = salary;
		}

		public override string ToString()
		{
			return $"{FullName} " + $" {Age} лет, " + $"пол: {Gender}, " + $"должность: {Position}, " +
			       $"дата устройства на работу: {DateOfEmployment}, " +
			       $"зарплата {Salary}";
		}
	}
}