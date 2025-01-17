using System;
namespace TriangleNumber
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    if (j <= i)
                    {
                        Console.Write(j);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}