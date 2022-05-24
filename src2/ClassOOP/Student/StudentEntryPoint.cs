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
                students[i].CalculateTheAverageMark();

            //экземпляров класс может быть создано много
            
            StudentsPrintContent(students);

            // students[0].PrintContent(); //обращение к экзепляру класса
            //students[1].PrintContent(); //обращение к экзепляру класса

            //класс только один
            //Student.PrintContent(); //обращение к классу

            Console.WriteLine("Упорядочить записи по возрастанию среднего балла");
            
            SortByAverageMark(students);
            
            StudentsPrintContent(students);
            
            Console.WriteLine("Cписок студентов, имеющих оценки, равные только 4 или 5:");

            for (var i = 0; i < students.Length; i++)
            {
                var good = students[i].FindGoodMark();
                if (good) students[i].PrintContent();
            }
        }

        private static void StudentsPrintContent(Student[] students)
        {
            for (var i = 0; i < students.Length; i++) students[i].PrintContent();
        }

        private static void CreateStudents(Student[] students)
        {
            students[0] = new Student
            {
                SurnameAndInitials = "Иванов В.И",
                NumberGroup = 202001,
                Performances = new[]
                    {3, 3, 2, 4, 5}
            };
            students[1] = new Student
            {
                SurnameAndInitials = "Петров Р.П",
                NumberGroup = 202001,
                Performances = new[]
                    {5, 4, 4, 4, 5}
            };
            students[2] = new Student
            {
                SurnameAndInitials = "Ткаченко В.Н",
                NumberGroup = 202002,
                Performances = new[]
                    {5, 4, 5, 5, 5}
            };
            students[3] = new Student
            {
                SurnameAndInitials = "Холодов Р.Д",
                NumberGroup = 202003,
                Performances = new[]
                    {5, 5, 5, 5, 5}
            };
            students[4] = new Student
            {
                SurnameAndInitials = "Семенов А.П",
                NumberGroup = 202001,
                Performances = new[]
                    {3, 4, 2, 3, 3}
            };
            students[5] = new Student
            {
                SurnameAndInitials = "Дудко В.С",
                NumberGroup = 202003,
                Performances = new[]
                    {5, 4, 3, 3, 3}
            };
            students[6] = new Student
            {
                SurnameAndInitials = "Гейко Т.И",
                NumberGroup = 202002,
                Performances = new[]
                    {5, 3, 4, 4, 5}
            };
            students[7] = new Student
            {
                SurnameAndInitials = "Морозов Н.У",
                NumberGroup = 202003,
                Performances = new[]
                    {3, 4, 5, 5, 4}
            };
            students[8] = new Student
            {
                SurnameAndInitials = "Николаев Н.Б",
                NumberGroup = 202002,
                Performances = new[]
                    {4, 4, 3, 3, 5}
            };
            students[9] = new Student
            {
                SurnameAndInitials = "Кудрин Ф.М",
                NumberGroup = 202001,
                Performances = new[]
                    {5, 4, 4, 5, 5}
            };
        }

        private static void SortByAverageMark(Student[] students)
        {
            for (var i = 0; i < students.Length; i++)
            for (var j = 0; j < students.Length - i - 1; j++)
            {
                var student1 = students[j];
                var averageMark1 = student1.AverageMark;
                var student2 = students[j + 1];
                var averageMark2 = student2.AverageMark;
                if (averageMark1 > averageMark2)
                {
                    students[j] = student2;
                    students[j + 1] = student1;
                }
            }
        }
        
    }
}