using System;
using System.Runtime.InteropServices;

namespace N_24mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Сжать массив, удалив элементы, принадлежащие интервалу");

            var rndN = new Random();
            var n = rndN.Next(7, 10);
            int[] mass = new int[n];

            Console.Write("Содержимое массива: ");
            int i;
            for ( i = 0; i < n; i++)
            {
                var rnd = new Random();
                var newNumber = rnd.Next(0, 9);
                mass[i] = newNumber;
                Console.Write(mass[i] + " ");
            }
            Console.WriteLine(" \r\nВведите интервал  [а, b]");
            var aStr = Console.ReadLine();
            var a = int.Parse(aStr);
            var bStr = Console.ReadLine();
            var b = int.Parse(bStr);
            Console.WriteLine("Содержимое сжатого массива: ");
             i = 0;
             int nNew = n;
            while (i<nNew)
            {
               var num=  mass[i];
               
                if (num<=b&&num>=a||num>=b&&num<=a)
                {
                    nNew--;
                    for (int j = i; j < nNew; j++)
                    {
                        mass[j] = mass[j+1];
                    }
                    
                    mass[nNew] = 0;
                }
                else
                {
                 i++;   
                }
                
            }
            for ( i = 0; i < n; i++)
            {
              Console.Write(mass[i] + " ");
            }

        }
    }
}