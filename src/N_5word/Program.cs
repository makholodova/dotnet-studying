using System;

namespace N_5word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Удаление лишних пробелов");
            var str = Console.ReadLine();
            if (str==null)
            {
                Console.WriteLine("Строка null");
                return;
            }
            var cha = ' ';
            
            var i = 0;
            while (str[i] == cha)
            {
                str = str.Remove(0, 1);
            }

            while (str[str.Length - 1] == cha)
            {
                str = str.Remove(str.Length - 1, 1);
            }

            i = 1;
            while (i < str.Length)
            {
                if (str[i] == cha && str[i + 1] == cha)
                {
                    //str = str.Remove(i , 1);
                    str = str.Substring(0, i + 1) + str.Substring(i + 2, str.Length - i - 2);
                }
                else
                {
                    i++;
                }
            }
            
            Console.WriteLine("'" + str + "'");


            //str = str.Remove(6, 1);
            // str = str.Substring(0, 6)  + str.Substring(0, 6);
            // char[] arr = str.ToCharArray();
            //arr[2] = 'h';
            // var newStr = arr.ToString();
            //  str.Re[i] = str[i + 1];
        }
    }
}