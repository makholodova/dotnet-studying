using System;
using System.Runtime.InteropServices;

namespace N_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();

            var newNumber = rnd.Next(0, 100);
            Console.WriteLine("Сгенерировано число:" + newNumber); //для проверки
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Отгадайте число");
                var numStr = Console.ReadLine();
                var num = int.Parse(numStr);
                if (num == newNumber)
                {
                    Console.WriteLine("Число угадано!!!");
                }
                else if (num < newNumber)
                {
                    Console.WriteLine("Число больше введенного");
                }
                else if (num > newNumber)
                {
                    Console.WriteLine("Число меньше введенного");
                }
            }

            Console.WriteLine("Сгенерировано число:" + newNumber);
        }
    }
}