using System;

namespace FullNameProcessor
{
    class Program7
    {
        static void ProcessFullName()
        {
            Console.Write("Enter your full name: ");
            string fullName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(fullName))
            {
                Console.WriteLine("Invalid input. Please enter a valid name.");
                return;
            }

            string[] nameParts = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Name parts:");
            foreach (string part in nameParts)
            {
                Console.WriteLine(part);
            }

            Console.WriteLine($"Number of words in full name: {nameParts.Length}");
        }

        static void Main(string[] args)
        {
            ProcessFullName();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
