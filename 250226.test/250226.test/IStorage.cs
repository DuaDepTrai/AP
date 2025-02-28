using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250226.test
{
    interface IStorage
    {
        int Count { get; set; }
        Book this[int id] { get; set; }
        void AddANewBook();
        void RemoveABook(string id);
        bool IsABook(string id);
    }
}
