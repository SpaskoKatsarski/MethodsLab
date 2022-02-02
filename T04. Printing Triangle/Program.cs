using System;

namespace T04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int topOfTriangle = int.Parse(Console.ReadLine());

            for (int i = 1; i <= topOfTriangle; i++)
            {
                PrintLine(1, i);
            }

            for (int i = topOfTriangle - 1; i >= 1; i--)
            {
                PrintDescendingLine(1, i);
            }

        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }

        static void PrintDescendingLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
    }
}
