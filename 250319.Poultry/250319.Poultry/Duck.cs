using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250319.Poultry
{
    class Duck : Poultry
    {
        public Duck() : base() { }
        public Duck(int id, string name) : base(id, name) { }
        public override void Speak()
        {
            Console.WriteLine("Quac quac quac");
        }
    }
}
