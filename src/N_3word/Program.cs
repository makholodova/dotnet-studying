using System;

namespace N_3word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Отфильтровать из строки числа");
            var str = Console.ReadLine();
            if (str == null)
            {
                Console.WriteLine("Строка null");
                return;
            }

            int[] mass = new int[str.Length];
            string strNum = "";
            var indexStr = 0;
            var indexMass = 0;

            while (indexStr < str.Length)
            {
                if (str[indexStr] >= '0' && str[indexStr] <= '9')
                {
                    strNum += str[indexStr];
                }
                else if (strNum != "") //strNum.Length!=0 - пустая строка
                {
                    var num = int.Parse(strNum);
                    mass[indexMass] = num;
                    indexMass++;
                    strNum = "";
                }

                indexStr++;
            }

            if (strNum != "") //strNum.Length!=0 - пустая строка
            {
                var num = int.Parse(strNum);
                mass[indexMass] = num;
                indexMass++;
            }


            Console.WriteLine("Числа: ");
            for (int i = 0; i < indexMass; i++)
            {
                Console.Write(mass[i] + ", ");
            }
        }
    }
}