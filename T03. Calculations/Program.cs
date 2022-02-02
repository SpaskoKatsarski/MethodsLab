using System;

namespace T03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (command == "add")
            {
                Console.WriteLine(AddNumbers(firstNumber, secondNumber));
            }
            else if (command == "multiply")
            {
                Console.WriteLine(MultiplyNumbers(firstNumber, secondNumber));
            }
            else if (command == "substract")
            {
                Console.WriteLine(SubstractNumbers(firstNumber, secondNumber));
            }
            else
            {
                Console.WriteLine(DivideNumbers(firstNumber, secondNumber));
            }
        }

        static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        static int MultiplyNumbers(int a, int b)
        {
            return a * b;
        }

        static int SubstractNumbers(int a, int b)
        {
            return a - b;
        }

        static int DivideNumbers(int a, int b)
        {
            return a / b;
        }
    }
}
