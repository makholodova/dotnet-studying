using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassOOP.LINQ
{
	public class LinqEntryPoint : IEntryPoint
	{
		public void Start()
		{
			var employees = EmployeeBuilder.Build();
			SalaryMore50(employees);
			MensCount(employees);
			WomenCount(employees);
			SortByName(employees);
			SumSalary(employees);
			RemovePositionDuplicate(employees);
			EmployeeWithMinSalary(employees);
			EmployeeWithMaxSalary(employees);
			TheEldestEmployee(employees);
			TheYoungestEmployee(employees);
			StartDateOfTheFirstEmployee(employees);
			//ListOfEmployees
			Console.WriteLine("Вывести сисок сотрудников:");
			var listOfEmployee = employees.Where(p =>
				(p.Position == "Программист") &
				(p.Salary >= 100000) & (p.Salary <= 200000)).OrderBy(p =>
				p.Age).ThenBy(p => p.FullName).Take(5);
			foreach (var employee in listOfEmployee)
			{
				Console.WriteLine(employee.ToString());
			}
		}

		private static void StartDateOfTheFirstEmployee(List<Employee> employees)
		{
			Console.WriteLine("Дата начала работы первого сотрудника:");
			var startDate = employees.Min(p => p.DateOfEmployment);
			Console.WriteLine(startDate);
		}

		private static void EmployeeWithMaxSalary(List<Employee> employees)
		{
			Console.WriteLine("Сотрудник с максимальной ЗП:");
			var employeeWithMaxSalary = employees.OrderBy(p => p.Salary).LastOrDefault();
			if (employeeWithMaxSalary == null)
			{
				Console.WriteLine("Ничего не найдено");
				return;
			}

			Console.WriteLine(employeeWithMaxSalary);
		}

		private static void EmployeeWithMinSalary(List<Employee> employees)
		{
			Console.WriteLine("Сотрудник с минимальной ЗП:");
			var employeeWithMinSalary = employees.OrderBy(p => p.Salary).FirstOrDefault();
			if (employeeWithMinSalary == null)
			{
				Console.WriteLine("Ничего не найдено");
				return;
			}

			Console.WriteLine(employeeWithMinSalary);
		}

		private static void TheYoungestEmployee(List<Employee> employees)
		{
			Console.WriteLine("2-e самых молодых сотрудников:");
			var theYoungest = employees.OrderBy(p => p.Age).Take(2);
			foreach (var employee in theYoungest)
			{
				Console.WriteLine(employee.ToString());
			}
		}

		private static void TheEldestEmployee(List<Employee> employees)
		{
			Console.WriteLine("3-е самых взрослых сотрудников:");
			var theEldest = employees.OrderByDescending(p => p.Age).Take(3);
			foreach (var employee in theEldest)
			{
				Console.WriteLine(employee.ToString());
			}
		}

		private static void RemovePositionDuplicate(List<Employee> employees)
		{
			Console.WriteLine("Список должностей без дубликатов");
			var positions = employees.Select(p => p.Position);
			var removeDuplicate = positions.Distinct();
			foreach (var position in removeDuplicate)
			{
				Console.WriteLine(position + ", ");
			}
		}

		private static void SumSalary(List<Employee> employees)
		{
			Console.Write("Общая сумма выплачиваемая всем сотрудникам: ");
			var sumSalary = employees.Sum(p => p.Salary);
			Console.WriteLine(sumSalary);
		}

		private static void SortByName(List<Employee> employees)
		{
			Console.WriteLine("Список сотрудников отсортированных по имени:");
			var sortByName = employees.OrderBy(p => p.FullName);
			foreach (var employee in sortByName)
			{
				Console.WriteLine(employee.ToString());
			}
		}

		private static void WomenCount(List<Employee> employees)
		{
			Console.Write("Количество женщин в компании:");
			var womenCount = employees.Count(p => p.Gender == Gender.Female);
			Console.WriteLine(womenCount);
		}

		private static void MensCount(List<Employee> employees)
		{
			Console.Write("Количество мужчин в компании:");
			var mensCount = employees.Count(p => p.Gender == Gender.Male);
			Console.WriteLine(mensCount);
		}

		private static void SalaryMore50(List<Employee> employees)
		{
			Console.WriteLine("Список сотрудников, у которых зарплата больше 50K: ");
			var result = employees.Where(p => p.Salary > 50000);
			foreach (var employee in result)
			{
				Console.WriteLine(employee.ToString());
			}
		}
	}
}