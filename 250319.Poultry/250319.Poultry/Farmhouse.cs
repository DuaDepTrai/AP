using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250319.Poultry
{
    public class Farmhouse
    {
        public Dictionary<int, Coop> coops = new Dictionary<int, Coop>();
        public Dictionary<int, Coop> GetCoops()
        {
            return coops;
        }

        public void AddACoop()
        {
            Console.Write("Enter coop name: ");
            string name = Console.ReadLine();
            Coop newCoop = new Coop(name);
            coops[newCoop.ID] = newCoop;
            Console.WriteLine("Coop added");
        }

        public void RemoveACoop()
        {
            Console.Write("Enter coop ID: ");
            int id = int.Parse(Console.ReadLine());
            if (coops.Remove(id))
            {
                Console.WriteLine("Coop removed");
            }
            else
            {
                Console.WriteLine("Coop not found");
            }
        }

        public void ToSpeakInChorus()
        {
            foreach (var coop in coops.Values) 
            {
                foreach (IPoultry p in coop.arrPoultry)
                {
                    p.Speak();
                }
            }
        }

        public void Show()
        {
            foreach (var coop in coops.Values)
            {
                coop.Contain();
            }
        }
    }
}
