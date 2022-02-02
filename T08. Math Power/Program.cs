using System;

namespace T08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine(PowerNumber(firstNumber, secondNumber));
        }

        static double PowerNumber(double @base, double power)
        {
            double poweredNumber = Math.Pow(@base, power);
            return poweredNumber;
        }
    }
}
