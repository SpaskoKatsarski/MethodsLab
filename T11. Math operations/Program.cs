using System;

namespace T11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            char @operator = char.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(firstNumber, @operator, secondNumber));
        }

        static double Calculate(double numOne, char @operator, double numTwo)
        {
            double result = 0;

            switch (@operator)
            {
                case '/':
                    result = numOne / numTwo;
                    break;
                case '*':
                    result = numOne * numTwo;
                    break;
                case '+':
                    result = numOne + numTwo;
                    break;
                default:
                    result = numOne - numTwo;
                    break;
            }

            return result;
        }
    }
}
