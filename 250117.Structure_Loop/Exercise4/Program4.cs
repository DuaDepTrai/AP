using System;
namespace TriangleStar
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {
                for (int j = 1; j <= N; j++) {
                    if (j <= i) { 
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}