using System;

namespace ClassOOP.Student
{
    public struct Student
    {
        public string SurnameAndInitials;
        public int NumberGroup;
        public int[] Performances;
        public decimal AverageMark;

        public void CalculateTheAverageMark()
        {
            var sum = 0;
            for (var i = 0; i < Performances.Length; i++) sum += Performances[i];
            AverageMark =Math.Round(sum / (decimal)Performances.Length) ; ////округления?
        }

        // public void SortByAverageMark(){}

        public bool FindGoodMark()
        {
            var good = true;
            for (var j = 0; j < 5; j++)
                if (Performances[j] < 4)
                {
                    good = false;
                    break;
                }

            return good;
        }

        public void PrintContent()
        {
            Console.Write($"ФИО: {SurnameAndInitials}, номер группы: {NumberGroup}, " + "успеваемость: ");

            for (var i = 0; i < Performances.Length; i++)
                Console.Write($"{Performances[i]},");
            Console.WriteLine($" Средний балл: {AverageMark}");
        }
    }
}