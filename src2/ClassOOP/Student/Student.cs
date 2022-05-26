using System;

namespace ClassOOP.Student
{
	public struct Student
	{
		public string SurnameAndInitials;
		public int NumberGroup;
		public int[] Grades;
		public decimal AverageGrade;

		public void CalculateTheAverageGrade()
		{
			var sum = 0;
			for (var i = 0; i < Grades.Length; i++)
			{
				sum += Grades[i];
			}

			AverageGrade = Math.Round(sum / (decimal) Grades.Length); ////округления?
		}

		public bool HaveGoodGradesOnly()
		{
			for (var j = 0; j < 5; j++)
			{
				if (Grades[j] < 4)
				{
					return false;
				}
			}

			return true;
		}

		public void PrintContent()
		{
			Console.Write($"ФИО: {SurnameAndInitials}, номер группы: {NumberGroup}, " + "успеваемость: ");

			for (var i = 0; i < Grades.Length; i++)
			{
				Console.Write($"{Grades[i]},");
			}

			Console.WriteLine($" Средний балл: {AverageGrade}");
		}
	}
}