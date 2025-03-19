using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250319.Doctor
{
    class Program
    {
        public static void Main(string[] args) 
        {
            DoctorManagement dm = new DoctorManagement();
            int pick;

            do
            {
                Console.WriteLine("=====\nMENU:");
                Console.WriteLine("1. Add new doctor");
                Console.WriteLine("2. View list doctor");
                Console.WriteLine("3. Sort doctor by rank");
                Console.WriteLine("4. Delete a doctor");
                Console.WriteLine("5. Seach doctor by email");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");
                pick = int.Parse(Console.ReadLine());

                switch (pick) 
                {
                    case 1:
                        dm.Add(dm.DoctorToAdd());
                        break;
                    case 2:
                        dm.DisplayAll();
                        break;
                    case 3:
                        dm.Sort(new SortByRank());
                        dm.DisplayAll();
                        break;
                    case 4:
                        dm.Remove(dm.DoctorToRemove());
                        break;
                    case 5:
                        dm.SearchDoctorByEmail();
                        break;
                    case 6:
                        Console.WriteLine("Exit...");
                        return;
                    default:
                        Console.WriteLine("Invalid input, please try again");
                        break;
                }
            } while (pick != 6);

            Console.ReadKey();
        }
    }
}
