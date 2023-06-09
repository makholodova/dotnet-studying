using System;

namespace N3_leetcode;

internal class Program
{
    /*Существует язык программирования всего с четырьмя операциями и одной переменной X:
      ++Xи X++ увеличивает значение переменной Xна 1.
      --Xи X-- уменьшает значение переменной Xна 1.
      Изначально значение Xравно 0.
      Учитывая массив строк , содержащихoperations список операций, вернуть окончательное значение X после выполнения всех операций .*/


    private static void Main(string[] args)
    {
        var x = 0;
        var operations = new string[4];
        for (var i = 0; i < operations.Length; i++)
        {
            if (operations[i] == "X++" || operations[i] == "++X") x++;

            if (operations[i] == "X--" || operations[i] == "--X") x--;
        }
    }
}