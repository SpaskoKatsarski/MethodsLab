using System;
using System.Text;

namespace T07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string @string = Console.ReadLine();
            int repeatingTimes = int.Parse(Console.ReadLine());

            Console.WriteLine(PrintRepeatedString(@string, repeatingTimes));
        }

        static StringBuilder PrintRepeatedString(string givenString, int times)
        {
            StringBuilder repeatedString = new StringBuilder();

            for (int i = 0; i < times; i++)
            {
                repeatedString.Append(givenString);
            }

            return repeatedString;
        }
    }
}
