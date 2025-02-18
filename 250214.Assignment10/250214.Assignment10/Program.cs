using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250214.Assignment10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Farmhouse farmhouse = new Farmhouse();
            int pick;

            do
            {
                Console.WriteLine("\n----- MENU -----");
                Console.WriteLine("1. Add a new coop");
                Console.WriteLine("2. Remove a coop");
                Console.WriteLine("3. Add a new poultry");
                Console.WriteLine("4. Remove a poultry");
                Console.WriteLine("5. Show all poultries");
                Console.WriteLine("6. Poultries reply in chorus");
                Console.WriteLine("7. Exit");
                Console.Write("Choose an option: ");
                pick = int.Parse(Console.ReadLine());

                switch (pick) 
                { 
                    case 1:
                        farmhouse.AddACoop();
                        break;
                    case 2:
                        farmhouse.RemoveACoop();
                        break;
                    case 3:
                        farmhouse.AddAPoultry();
                        break;
                    case 4:
                        farmhouse.RemoveAPoultry();
                        break;
                    case 5:
                        farmhouse.Show();
                        break;
                    case 6:
                        farmhouse.ToSpeakInChorus();
                        break;
                    case 7:
                        Console.WriteLine("Exit program. Thank you!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again!");
                        break;
                }
            } while (pick != 7);

            Console.ReadKey();
        }
    }
}
