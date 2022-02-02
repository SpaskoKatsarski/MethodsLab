using System;

namespace T10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            num = Math.Abs(num);

            int evenSum = GetEvenSum(num);
            int oddSum = GetOddSum(num);

            Console.WriteLine(GetMultiplication(evenSum, oddSum));
        }

        static int GetEvenSum(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                int currentDigit = number % 10;

                if (currentDigit % 2 == 0)
                {
                    sum += currentDigit;
                }

                number /= 10;
            }

            return sum;
        }

        static int GetOddSum(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                int currentDigit = number % 10;

                if (currentDigit % 2 == 1)
                {
                    sum += currentDigit;
                }

                number /= 10;
            }

            return sum;
        }

        static int GetMultiplication(int first, int second)
        {
            return first * second;
        }
    }
}
