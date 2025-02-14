using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250214.Assignment10
{
    internal class Chicken:Poultry
    {
        public Chicken():base() { }

        public Chicken(int id, string name) : base(id, name) { }

        public void Speak()
        {
            Console.WriteLine("oOoOoOo");
        }

        
    }
}
