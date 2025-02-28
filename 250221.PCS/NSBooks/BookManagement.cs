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
        private Dictionary<int, IBook> bookList = new Dictionary<int, IBook>();

        public void AddBook()
        {
            Console.Write("Enter Book's Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Publish Date: ");
            DateTime pbDate;
            while (!DateTime.TryParse(Console.ReadLine(), out pbDate))
            {
                Console.WriteLine("Invalid format, please try again");
            }

            Console.Write("Enter Author: ");
            string author = Console.ReadLine();

            Console.Write("Enter Language: ");
            string language = Console.ReadLine();

            Book book = new Book(name, pbDate, author, language);



            for (int i=0; i<5; i++)
            {
                Console.Write($"Enter price in store {i+1}: ");
                int price;
                while (!int.TryParse(Console.ReadLine(),out price) || price < 0) 
                { 
                    Console.WriteLine("Invalid price, try again"); 
                }
                book[i] = price;
            }

            bookList[book.ID] = book;
            Console.WriteLine($"Book ID {book.ID} added successfully");
        }

        public void DisplayBooks()
        {
            if (bookList.Count == 0)
            {
                Console.WriteLine("No books avaiable");
                return;
            }

            foreach (var book in bookList.Values) 
            {
                book.Display();
            }
        }

        public void CalculateAveragePrice()
        {
            foreach (Book book in bookList.Values)
            {
                book.Calculate();
                book.Display();
            }
        }
    }
}
