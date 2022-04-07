using System;

namespace N_17mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Разложить положительные и отрицательные числа по разным массивам");
            var rndN = new Random();
            var n = rndN.Next(0, 10);

            Console.Write("\r\nCгенерированные случайные числа: ");
            int[] rand = new int[n];
            for (int i = 0; i < n; i++)
            {
                var rnd = new Random();
                var newNum = rnd.Next(-5, 6);
                rand[i] = newNum;
                Console.Write(rand[i] + " ");
            }

            int[] massPozitiv = new int[n];
            int[] massNegativ = new int[n];
            var indPozitiv = 0;
            var indexNegativ = 0;
            for (int i = 0; i < n; i++)
            {
                var num = rand[i];
                if (num > 0)
                {
                    massPozitiv[indPozitiv] = num;
                    indPozitiv++;
                }
                else if (num < 0)
                {
                    massNegativ[indexNegativ] = num;
                    indexNegativ++;
                }
            }

            Console.WriteLine("\r\nПоложительный массив: ");
            for (int i = 0; i < indPozitiv; i++)
            {
                Console.Write(massPozitiv[i] + " ");
            }

            Console.WriteLine("\r\nОтрицательный массив: ");
            for (int i = 0; i < indexNegativ; i++)
            {
                Console.Write(massNegativ[i] + " ");
            }
        }
    }
}