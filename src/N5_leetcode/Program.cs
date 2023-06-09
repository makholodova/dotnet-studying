using System;

namespace N5_leetcode;

internal class Program
{
    /*Учитывая целое число x, вернуть, true если x это
    палиндром, и false в противном случае .*/

    private static void Main(string[] args)
    {
        var xStr = Console.ReadLine();
        var x = int.Parse(xStr);
        var mass = x.ToString();
        var bools = true;
        for (var i = 0; i < mass.Length / 2; i++)
            if (mass[i] != mass[mass.Length - 1 - i])
                bools = false;


        Console.WriteLine(bools);
    }
}