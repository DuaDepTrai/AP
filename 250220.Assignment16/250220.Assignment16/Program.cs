using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250220.Assignment16
{
    class Program
    {
        static void Main(string[] args)
        {
            DoctorManagement manager = new DoctorManagement();
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
                        Console.Write("Enter Doctor's Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Doctor's Birthday (dd/MM/yyyy): ");
                        DateTime birthday;
                        while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthday))
                        {
                            Console.Write("Invalid format, please enter birthday (dd/MM/yyyy): ");
                        }

                        Console.Write("Enter Speciality: ");
                        string speciality = Console.ReadLine();

                        Console.Write("Enter Email: ");
                        string email = Console.ReadLine();

                        Console.Write("Enter Rank: ");
                        int rank = int.Parse(Console.ReadLine());

                        Doctor doctor = new Doctor(name, birthday, speciality, email, rank);

                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write($"Enter phone {i + 1}: ");
                            doctor[i] = Console.ReadLine();
                        }

                        manager.Add(doctor);
                        break;

                    case 2:
                        if (manager.IsEmpty())
                        {
                            Console.WriteLine("No doctor in list")
                        } 
                        else 
                        { 
                            Console.WriteLine("\nList of Doctors: ");
                            manager.DisplayAll();
                        }
                        break;

                    case 3:
                        manager.Sort(new SortByRank());
                        Console.WriteLine("Sorted by Rank");
                        break;

                    case 4:
                        Console.Write("Enter Doctor ID to remove: ");
                        if (int.TryParse(Console.ReadLine(), out int doctorId))
                        {
                            IDoctor doctorToRemove = manager.FindDoctorById(doctorId);

                            if (doctorToRemove != null)
                            {
                                manager.Remove(doctorToRemove);
                            }
                            else
                            {
                                Console.WriteLine("Doctor not found");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid ID, please enter valid number");
                        }
                        break;

                    case 5:
                        Console.Write("Enter Email to Search: ");
                        string searchEmail = Console.ReadLine();
                        IDoctor foundDoctor = manager.SearchByEmail(searchEmail);

                        if (foundDoctor != null)
                        {
                            Console.WriteLine("Doctor found: ");
                            foundDoctor.ShowInfo();
                        }
                        else
                        {
                            Console.WriteLine("Doctor not found");
                        }
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
