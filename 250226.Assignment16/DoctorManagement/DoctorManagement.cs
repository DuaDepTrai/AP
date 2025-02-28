using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorManagement
{
    internal class DoctorManagement
    {
        private ArrayList doctorList = new ArrayList();

        public void Add(IDoctor doctor)
        {
            doctorList.Add(doctor);
            Console.WriteLine("Doctor added successfully");
        }

        public IDoctor CreateDoctor()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter BirthDay: ");
            DateTime birthday;
            while (!DateTime.TryParse(Console.ReadLine(), out birthday))
            {
                Console.WriteLine("Invalid input, please try again");
            }

            Console.Write("Enter Speciality: ");
            string speciality = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Rank: ");
            int rank;
            while (!int.TryParse(Console.ReadLine(), out rank))
            {
                Console.WriteLine("Invalid input, please enter a number.");
            }

            Doctor newDoctor = new Doctor(name, birthday, speciality, email, rank);

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter phone number {i + 1}: ");
                newDoctor[i] = Console.ReadLine();
            }

            return newDoctor;
        }

        public void Remove(IDoctor doctor) 
        {
            if (doctorList.Contains(doctor))
            {
                doctorList.Remove(doctor);
                Console.WriteLine($"Doctor with ID {doctor.ID} has been removed.");
            }
            else
            {
                Console.WriteLine("Doctor not found");
            }
        }

        public IDoctor FindDoctorToRemove()
        {
            Console.Write("Enter doctor ID to remove: ");
            int removeID;
            while (!int.TryParse(Console.ReadLine(), out removeID))
            {
                Console.WriteLine("Invalid input, please try again");
            }

            foreach (IDoctor d in doctorList)
            {
                if (d.ID == removeID)
                {
                    return d;
                }
            }
            return null;
        }

        public void Sort(IComparer comp)
        {
            doctorList.Sort(comp);
            Console.WriteLine("Doctors sorted successfully");
        }

        public void DisplayAll()
        {
            if (doctorList.Count == 0)
            {
                Console.WriteLine("No doctor in list");
            }
            else
            {
                Console.WriteLine("List of all doctors:");
                foreach (IDoctor doctor in doctorList)
                {
                    doctor.ShowInfo();
                }
            }
        }

        public void SearchDoctorByEmail()
        {
            Console.Write("Enter email to search: ");
            string emailSearch = Console.ReadLine();

            foreach (IDoctor d in doctorList)
            {
                if (d.Email.Equals(emailSearch))
                {
                    Console.WriteLine("Doctor found:");
                    d.ShowInfo();
                    return;
                }
            }
            Console.WriteLine("Doctor not found");
        }
    }
}
