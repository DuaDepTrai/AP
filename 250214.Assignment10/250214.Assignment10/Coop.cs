using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250214.Assignment10
{
    internal class Coop
    {
        public int id {  get; set; }
        public string name { get; set; }
        public ArrayList arrPoultry { get; }

        public Coop() 
        { 
            id = 0;
            name = string.Empty;
            arrPoultry = new ArrayList();
        }

        public Coop(int id, string name)
        {
            this.id = id;
            this.name = name;
            arrPoultry = new ArrayList();
        }



        public void Contain()
        {
            Console.WriteLine();
            foreach (Poultry item in arrPoultry)
            {
                item.Display();
            }
        }

        public void AddAChicken()
        {
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Chicken ck = new Chicken(id, name);

            arrPoultry.Add(ck);
        }

        public void AddADuck()
        {
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Duck dk = new Duck(id, name);
            arrPoultry.Add(dk);
        }

        public void RemoveAPoultry()
        {
            Console.Write("Enter ID to remove: ");
            int id =int.Parse(Console.ReadLine());
            for (int i = 0; i < arrPoultry.Count; i++)
            {
                Poultry item = (Poultry)arrPoultry[i];
                if (item.id == id)
                {
                    arrPoultry.RemoveAt(i);
                    break; 
                }
            }
        }
    }
}
