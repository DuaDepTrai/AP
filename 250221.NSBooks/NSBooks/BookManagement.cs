using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using NSBooks;

namespace NSBookTest
{
    internal class BookManagement
    {
        private ArrayList bookList = new ArrayList();

        public void AddBook()
        {
            Console.WriteLine("Enter Book's Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Publish Date: ");
            DateTime pbDate;
            while (!DateTime.TryParse(Console.ReadLine(), out pbDate))
            {
                Console.WriteLine("Invalid format, please try again");
            }

            Console.WriteLine("Enter Author: ");
            string author = Console.ReadLine();

            Console.WriteLine("Enter Language: ");
            string language = Console.ReadLine();

            Book book = new Book(name, pbDate, author, language);

            for (int i=0; i<5; i++)
            {
                Console.WriteLine($"Enter price in store {i}: ");
                                
            }

            bookList.Add( book );
        }

        public 
    }
}
