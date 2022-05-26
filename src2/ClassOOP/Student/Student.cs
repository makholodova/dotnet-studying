using System;

namespace ClassOOP.Student
{
	public struct Student
	{
		public string SurnameAndInitials;
		public int NumberGroup;
		public int[] Grade;
		public decimal AverageGrade;

		public void CalculateTheAverageGrade()
		{
			var sum = 0;
			for (var i = 0; i < Grade.Length; i++)
			{
				sum += Grade[i];
			}

			AverageGrade = Math.Round(sum / (decimal) Grade.Length); ////округления?
		}

		public bool HaveGoodGradesOnly()
		{
			for (var j = 0; j < 5; j++)
			{
				if (Grade[j] < 4)
				{
					return false;
				}
			}

			return true;
		}

		public void PrintContent()
		{
			Console.Write($"ФИО: {SurnameAndInitials}, номер группы: {NumberGroup}, " + "успеваемость: ");

			for (var i = 0; i < Grade.Length; i++)
			{
				Console.Write($"{Grade[i]},");
			}

			Console.WriteLine($" Средний балл: {AverageGrade}");
		}
	}
}