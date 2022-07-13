using System;
using System.Collections.Generic;

namespace ClassOOP.LINQ
{
	public static class EmployeeBuilder
	{
		public static List<Employee> Build()
		{
			var employees = new List<Employee>();
			employees.Add(new Employee("Холодов", "Дмитрий", "Геннадьевич", 34, Gender.Male, "Программист",
				new DateTime(2015, 09, 10), 200000));
			employees.Add(new Employee("Куйсокова", "Мариета", "Алиевна", 29, Gender.Female, "Сметчик",
				new DateTime(2019, 03, 18), 120000));
			employees.Add(new Employee("Куделько", "Ирина", "Владиславовна", 42, Gender.Female, "Программист",
				new DateTime(2013, 05, 27), 100000));
			employees.Add(new Employee("Николаева", "Наталья", "Борисовна", 48, Gender.Female, "Сметчик",
				new DateTime(2017, 11, 30), 40000));
			employees.Add(new Employee("Рассудишкин", "Михаил", "Сергеевич", 33, Gender.Male, "Программист",
				new DateTime(2017, 08, 13), 150000));
			employees.Add(new Employee("Куделько", "Денис", "Андреевич", 20, Gender.Male, "Экономист",
				new DateTime(2021, 07, 03), 40000));
			employees.Add(new Employee("Жиденко", "Геннадий", "Александрович", 33, Gender.Male, "Сборщик_мебели",
				new DateTime(2016, 12, 25), 145000));
			employees.Add(new Employee("Холодова", "Марина", "Андревна", 28, Gender.Female, "Программист",
				new DateTime(2021, 12, 24), 105000));
			employees.Add(new Employee("Костенко", "Роман", "Владимирович", 33, Gender.Male, "Стоматолог",
				new DateTime(2021, 07, 03), 110000));
			employees.Add(new Employee("Жиденко", "Елена", "Константиновна", 26, Gender.Female, "Фармацевт",
				new DateTime(2015, 04, 16), 45000));
			employees.Add(new Employee("Холодов", "Олег", "Геннадьевич", 32, Gender.Male, "Программист",
				new DateTime(2017, 07, 11), 560000));
			employees.Add(new Employee("Иванов", "Петр", "Геннадьевич", 54, Gender.Male, "Программист",
				new DateTime(2014, 01, 15), 195000));
			return employees;
		}
	}
}