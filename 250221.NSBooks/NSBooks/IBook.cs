using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSBooks
{
    internal interface IBook
    {
        int ID { get; set; }
        string Name { get; set; }
        DateTime PublishDate { get; set; }
        string Author { get; set; }
        string Language { get; set; }
        float AveragePrice { get; }

        float this [int id] { get; set; }

        void Display();
    }
}
