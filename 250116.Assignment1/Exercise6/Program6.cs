using System;
namespace DisplaySum
{
    class Program6
    {
        static int Sum1(int x) { 
            int sum = 0;
            for (int i = 1; i <= x; i++)
            {
                sum += i;
            }
            return sum;
        }

        static double Sum2(int x) { 
            double sum = 0;
            for (int i = 1; i <= x; i++) { 
                sum += 1.0/i;
            }
            return sum;
        }

        static void Main(string[] args) {
            int n;
            do {
                Console.Write("Enter N: ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("Invalid N, please try again");
                }
            } while (n<=0);

            Console.WriteLine("Sum 1 = " + Sum1(n));
            Console.WriteLine("Sum 2 = " + Sum2(n));
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}