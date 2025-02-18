using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement
{
    public class Products
    {
        private static int Count = 0;
        public string ID { get; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public Products()
        {
            Count++;
            ID = "Hang" + Count.ToString();
            Name = "No name";
            Quantity = 0;
        }

        public void ShowDetail()
        {
            Console.WriteLine("{0,-10} {1,-20} {2,-10}", ID, Name, Quantity);
        }

        public void SetDetail(string name, int quantity)
        {
            this.Name = name;
            this.Quantity = quantity;
        }

        public void AddQuantity(int addQuantity)
        {
            this.Quantity += addQuantity;
        }
    }
}
