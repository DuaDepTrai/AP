using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250319.Poultry
{
    interface IPoultry
    {
        int ID { get; }
        string Name { get; set; }
        void Speak();
        void Display();
    }
}
