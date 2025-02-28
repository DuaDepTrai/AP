using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoctorManagement manage = new DoctorManagement();
            int pick;

            do
            {
                Console.WriteLine("-----\nMENU:");
                Console.WriteLine("1. Add New Doctor");
                Console.WriteLine("2. View List of Doctors");
                Console.WriteLine("3. Sort Doctors by Rank");
                Console.WriteLine("4. Delete a Doctor");
                Console.WriteLine("5. Search Doctor By Email");
                Console.WriteLine("6. Exit");
                Console.Write("Your choice: ");
                pick = int.Parse(Console.ReadLine());

                switch (pick)
                {
                    case 1:
                        IDoctor newDoctor = manage.CreateDoctor();
                        manage.Add(newDoctor);
                        break;

                    case 2:
                        manage.DisplayAll();
                        break;

                    case 3:
                        manage.Sort(new SortByRank());
                        manage.DisplayAll();
                        break;

                    case 4:
                        IDoctor removeDoctor = manage.FindDoctorToRemove();
                        manage.Remove(removeDoctor);
                        break;

                    case 5:
                        manage.SearchDoctorByEmail();
                        break;

                    case 6:
                        Console.WriteLine("Exit Program! Thank you!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice, please try again");
                        break;
                }
            } while (pick != 6);
        }
    }
}
