using System;

class Product
{
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public int[] Rate { get; set; }
    private int rateCount;

    public Product(string name, string description, double price)
    {
        Name = name;
        Description = description;
        Price = price;
        Rate = new int[100];
        rateCount = 0;
    }

    public void AddRating(int rating)
    {
        if (rating < 1 || rating > 5)
        {
            Console.WriteLine("Invalid rating! Must be between 1 and 5.");
            return;
        }
        if (rateCount < Rate.Length)
        {
            Rate[rateCount++] = rating;
        }
    }

    public double GetAverageRating()
    {
        if (rateCount == 0) return 0;
        int sum = 0;
        for (int i = 0; i < rateCount; i++)
        {
            sum += Rate[i];
        }
        return (double)sum / rateCount;
    }

    public void ViewInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Price: {Price}$");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Average Rating: {GetAverageRating():0.00}");
    }
}

class Shop
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
        if (count >= productList.Length)
        {
            Console.WriteLine("Shop is full, cannot add more products.");
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
            Console.WriteLine("No products available.");
            return;
        }
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"\nProduct {i + 1}:");
            productList[i].ViewInfo();
        }
    }

    public void SearchProduct()
    {
        if (count == 0)
        {
            Console.WriteLine("No products available.");
            return;
        }

        double minPrice, maxPrice;
        do
        {
            Console.Write("Enter minimum price: ");
        } while (!double.TryParse(Console.ReadLine(), out minPrice) || minPrice <= 0);

        do
        {
            Console.Write("Enter maximum price: ");
        } while (!double.TryParse(Console.ReadLine(), out maxPrice) || maxPrice <= minPrice);

        Console.WriteLine("\nProducts in the given price range:");
        bool found = false;
        for (int i = 0; i < count; i++)
        {
            if (productList[i].Price >= minPrice && productList[i].Price <= maxPrice)
            {
                productList[i].ViewInfo();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No products found in this price range.");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of products the shop can store: ");
        int size = int.Parse(Console.ReadLine());
        Shop myShop = new Shop(size);

        int choice;
        do
        {
            Console.WriteLine("\nMENU:");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View All Products");
            Console.WriteLine("3. Search Products by Price Range");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
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
        } while (choice != 4);
    }
}
