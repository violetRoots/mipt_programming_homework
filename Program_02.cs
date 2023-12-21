using System;


namespace HW1
{
     class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            try
            {
                Console.WriteLine("Case 1:");
                a = double.Parse(Console.ReadLine());

                Console.WriteLine("Case 2:");
                b = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Plese enter only numbers");
                return;
            }

            Console.WriteLine($"Sum: {a + b}");
            Console.WriteLine($"Diff: {a - b}");
            Console.WriteLine($"Mult: {a * b}");

            if (b == 0)
                Console.WriteLine("Div: Error");
            
            else
                Console.WriteLine($"Div: {a / b}");
        }
    }
}
