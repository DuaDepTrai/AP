using System;
using System.Collections.Generic;
using System.Linq;
using ShopManagement;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of products the shop can store: ");
        int size = int.Parse(Console.ReadLine());
        Shop myShop = new Shop(size);

        int pick;
        do
        {
            Console.WriteLine("\nMENU:");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View All Products");
            Console.WriteLine("3. Search Products by Price Range");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            pick = int.Parse(Console.ReadLine());

            switch (pick)
            {
                case 1:
                    myShop.AddProduct();
                    break;
                case 2:
                    myShop.IterateProductList();
                    break;
                case 3:
                    myShop.SearchProduct();
                    break;
                case 4:
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        } while (pick != 4);
        Console.ReadKey();
    }
}
