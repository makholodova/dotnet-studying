using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var calculator = new SimpleCalculator();
                double res = 0;
                var num1 = ConsoleHelper.EnterValue();
                var num2 = ConsoleHelper.EnterValue();
                var sign = ConsoleHelper.EnterOperator(); //разобраться
                if (sign == '+')
                {
                    res = calculator.Addition(num1, num2);
                }
                else if (sign == '-')
                {
                    res = calculator.Subtraction(num1, num2);
                }
                else if (sign == '*')
                {
                    res = calculator.Multiplication(num1, num2);
                }

                else if (sign == '/')
                {
                    res = calculator.Division(num1, num2);
                }

                ConsoleHelper.PrintResult(res);

                ///bool cont = ConsoleHelper.ShouldContinue() ;
                /// 
                if (ConsoleHelper.ShouldContinue() == false)
                {
                    break;
                }
            }
        }
    }
}