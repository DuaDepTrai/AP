using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookShop
{
    internal class Program
    {
        static void Main()
        {
            IBook theBook = new Book();

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

            theBook.SetDetail(name, authorName, subject, buyingPrice);
            theBook.ShowDetail();
        }
    }
}
