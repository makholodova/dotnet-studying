using System;

namespace N6_leetcode;

internal class Program
{
    /*Вам дано большое целое число , представленное в виде массива целых чисел digits,
     где каждое число digits[i]является цифрой целого числа. Цифры упорядочены от наиболее значащего 
     к наименее значащему в порядке слева направо. Большое целое число не содержит начальных символов .ith0
    Увеличьте большое целое число на единицу и верните результирующий массив цифр .*/

    private static void Main(string[] args)
    {
        var nStr = Console.ReadLine();
        var n = int.Parse(nStr);

        var digits = new int[n];
        for (var i = 0; i < n; i++)
        {
            var numStr = Console.ReadLine();
            var num = int.Parse(numStr);
            digits[i] = num;
        }

        var j = digits.Length - 1;
        while (digits[j] == 9)
        {
            digits[j] = 0;

            if (j == 0)
            {
                var newDigits = new int[digits.Length + 1];
                newDigits[0] = 1;
                for (var i = 0; i < newDigits.Length; i++) Console.WriteLine(newDigits[i]);
            }

            j--;
        }


        digits[j] += 1;


        for (var i = 0; i < digits.Length; i++) Console.WriteLine(digits[i]);
    }
}