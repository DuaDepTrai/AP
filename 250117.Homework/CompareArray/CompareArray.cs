using System;
using System.Linq;
using System.Collections.Generic;
namespace CompareArray
{
    class CompareArray
    {
        static void Main()
        {
            // Import Array A
            Console.Write("Enter size of array A: ");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];

            Console.WriteLine("Enter elements of array A:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"A[{i}] = ");
                A[i] = int.Parse(Console.ReadLine());
            }

            // Import Array B
            Console.Write("Enter size of array B: ");
            int m = int.Parse(Console.ReadLine());
            int[] B = new int[m];

            Console.WriteLine("Enter elements of array B:");
            for (int i = 0; i < m; i++)
            {
                Console.Write($"B[{i}] = ");
                B[i] = int.Parse(Console.ReadLine());
            }

            // Array 1: A & B
            int[] commonElements = A.Intersect(B).ToArray();

            // Array 2: A not B
            int[] onlyInA = A.Except(B).ToArray();

            // Array 3: B not A
            int[] onlyInB = B.Except(A).ToArray();

            // Print Result
            Console.WriteLine("\nArray 1 (Common Elements): " + string.Join(" ", commonElements));
            Console.WriteLine("Array 2 (Elements in A but not in B): " + string.Join(" ", onlyInA));
            Console.WriteLine("Array 3 (Elements in B but not in A): " + string.Join(" ", onlyInB));

            Console.ReadKey();
        }
    }

}
