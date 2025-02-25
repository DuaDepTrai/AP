using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookShop
{
    internal class Storage : IStorage
    {
        private int _Count = 0;
        private Book[] BookStore = new Book[100];

        public Storage() 
        {
            _Count = 0;
            BookStore = new Book[100];
        }

        public Book this[int index] 
        { 
            get { return BookStore[index]; } 
            set { BookStore[index] = value; } 
        }

        public int Count 
        {
            get { return _Count; }
            set { _Count = value; }
        }

        public void AddANewBook()
        {
            Console.Write("Enter Name Of Book: ");
            string name = Console.ReadLine();

            Console.Write("Enter Author Name: ");
            string authorName = Console.ReadLine();

            Console.Write("Enter Subject: ");
            string subject = Console.ReadLine();

            Console.Write("Enter Buying Price: ");
            double buyingPrice;
            while (!double.TryParse(Console.ReadLine(), out buyingPrice))
            {
                Console.WriteLine("Invalid input, please try again");
            }

            Book book = new Book();
            book.SetDetail(name, authorName,subject, buyingPrice);
            BookStore[_Count++] = book;
        }

        public bool isBook(string id)
        {
            for (int i = 0; i < _Count; i++)
            {
                if (BookStore[i] != null && BookStore[i].ID.Equals(id))
                {
                    return true;
                }
            }
            return false;
        }

        public void RemoveABook(string id)
        {
            for (int i = 0; i < _Count; i++) 
            {
                if (BookStore[i] != null && BookStore[i].ID.Equals(id)) 
                {
                    for (int j = i; j < _Count; j++)
                    {
                        BookStore[j] = BookStore[j+1];
                        _Count--;
                        Console.WriteLine("Book removed successfully");
                    }
                }
                else
                {
                    Console.WriteLine("Book not found");
                }
            }
        }
    }
}
