using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookShop
{
    internal interface IStorage
    {
        int Count { get; set; }
        Book this[int index] { get; set; }
        void AddANewBook();
        void RemoveABook(string id);
        bool isBook(string id);
    }
}
