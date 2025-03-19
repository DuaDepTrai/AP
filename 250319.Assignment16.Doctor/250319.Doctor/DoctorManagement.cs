using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250319.Doctor
{
    class DoctorManagement
    {
        private ArrayList DoctorList = new ArrayList();

        public void Add(IDoctor doctor)
        {
            DoctorList.Add(doctor);
            Console.WriteLine("Doctor added successfully");
        }

        public IDoctor DoctorToAdd()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter birthday: ");
            DateTime birthday;
            while (!DateTime.TryParse(Console.ReadLine(), out birthday))
            {
                Console.WriteLine("Invalid input date, please try again");
            }

            Console.Write("Enter speciality: ");
            string speciality = Console.ReadLine();

            Console.Write("Enter email: ");
            string email = Console.ReadLine();

            Console.Write("Enter rank: ");
            int rank;
            while (!int.TryParse(Console.ReadLine(), out rank))
            {
                Console.WriteLine("Invalid input rank, please try again"); 
            }

            Doctor newDoctor = new Doctor(name, birthday, speciality, email, rank);

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter phone {i + 1}: ");
                newDoctor[i] = Console.ReadLine();
            }

            return newDoctor;
        }

        public void Remove(IDoctor doctor)
        {
            if (DoctorList.Contains(doctor)) 
            {
                DoctorList.Remove(doctor);
                Console.WriteLine("Doctor removed successfully");
            } 
            else
            {
                Console.WriteLine("Doctor not found");
            }
        }

        public IDoctor DoctorToRemove() 
        {
            Console.Write("Enter Doctor ID to remove: ");
            int id;
            while (!int.TryParse (Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid input ID, please try again");
            }
            foreach (IDoctor d in DoctorList) 
            {
                if (d.ID == id)
                {
                    return d;
                }
            }
            return null;
        }

        public void Sort(IComparer comp)
        {
            DoctorList.Sort(comp);
            Console.WriteLine("Doctor List Successfully");
        }

        public void SearchDoctorByEmail()
        {
            Console.WriteLine("Enter email to search: ");
            string emailSearch = Console.ReadLine();

            foreach (IDoctor d in DoctorList)
            {
                if (d.Email.Equals(emailSearch))
                {
                    d.ShowInfo();
                    return;
                }
            }
            Console.WriteLine("Doctor not found");
        }

        public void DisplayAll()
        {
            if (DoctorList.Count > 0) 
            {
                Console.WriteLine("List Doctors: ");
                foreach (IDoctor d in DoctorList)
                {
                    d.ShowInfo();
                }
            }
            else
            {
                Console.WriteLine("No doctor in list");
            }
        }
    }
}
