using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250319.Poultry
{
    public class Coop : ICoop
    {
        private static int _Count = 0;
        private int _ID;
        private string _Name;
        private ArrayList _arrPoultry;
        public int ID 
        {
            get { return _ID; }
        }

        public string Name 
        {
            get { return _Name; } 
            set { _Name = value; }
        }

        public ArrayList arrPoultry
        {
            get { return _arrPoultry; }
            set { _arrPoultry = value; }
        }

        public Coop(string name)
        {
            _ID = _Count++;
            _Name = name;
            _arrPoultry = new ArrayList();
        }

        public void AddAChicken()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Chicken chicken = new Chicken();
            arrPoultry.Add(chicken);
            Console.WriteLine("A new chicken added");
        }

        public void AddADuck()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Duck duck = new Duck();
            arrPoultry.Add(duck);
            Console.WriteLine("A duck added");
        }

        public void Contain()
        {
            Console.WriteLine($"Coop ID: {_ID} - Name: {_Name} contains: ");
            foreach (IPoultry poultry in _arrPoultry)
            {
                poultry.Display();
            }
        }

        public void RemoveAPoultry(int id)
        {
            foreach(IPoultry p in _arrPoultry)
            {
                if (p.ID == id)
                {
                    arrPoultry.Remove(p);
                    Console.WriteLine("Poultry removed");
                    return;
                }
            }
            Console.WriteLine("Poultry not found");
        }
    }
}
