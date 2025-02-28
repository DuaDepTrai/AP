using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250226.test
{
    internal class Storage : IStorage
    {
        private Book[] BookStore = new Book[100];
        public Book this[int index]
        {
            get
            {
                if (index < 0 || index >= BookStore.Length)
                {
                    return null;
                }
                return BookStore[index];
            }
            set
            {
                if (index < 0 || index >= BookStore.Length)
                {
                    BookStore[index] = null;
                }
                BookStore[index] = value;
            }
        }

        private int _Count = 0;
        public int Count
        {
            get { return _Count; }
            set
            {
                _Count = value;
            }
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
            book.SetDetail(name, authorName, subject, buyingPrice);
            BookStore[_Count++] = book;
        }

        public void RemoveABook(string id)
        {
            for (int i = 0; i < _Count; i++)
            {
                if (BookStore[i] != null && BookStore[i].ID.Equals(id))
                {
                    for (int j = i; j < _Count; j++)
                    {
                        BookStore[j] = BookStore[j + 1];
                        _Count--;
                        Console.WriteLine("Book removed successfully");
                    }
                }
                //else
                //{
                //    Console.WriteLine("Book not found");
                //}
            }
            //foreach (Book book in BookStore)
            //{
            //    if (book != null && book.ID.Equals(id))
            //    {
            //        BookStore.ToList().Remove(book);
            //        Console.WriteLine("Book removed successfully");
            //        break;
            //    }
            //    //else
            //    //{
            //    //    Console.WriteLine("Book not found");
            //    //}
            //}
        }

        public bool IsABook(string id)
        {
            foreach (Book book in BookStore)
            {
                if (book != null && book.ID.Equals(id))
                {
                    return true;
                }
            }
            return false;
        }

        public Storage()
        {
            _Count = 0;
            BookStore = new Book[100];
        }
    }
}
