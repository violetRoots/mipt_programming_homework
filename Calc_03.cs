using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            bool aValid, bValid;

            while (true)
            {
                do
                {
                    Console.WriteLine("Case 1:");
                    aValid = double.TryParse(Console.ReadLine(), out a);

                    if (!aValid)
                    {
                        Console.WriteLine("Invalid input for variable 1. Please enter a valid number.");
                    }
                } while (!aValid);

                do
                {
                    Console.WriteLine("Case 2:");
                    bValid = double.TryParse(Console.ReadLine(), out b);
                    if (!bValid)
                    {
                        Console.WriteLine("Invalid input for variable 2. Please enter a valid number.");
                    }
                } while (!bValid);

                Console.WriteLine($"Sum: {a + b}");
                Console.WriteLine($"Diff: {a - b}");
                Console.WriteLine($"Mult: {a * b}");

                if (b != 0)
                    Console.WriteLine($"Div: {a / b)}";
                else
                    Console.WriteLine("Div: Error ");

                Console.WriteLine("-----");
            }
        }
    }
}
