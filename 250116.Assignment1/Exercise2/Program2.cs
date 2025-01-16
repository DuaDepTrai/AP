using System;
namespace OddEvenNumber
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 1)
            {
                Console.WriteLine(number + " is odd");
            }
            else
            {
                Console.WriteLine(number + " is even");
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
