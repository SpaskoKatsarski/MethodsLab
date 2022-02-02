using System;

namespace T09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int numOne = int.Parse(Console.ReadLine());
                int numTwo = int.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(numOne, numTwo));
            }
            else if (type == "char")
            {
                char charOne = char.Parse(Console.ReadLine());
                char charTwo = char.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(charOne, charTwo));
            }
            else
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();

                Console.WriteLine(GetMax(firstString, secondString));
            }
        }

        static int GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }

        static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }

        static string GetMax(string textOne, string textTwo)
        {
            if (string.Compare(textOne, textTwo) > 0)
            {
                return textOne;
            }
            else
            {
                return textTwo;
            }
        }
    }
}
