using System;

namespace ProductManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Products objProduct = new Products();
            objProduct.SetDetail(name, quantity);

            Console.WriteLine("\nProduct Information:");
            Console.WriteLine("ID         Name                 Quantity");
            objProduct.ShowDetail();

            Console.Write("\nEnter More Quantity to Add: ");
            int moreQuantity = int.Parse(Console.ReadLine());

            objProduct.AddQuantity(moreQuantity);

            Console.WriteLine("\nProduct Information after Update:");
            Console.WriteLine("ID         Name                 Quantity");
            objProduct.ShowDetail();
        }
    }
}
