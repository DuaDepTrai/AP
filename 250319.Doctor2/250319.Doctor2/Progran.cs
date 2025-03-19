using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250319.Doctor2
{
    class Progran
    {
        public static void Main(string[] args)
        {
            DoctorManagement dm = new DoctorManagement();
            int pick;

            do
            {
                Console.WriteLine("====\nMENU:");
                Console.WriteLine("1. Add new doctor");
                Console.WriteLine("2. Show all doctor");
                Console.WriteLine("3. Sort doctor list by rank");
                Console.WriteLine("4. Delete a doctor");
                Console.WriteLine("5. Search doctor by email");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");
                pick = int.Parse(Console.ReadLine());

                switch (pick)
                {
                    case 1:
                        dm.Add(dm.doctorToAdd()); break;
                    case 2:
                        dm.DisplayAll(); break;
                    case 3:
                        dm.Sort(new SortByRank()); break;
                    case 4:
                        dm.RemoveDoctor(dm.doctorToRemove()); break;
                    case 5:
                        dm.SeaechByEmail(); break;
                    case 6:
                        Console.WriteLine("Exit..."); return;
                    default:
                        Console.WriteLine("Invalid choice, please try again"); break;
                }
            } while (pick != 6);

            Console.ReadKey();
        }
    }
}