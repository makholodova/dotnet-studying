using System;

namespace N_9word_f
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = GetString();
            if (str == null)
                return;

            str = RemoveSpacesFromString(str);

            var res = DoesMirror(str);

            PrintResult(str, res);
        }

        private static string GetString()
        {
            Console.WriteLine("Удалить из строки пробелы и определить, является ли она перевертышем");
            var str = Console.ReadLine();
            if (str == null)
            {
                Console.WriteLine("Строка null");
                return null;
            }

            return str;
        }

        private static string RemoveSpacesFromString(string str2)
        {
            var i = 0;
            while (i < str2.Length)
            {
                if (str2[i] == ' ')
                {
                    str2 = str2.Remove(i, 1);
                }
                else
                {
                    i++;
                }
            }

            return str2;
        }

        private static bool DoesMirror(string str)
        {
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

            return b;
        }

        private static void PrintResult(string str, bool res)
        {
            Console.WriteLine(str);
            if (res == true)
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