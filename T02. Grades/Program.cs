using System;

namespace T02._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            PrintGrade(grade);
        }

        static void PrintGrade(double grade)
        {
            //• 2.00 – 2.99 - "Fail"
            //• 3.00 – 3.49 - "Poor"
            //• 3.50 – 4.49 - "Good"
            //• 4.50 – 5.49 - "Very good"
            //• 5.50 – 6.00 - "Excellent"

            if (grade >= 2 && grade < 3)
            {
                Console.WriteLine("Fail");
            }
            else if (grade >= 3 && grade < 3.50)
            {
                Console.WriteLine("Poor");
            }
            else if (grade >= 3.50 && grade < 4.50)
            {
                Console.WriteLine("Good");
            }
            else if (grade >= 4.50 && grade < 5.50)
            {
                Console.WriteLine("Very good");
            }
            else if (grade >= 5.50 && grade <= 6)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
