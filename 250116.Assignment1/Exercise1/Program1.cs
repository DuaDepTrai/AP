using System;

namespace StudentNameApp
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Student's Name: ");
            string studentName = Console.ReadLine();

            Console.WriteLine("Student's Name: " + studentName);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
