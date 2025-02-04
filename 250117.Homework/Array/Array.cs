using System;
using System.Collections.Generic;
namespace Array
{
    class Program1
    {
        // Revered Array
        static void ReversedArray(List<int> array)
        {
            array.Reverse();
            Console.WriteLine("Reversed Array: ");
            PrintArray(array);
        }

        // Min Element
        static void MinElement(List<int> array)
        {
            int min = int.MaxValue;
            foreach (int num in array)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            Console.WriteLine("Min = " + min);
        }

        // Max Element
        static void MaxElement(List<int> array)
        {
            int max = int.MinValue;
            foreach (int num in array)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine("Max = " + max);
        }

        // Sort Array Ascending
        static void SortArrayAscending(List<int> array)
        {
            array.Sort();

            Console.WriteLine("Sorted Array: ");
            PrintArray(array);
        }

        // Find Second Largest Element
        static void SecondLargestElement(List<int> array)
        {
            if (array.Count < 2)
            {
                Console.WriteLine("Array must have at least 2 elements!");
                return;
            }

            int max1 = int.MinValue; int max2 = int.MinValue;

            foreach (int num in array)
            {
                if (num > max1)
                {
                    max2 = max1;
                    max1 = num;
                }
                else if (num > max2 && num < max1)
                {
                    max2 = num;
                }
            }

            if (max2 == int.MinValue)
            {
                Console.WriteLine("No second largest element (all elements are the same).");
            }
            else
            {
                Console.WriteLine("Second largest element: " + max2);
            }
        }

        // Insert Element To Array
        static void InsertElement(List<int> array)
        {
            Console.Write("Enter Possition Of New Element: ");
            int pos = int.Parse(Console.ReadLine());

            if (pos < 0 || pos > array.Count)
            {
                Console.WriteLine("Invalid position.");
                return;
            }

            Console.Write("Enter New Element: ");
            int value = int.Parse(Console.ReadLine());

            array.Insert(pos, value);

            Console.WriteLine("New Array: ");
            PrintArray(array);
        }

        // Remove Element From Array
        static void RemoveElement(List<int> array)
        {
            Console.Write("Enter Possition Of Removed Element: ");
            int pos = int.Parse(Console.ReadLine());
            if (pos < 0 || pos >= array.Count)
            {
                Console.WriteLine("Invalid position.");
                return;
            }

            array.RemoveAt(pos);

            Console.WriteLine("New Array: ");
            PrintArray(array);
        }

        // Print Array
        static void PrintArray(List<int> arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        // MAIN PROGRAM
        static void Main(string[] args)
        {
            // Import Array
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            List<int> array = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("A[" + i + "] = ");
                array.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("\nArray: ");
            PrintArray(array);

            //MENU
            int pick;
            do
            {
                Console.WriteLine("\n=====\nMENU: ");
                Console.WriteLine("1. Reverse Array");
                Console.WriteLine("2. Max Value");
                Console.WriteLine("3. Min Value");
                Console.WriteLine("4. Sort Array");
                Console.WriteLine("5. Find 2nd Largest Element");
                Console.WriteLine("6. Insert New Element");
                Console.WriteLine("7. Remove Element");
                Console.WriteLine("8. Exit");
                Console.Write("\nEnter your choice: ");

                pick = int.Parse(Console.ReadLine());

                switch (pick)
                {
                    case 1:
                        ReversedArray(array);
                        break;
                    case 2:
                        MaxElement(array);
                        break;
                    case 3:
                        MinElement(array);
                        break;
                    case 4:
                        SortArrayAscending(array);
                        break;
                    case 5:
                        SecondLargestElement(array);
                        break;
                    case 6:
                        InsertElement(array);
                        break;
                    case 7:
                        RemoveElement(array);
                        break;
                    case 8:
                        Console.WriteLine("Exit Program");
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again");
                        break;
                }
            } while (pick != 8);
        }
    }
}