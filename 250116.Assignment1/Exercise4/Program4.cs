using System;
namespace checkCharacter
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a character: ");
            string input = Console.ReadLine();

            if (input.Length == 1)
            {
                char inputChar = input[0];

                if ("ueoaiUEOAI".Contains(inputChar))
                {
                    Console.WriteLine("This is a Vowel");
                }
                else
                {
                    Console.WriteLine("This is not a Vowel");
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please try again");
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}