using System;
using System.Collections.Generic;

namespace _250214.Assignment10
{
    internal class Farmhouse
    {
        private Dictionary<int, Coop> coops;

        public Farmhouse()
        {
            coops = new Dictionary<int, Coop>();
        }

        public void AddACoop()
        {
            Console.Write("Enter Coop ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Coop name: ");
            string name = Console.ReadLine();

            if (!coops.ContainsKey(id))
            {
                coops.Add(id, new Coop(id, name));
                Console.WriteLine($"Added Coop {name} with ID: {id}");
            }
            else
            {
                Console.WriteLine($"Coop with ID {id} already exists!");
            }
        }

        public void RemoveACoop()
        {
            Console.Write("Enter Coop ID to remove: ");
            int id = int.Parse(Console.ReadLine());

            if (coops.ContainsKey(id))
            {
                coops.Remove(id);
                Console.WriteLine($"Removed Coop with ID: {id}");
            }
            else
            {
                Console.WriteLine($"No Coop found with ID {id}!");
            }
        }

        public void AddAPoultry()
        {
            Console.Write("Enter Coop ID: ");
            int id = int.Parse(Console.ReadLine());

            if (coops.ContainsKey(id))
            {
                Console.WriteLine("1. Add a new Chicken");
                Console.WriteLine("2. Add a new Duck");
                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                    coops[id].AddAChicken();
                else if (choice == 2)
                    coops[id].AddADuck();
                else
                    Console.WriteLine("Invalid choice!");
            }
            else
            {
                Console.WriteLine($"No Coop found with ID {id}!");
            }
        }

        public void RemoveAPoultry()
        {
            Console.Write("Enter Coop ID: ");
            int id = int.Parse(Console.ReadLine());

            if (coops.ContainsKey(id))
            {
                coops[id].RemoveAPoultry();
            }
            else
            {
                Console.WriteLine($"No Coop found with ID {id}!");
            }
        }
        public void ToSpeakInChorus()
        {
            Console.WriteLine("All poultries are speaking...");
            foreach (var coop in coops.Values)
            {
                foreach (Poultry item in coop.arrPoultry)
                {
                    item.Speak();
                }
            }
        }

        public void Show()
        {
            Console.WriteLine("Displaying all Coops:");
            foreach (var coop in coops.Values)
            {
                coop.Contain();
            }
        }
    }
}
