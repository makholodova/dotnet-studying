using System;

namespace N_6mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Число, чаще всего встречающееся в массиве");
            Console.WriteLine("Введите кол-во элементов массива");
            var nStr = Console.ReadLine();
            var n = int.Parse(nStr);
            int[] mass = new int[n];
            Console.Write("Содержимое массива: ");
            for (int i = 0; i < n; i++)
            {
                var rnd = new Random();
                var newNumber = rnd.Next(0, 10);
                mass[i] = newNumber;
                Console.Write(mass[i] + " ");
            }


            int numMax = 0;
            int Number = 0;
            for (int i = 0; i < n; i++)
            {
                int num = 1;
                var item1 = mass[i];
                for (int j = i + 1; j < n; j++)
                {
                    var item2 = mass[j];
                    if (item1 == item2)
                    {
                        num++;
                    }
                }

                if (num > numMax)
                {
                    numMax = num;
                    Number = mass[i];
                }
            }

            Console.WriteLine("\r\nЧисло, чаще всего встречающееся в массиве: " + Number + " \r\nКол-во:" + numMax);


            ;
        }
    }
}