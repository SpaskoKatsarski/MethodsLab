using System;

namespace T05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            CalculateOrder(product, quantity);
        }

        static void CalculateOrder(string type, int quantity)
        {
            //    • coffee – 1.50
            //    • water – 1.00
            //    • coke – 1.40
            //    • snacks – 2.00

            double totalPrice = 0;

            if (type == "coffee")
            {
                totalPrice = 1.50 * quantity;
            }
            else if (type == "water")
            {
                totalPrice = 1.00 * quantity;
            }
            else if (type == "coke")
            {
                totalPrice = 1.40 * quantity;
            }
            else if (type == "snacks")
            {
                totalPrice = 2.00 * quantity;
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
