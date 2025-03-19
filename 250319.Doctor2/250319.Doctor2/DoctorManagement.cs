using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250319.Doctor2
{
    class DoctorManagement
    {
        private ArrayList DoctorList = new ArrayList();

        public void Add(Idoctor doctor)
        {
            DoctorList.Add(doctor);
            Console.WriteLine("Doctor added successfully");
        }

        public Idoctor doctorToAdd()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter birthday: ");
            DateTime birthday;
            while (!DateTime.TryParse(Console.ReadLine(), out birthday))
            {
                Console.WriteLine("Invalid input, please try again");
            }

            Console.Write("Enter speciality: ");
            string speciality = Console.ReadLine();

            Console.Write("Enter email: ");
            string email = Console.ReadLine();

            Console.Write("Enter rank: ");
            int rank;
            while (!int.TryParse(Console.ReadLine(),out rank))
            {
                Console.WriteLine("Invalid input, please try again");
            }

            Doctor newDoctor = new Doctor(name, birthday, speciality, email, rank);

            for (int i = 0; i < 3; i++) 
            {
                Console.Write($"Enter phone {i + 1}: ");
                newDoctor[i] = Console.ReadLine();
            }

            return newDoctor;
        }

        public void RemoveDoctor(Idoctor doctor)
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

        public Idoctor doctorToRemove() 
        {
            Console.Write("Enter doctor ID to remove: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id)) 
            { 
                Console.WriteLine("Invalid input, please try again");
            }
            foreach (Doctor doctor in DoctorList)
            {
                if (doctor.ID == id)
                {
                    return doctor;
                }
            }
            return null;
        }

        public void Sort (IComparer comp)
        {
            DoctorList.Sort(comp);
            DisplayAll();
        }

        public void DisplayAll()
        {
            if (DoctorList.Count > 0) 
            {
                foreach (Doctor doctor in DoctorList)
                {
                    doctor.ShowInfo();
                }
            }
            else
            {
                Console.WriteLine("No doctor in list");
            }
        }

        public void SeaechByEmail()
        {
            if (DoctorList.Count > 0)
            {
                Console.Write("Enter email to search: ");
                string emailSearch = Console.ReadLine();
                foreach (Doctor doctor in DoctorList)
                {
                    if (doctor.Email.Equals(emailSearch))
                    {
                        doctor.ShowInfo();
                        return;
                    }
                }
                Console.WriteLine("Doctor not found");
            }
            else
            {
                Console.WriteLine("No doctor to search");
            }
        }
    }
}
