using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250319.Poultry
{
    public class Poultry : IPoultry
    {
        private static int _Count = 0;
        private int _ID;
        private string _Name;
        public int ID
        {
            get { return _ID; }
        }

        public string Name
        {
            get {return _Name; }
            set { _Name = value; }
        }

        public Poultry() { }

        public Poultry(int iD, string name)
        {
            _Count++;
            _ID = _Count;
            _Name = name;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {_ID}\tName: {_Name}");
        }

        public virtual void Speak()
        {
            Console.WriteLine("Sound....");
        }
    }
}
