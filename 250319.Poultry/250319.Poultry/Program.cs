using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250319.Poultry
{
    class Program
    {
        public static void Main(string[] args)
        {
            Farmhouse farmhouse = new Farmhouse();
            int choice;
            string input;
            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add a new coop");
                Console.WriteLine("2. Remove a coop");
                Console.WriteLine("3. Add a new poultry");
                Console.WriteLine("   a. Add a new Chicken");
                Console.WriteLine("   b. Add a new Duck");
                Console.WriteLine("4. Remove a poultry");
                Console.WriteLine("5. Show all poultry");
                Console.WriteLine("6. Poultries reply in chorus");
                Console.WriteLine("7. Exit");
                Console.Write("Your choice: ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        farmhouse.AddACoop();
                        break;
                    case "2":
                        farmhouse.RemoveACoop();
                        break;
                    case "3a":
                        Console.Write("Enter coop ID: ");
                        int coopIdA = int.Parse(Console.ReadLine());
                        if (farmhouse.GetCoops().ContainsKey(coopIdA))
                            farmhouse.GetCoops()[coopIdA].AddAChicken();
                        else
                            Console.WriteLine("Coop not found.");
                        break;
                    case "3b":
                        Console.Write("Enter coop ID: ");
                        int coopIdB = int.Parse(Console.ReadLine());
                        if (farmhouse.GetCoops().ContainsKey(coopIdB))
                            farmhouse.GetCoops()[coopIdB].AddADuck();
                        else
                            Console.WriteLine("Coop not found.");
                        break;
                    case "4":
                        Console.Write("Enter poultry ID: ");
                        int poultryId = int.Parse(Console.ReadLine());
                        foreach (var coop in farmhouse.coops.Values)
                            coop.RemoveAPoultry(poultryId);
                        break;
                    case "5":
                        farmhouse.Show();
                        break;
                    case "6":
                        farmhouse.ToSpeakInChorus();
                        break;
                    case "7":
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            } while (input != "7");
        }
    }
}
