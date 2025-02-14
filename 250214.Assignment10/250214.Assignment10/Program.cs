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
            Coop coop = new Coop(1, "Chuong");
            int pick;

            do
            {
                Console.WriteLine("-----\nMENU:");
                Console.WriteLine("1. Add a chicken");
                Console.WriteLine("2. Add a duck");
                Console.WriteLine("3. Show all poultries");
                Console.WriteLine("4. Remove a poultry");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                pick = int.Parse(Console.ReadLine());

                switch (pick) 
                { 
                    case 1:
                        coop.AddAChicken();
                        break;
                    case 2:
                        coop.AddADuck();
                        break;
                    case 3:
                        coop.Contain();
                        break;
                    case 4:
                        coop.RemoveAPoultry();
                        break;
                    case 5:
                        Console.WriteLine("Exit program. Thank you!");
                        return;
                }
            } while (pick != 5);

            Console.ReadKey();
        }
    }
}
