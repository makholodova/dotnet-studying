using System;

namespace N_9word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Удалить из строки пробелы и определить, является ли она перевертышем");
            var str = Console.ReadLine();
            if (str == null)
            {
                Console.WriteLine("Строка null");
                return;
            }

            var i = 0;
            while (i < str.Length)
            {
                if (str[i] == ' ')
                {
                    str = str.Remove(i, 1);
                }
                else
                {
                    i++;
                }
            }

            var b = true;
            
            for (int j = 0; j < str.Length / 2; j++)
            {
                if (str[j] == str[str.Length - 1 - j])
                {
                    b = true;
                }
                else
                {
                    b = false;
                    break;
                }
            }

            Console.WriteLine(str);
            if (b == true)
            {
                Console.WriteLine("Строка является перевертышем");
            }
            else 
            {
                Console.WriteLine("Строка не является перевертышем");
            }
        }
    }
}