using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250319.Poultry
{
    interface ICoop
    {
        int ID { get; }
        string Name { get; set; }
        ArrayList arrPoultry { get; }
        void Contain();
        void AddAChicken();
        void AddADuck();
        void RemoveAPoultry(int ID);
    }
}
