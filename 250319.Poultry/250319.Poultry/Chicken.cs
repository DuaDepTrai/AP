using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250319.Poultry
{
    class Chicken : Poultry
    {
        public Chicken() : base() { }
        public Chicken(int id, string name) : base(id, name) { }
        public override void Speak()
        {
            Console.WriteLine("oOoOo");
        }
    }
}
