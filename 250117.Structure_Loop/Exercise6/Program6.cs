using System;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of Fibonacci terms (n): ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Invalid input! n must be a positive integer.");
            }
            else
            {
                Console.WriteLine($"The first {n} terms of the Fibonacci sequence are:");
                PrintFibonacci(n);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static void PrintFibonacci(int n)
        {
            int a = 0, b = 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                int temp = a + b; 
                a = b; 
                b = temp;
            }
        }
    }
}
