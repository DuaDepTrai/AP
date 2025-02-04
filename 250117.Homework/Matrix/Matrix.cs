using System;
namespace Matrix
{
    class Matrix
    {
        //Sum Main Diagonal
        static void mainDiagonalSum(int[,] a, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += a[i, i];
            }
            Console.WriteLine("Sum of Main Diagonal: " + sum);
        }

        // Sum Rows & Columns
        static void sumRowCol(int[,] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum += a[i, j];
                }
                Console.WriteLine("Sum Row " + i + " = " + sum);
            }

            for (int j = 0; j < n; j++)
            {
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum += a[i, j];
                }
                Console.WriteLine("Sum Col " + j + " = " + sum);
            }
        }

        //MAIN PROGRAM
        static void Main(string[] args)
        {
            // Import Matrix
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            int[,] array = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("A[" + i + ", " + j + "] = ");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMatrix: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //MENU
            int pick;
            do
            {
                Console.WriteLine("\nMENU: ");
                Console.WriteLine("1. Sum of Main Diagonal");
                Console.WriteLine("2. Sum of Row & Col");
                Console.WriteLine("3. Exit");
                Console.Write("\nEnter your choice: ");
                pick = int.Parse(Console.ReadLine());

                switch (pick)
                {
                    case 1:
                        mainDiagonalSum(array, n);
                        break;
                    case 2:
                        sumRowCol(array, n);
                        break;
                    case 3:
                        Console.WriteLine("Exit Program");
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again");
                        break;
                }
            } while (pick != 3);
        }
    }
}