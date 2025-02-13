using ProductManagement;
using System;
namespace ShopManagement
{
    public class Shop
    {
        private Product[] productList;
        private int count;

        public Shop(int size)
        {
            productList = new Product[size];
            count = 0;
        }

        public void AddProduct()
        {
            if (count >= productList.Length) {
                Console.WriteLine("Shop is full");
                return;
            }

            Console.Write("Enter product name: ");
            string name = Console.ReadLine();
            Console.Write("Enter description: ");
            string description = Console.ReadLine();
            double price;
            do
            {
                Console.Write("Enter price (0 < Price <= 100): ");
            } while (!double.TryParse(Console.ReadLine(), out price) || price <= 0 || price > 100);

            Product newProduct = new Product(name, description, price);
            productList[count++] = newProduct;
            Console.WriteLine("Product added successfully!");
        }

        public void IterateProductList()
        {
            if (count == 0)
            {
                Console.WriteLine("No product avaiable");
                return;
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nProduct {i + 1}: ");
                productList[i].ViewInfo();
            }
        }

        public void SearchProduct()
        {
            if (count == 0)
            {
                Console.WriteLine("No product avaiable");
                return;
            }

            Console.Write("Enter min price: ");
            double minPrice = double.Parse(Console.ReadLine());
            Console.Write("Enter max price: ");
            double maxPrice = double.Parse(Console.ReadLine());

            bool found = false;
            for (int i = 0; i < count; i++)
            {
                if (productList[i].Price > minPrice && productList[i].Price < maxPrice)
                {
                    productList[i].ViewInfo();
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("No product found");
            }
        }
    }
    }
}
