using System;
namespace ProductManagement
{
    public class Product
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
            if (rating < 1 || rating > 5) return;
            if (rateCount < Rate.Length) Rate[rateCount++] = rating;
        }

        public double GetAverageRating()
        {
            if (rateCount == 0) return 0;
            int sum = 0;
            for (int i = 0; i < rateCount; i++) sum += Rate[i];
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
}
