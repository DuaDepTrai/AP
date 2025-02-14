using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250214.Assignment10
{
    internal class Duck:Poultry
    {
        public Duck():base() { }
        public Duck(int id, string name):base(id, name) { }

        public void Speak()
        {
            Console.WriteLine("Quac quac quac...");
        }
    }
}
