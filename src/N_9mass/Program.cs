using System;

namespace N_9mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сдвиг массива");

            var Indx = 10;
            int[] mass = new int[Indx];

            Console.Write("Указать направление и число шагов: "); //"-"-влево, "+" вправо
            var augmentStr = Console.ReadLine();
            var augment = int.Parse(augmentStr);


            Console.Write("Содержимое массива: ");

            for (int i = 0; i < Indx; i++)
            {
                var rnd = new Random();
                var newNumber = rnd.Next(1, 7);
                mass[i] = newNumber;
                Console.Write(mass[i] + " ");
            }

            Console.Write("\r\nСдвиг массива: ");

            int augmAbs = Math.Abs(augment);
            for (int i = 0; i < augmAbs; i++)
            {
                Console.WriteLine();
                if (augment < 0)
                {
                    for (int j = 0; j < Indx - 1; j++)
                    {
                        mass[j] = mass[j + 1];
                    }

                    mass[Indx - 1] = 0;
                }

                else
                {
                    for (int j = Indx - 1; 0 < j; j--)
                    {
                        mass[j] = mass[j - 1];
                    }

                    mass[0] = 0;
                }

                for (int j = 0; j < Indx; j++)
                {
                    Console.Write(mass[j] + " ");
                }
            }
        }
    }
}