namespace Calculator.Core
{
    public class SimpleCalculator
    {
        public double Addition(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Division(double num1, double num2)
        {
            return num1 / num2;
        }

        public double Solve(char sign, double num1, double num2)
        {
            double res = 0;
            if (sign == '+')
                res = Addition(num1, num2);
            else if (sign == '-')
                res = Subtraction(num1, num2);
            else if (sign == '*')
                res = Multiplication(num1, num2);

            else if (sign == '/') res = Division(num1, num2);

            return res;
        }
    }
}