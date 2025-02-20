using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250220.Assignment16
{
    public class DoctorManagement
    {
        private ArrayList doctorList = new ArrayList();

        public void Add(IDoctor doctor)
        {
            doctorList.Add(doctor);
            Console.WriteLine("Doctor added successfully");
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

        public IDoctor FindDoctorById(int id)
        {
            foreach (IDoctor doctor in doctorList) 
            {
                if (doctor.ID == id) return doctor;
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
            foreach (IDoctor doctor in doctorList)
            {
                doctor.ShowInfo();
            }
        }

        public IDoctor SearchByEmail(string email)
        {
            foreach (IDoctor doctor in doctorList)
            {
                if (doctor.Email == email) { 
                    return doctor;
                }
            }
            return null;
        }

        public bool IsEmpty()
        {
            return doctorList.Count == 0;
        }
    }
}
