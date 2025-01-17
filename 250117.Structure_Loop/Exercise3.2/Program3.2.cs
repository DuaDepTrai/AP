using System;
namespace DisplaySum
{
    class Program6
    {
        static double Sum(int x)
        {
            double sum = 0;
            for (int i = 1; i <= x; i++)
            {
                sum += 1.0 / i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Enter N: ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("Invalid N, please try again");
                }
            } while (n <= 0);

            Console.WriteLine("Sum = " + Sum(n));
            Console.ReadKey();
        }
    }
}