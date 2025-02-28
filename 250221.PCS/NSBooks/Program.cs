using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSBookTest;

namespace NSBooksApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookManagement manager = new BookManagement();
            int pick;

            do
            {
                Console.WriteLine("=====\nBOOK MANAGEMENT SYSTEM:");
                Console.WriteLine("1. Add New Book");
                Console.WriteLine("2. View List of Books");
                Console.WriteLine("3. Average Price");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                pick = int.Parse(Console.ReadLine());

                switch (pick) 
                {
                    case 1:
                        manager.AddBook();
                        break;
                    case 2:
                        manager.DisplayBooks();
                        break;
                    case 3:
                        manager.CalculateAveragePrice(); 
                        break;
                    case 4:
                        Console.WriteLine("Exiting... Thank you!");
                        break;
                    default:
                        Console.WriteLine("Invalid input, try again");
                        break;
                }
            } while (pick != 4);
        }
    }
}
