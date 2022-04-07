using System;

namespace N__8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Посчитать общее колличество определенных цифр в числах"); //для остановки ввести "0"
            Console.WriteLine("Введите цифру ");
            var nStr = Console.ReadLine();
            var n = int.Parse(nStr);
            Console.WriteLine("Введите числа ");
            int r = 0;
            for (;;)
            {
                var numStr = Console.ReadLine();
                var num = int.Parse(numStr);

                if (num != 0)
                {
                    int m = num;
                    while (m > 0)
                    {
                        int ost = m % 10;
                        m = m / 10;

                        if (ost == n)
                        {
                            r++;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Цифра " + n + " повторяется " + r + " раз(а)");
                    return;
                }
            }
        }
    }
}