using System;

namespace ClassOOP.Student
{
	public class StudentEntryPoint : IEntryPoint
	{
		public void Start()
		{
			var students = new Student[10];
			CreateStudents(students);

			for (var i = 0; i < students.Length; i++)
			{
				students[i].CalculateTheAverageGrade();
			}

			//экземпляров класс может быть создано много

			PrintStudentsContent(students);

			// students[0].PrintContent(); //обращение к экзепляру класса
			//students[1].PrintContent(); //обращение к экзепляру класса

			//класс только один
			//Student.PrintContent(); //обращение к классу

			Console.WriteLine("Упорядочить записи по возрастанию среднего балла");

			SortByAverageGrade(students);

			PrintStudentsContent(students);

			Console.WriteLine("Cписок студентов, имеющих оценки, равные только 4 или 5:");

			for (var i = 0; i < students.Length; i++)
			{
				var good = students[i].HaveGoodGradesOnly();
				if (good)
				{
					students[i].PrintContent();
				}
			}
		}

		private static void PrintStudentsContent(Student[] students)
		{
			for (var i = 0; i < students.Length; i++)
			{
				students[i].PrintContent();
			}
		}

		private static void CreateStudents(Student[] students)
		{
			students[0] = new Student
			{
				SurnameAndInitials = "Иванов В.И",
				NumberGroup = 202001,
				Grade = new[]
					{3, 3, 2, 4, 5}
			};
			students[1] = new Student
			{
				SurnameAndInitials = "Петров Р.П",
				NumberGroup = 202001,
				Grade = new[]
					{5, 4, 4, 4, 5}
			};
			students[2] = new Student
			{
				SurnameAndInitials = "Ткаченко В.Н",
				NumberGroup = 202002,
				Grade = new[]
					{5, 4, 5, 5, 5}
			};
			students[3] = new Student
			{
				SurnameAndInitials = "Холодов Р.Д",
				NumberGroup = 202003,
				Grade = new[]
					{5, 5, 5, 5, 5}
			};
			students[4] = new Student
			{
				SurnameAndInitials = "Семенов А.П",
				NumberGroup = 202001,
				Grade = new[]
					{3, 4, 2, 3, 3}
			};
			students[5] = new Student
			{
				SurnameAndInitials = "Дудко В.С",
				NumberGroup = 202003,
				Grade = new[]
					{5, 4, 3, 3, 3}
			};
			students[6] = new Student
			{
				SurnameAndInitials = "Гейко Т.И",
				NumberGroup = 202002,
				Grade = new[]
					{5, 3, 4, 4, 5}
			};
			students[7] = new Student
			{
				SurnameAndInitials = "Морозов Н.У",
				NumberGroup = 202003,
				Grade = new[]
					{3, 4, 5, 5, 4}
			};
			students[8] = new Student
			{
				SurnameAndInitials = "Николаев Н.Б",
				NumberGroup = 202002,
				Grade = new[]
					{4, 4, 3, 3, 5}
			};
			students[9] = new Student
			{
				SurnameAndInitials = "Кудрин Ф.М",
				NumberGroup = 202001,
				Grade = new[]
					{5, 4, 4, 5, 5}
			};
		}

		private static void SortByAverageGrade(Student[] students)
		{
			for (var i = 0; i < students.Length; i++)
			for (var j = 0; j < students.Length - i - 1; j++)
			{
				var student1 = students[j];
				var averageGrade1 = student1.AverageGrade;
				var student2 = students[j + 1];
				var averageGrade2 = student2.AverageGrade;
				if (averageGrade1 > averageGrade2)
				{
					students[j] = student2;
					students[j + 1] = student1;
				}
			}
		}
	}
}