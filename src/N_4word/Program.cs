using System;

namespace N_4word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Является ли строка идентификатором!");
            var str = Console.ReadLine();
            if (str == null)
            {
                Console.WriteLine("Строка null");
                return;
            }

            var ind = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z' ||
                    str[i] >= 'A' && str[i] <= 'Z' ||
                    str[i] >= '0' && str[i] <= '9' ||
                    str[i] == '_')
                {
                    ind = true;
                }
                else
                {
                    ind = false;
                    break;
                }
            }

            if (ind == true)
            {
                if (str[0] >= 'a' && str[0] <= 'z' ||
                    str[0] >= 'A' && str[0] <= 'Z' ||
                    str[0] == '_')
                {
                    Console.WriteLine("Строка является идентификатором");
                    return;
                }
            }

            Console.WriteLine("Строка не является идентификатором");
        }
    }
}