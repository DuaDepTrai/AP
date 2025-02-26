using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookShop
{
    internal class OnlineBookShop
    {
        Storage BookStorage = new Storage();
        double profits = 0;

        public void ImportBook()
        {
            Console.Write("Enter Number of Books: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine($"---\nAdd Information of Book {i+1}:");
                BookStorage.AddANewBook();
            }
        }

        public void ShowDetail()
        {
            if (BookStorage.Count == 0)
            {
                Console.WriteLine("No Book In Store");
            }
            else
            {
                for (int i = 0; i < BookStorage.Count; i++)
                {
                    BookStorage[i].ShowDetail();
                }
            }            
        }

        public void Show()
        {
            if (BookStorage.Count == 0) {
                Console.WriteLine("No Book In Store");
            }
            else { 
            for (int i = 0;i < BookStorage.Count; i++)
                {
                    Console.WriteLine($"ID: {BookStorage[i].ID}, Name: {BookStorage[i].Name}, Author: {BookStorage[i].AuthorName}, " +
                        $"Subject: {BookStorage[i].Subject}, Selling Price: {BookStorage[i].SellingPrice}");
                }
            }
        }

        public void SellABook()
        {
            Show();

            Console.Write("Enter Book ID to Buy: ");
            string SellingID = Console.ReadLine();

            if (BookStorage.isBook(SellingID))
            {
                for (int i = 0; i < BookStorage.Count; i++)
                {
                    if (BookStorage[i].ID.Equals(SellingID))
                    {
                        profits += BookStorage[i].SellingPrice - BookStorage[i].BuyingPrice;
                        BookStorage.RemoveABook(SellingID);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book not found");
            }
        }

        public void ChangeSellingPrice()
        {
            ShowDetail();

            Console.Write("Enter Book ID to Change Selling Price: ");
            string ChangedID = Console.ReadLine();

            if (BookStorage.isBook(ChangeID))
            {
                for (int i = 0; i <= BookStorage.Count; i++)
                {
                    if (BookStorage[i].ID.Equals(ChangedID))
                    {
                        Console.Write("Enter New Selling Price: ");
                        double newPrice;
                        while (!double.TryParse(Console.ReadLine(), out newPrice))
                        {
                            Console.WriteLine("Invalid input, please try again");
                        }
                        BookStorage[i].SetSellingPrice(newPrice);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book not found");
            }
        }

        public void ShowProfits()
        {
            Console.WriteLine($"Total Profits: {profits}");
        }
    }
}
