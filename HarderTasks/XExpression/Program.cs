using System;

namespace XExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();

            decimal result = 0;

            int index = 0;
            char symbol = expression[0];
            char operation = '+';

            while (symbol != '=')
            {
                if (symbol == '(')
                {
                    decimal innerResult = Parentases(ref expression, ref symbol, ref index);

                    switch (operation)
                    {
                        case '+':
                            result += innerResult;
                            break;
                        case '-':
                            result -= innerResult;
                            break;
                        case '*':
                            result *= innerResult;
                            break;
                        case '/':
                            result /= innerResult;
                            break;
                    }

                }
                else if (char.IsDigit(symbol))
                {
                    Switch(operation, ref result, symbol);
                }
                else
                {
                    operation = symbol;
                }

                index++;
                symbol = expression[index];
            }

            Console.WriteLine($"{result:0.00}");
        }

        private static decimal Parentases(ref string expression, ref char symbol, ref int index)
        {
            decimal innerResult = 0;
            char innerOperator = '+';
            index++;
            symbol = expression[index];

            while (symbol != ')')
            {
                if (char.IsDigit(symbol))
                {
                    Switch(innerOperator, ref innerResult, symbol);
                }
                else
                {
                    innerOperator = symbol;
                }

                index++;
                symbol = expression[index];
            }

            return innerResult;
        }

        private static void Switch(char operation, ref decimal result, char symbol)
        {

            switch (operation)
            {
                case '+':
                    result += symbol - '0';
                    break;
                case '-':
                    result -= symbol - '0';
                    break;
                case '*':
                    result *= symbol - '0';
                    break;
                case '/':
                    result /= symbol - '0';
                    break;
            }
        }
    }
}