using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    class StudentManagement
    {
        private ArrayList studentList = new ArrayList();
        private ArrayList goods = new ArrayList();
        private ArrayList fairs = new ArrayList();
        private ArrayList normals = new ArrayList();
        private ArrayList bads = new ArrayList();

        public void AddStudent()
        {
            Console.Write("Enter name: ");
            string Name = Console.ReadLine();
            Console.Write("Enter Class: ");
            string Class = Console.ReadLine();
            Console.Write("Enter Math mark: ");
            float MathMark;
            while (!float.TryParse(Console.ReadLine(), out MathMark))
            {
                Console.WriteLine("Invalid input, please try again");
            }
            Console.Write("Enter Physic mark: ");
            float PhysicMark;
            while (!float.TryParse(Console.ReadLine(), out PhysicMark))
            {
                Console.WriteLine("Invalid input, please try again");
            }
            Console.Write("Enter Chemistry mark: ");
            float ChemistryMark;
            while (!float.TryParse(Console.ReadLine(), out ChemistryMark))
            {
                Console.WriteLine("Invalid input, please try again");
            }

            Student newSt = new Student(Name, Class, MathMark, PhysicMark, ChemistryMark);
            studentList.Add(newSt);
        }

        public void ShowAll()
        {
            foreach (Student st in studentList) 
            {
                st.Display();
            }
        }

        public void Classify()
        {
            Console.WriteLine("Good Students: ");
            IsGood();
            Console.WriteLine("Fair Students: ");
            IsFair();
            Console.WriteLine("Normal Students: ");
            IsNormal();
            Console.WriteLine("Bad Students: ");
            IsBad();
        }

        public void IsGood()
        {
            foreach(Student st in studentList)
            {
                if (st.AverageMark() >= 8.5)
                {
                    goods.Add(st);
                }
            }
            foreach(Student st1 in goods)
            {
                st1.Display();
            }
        }
        public void IsFair()
        {
            foreach (Student st in studentList)
            {
                if (st.AverageMark() < 8.5 && st.AverageMark() >= 7.0)
                {
                    fairs.Add(st);
                }
            }
            foreach (Student st1 in fairs)
            {
                st1.Display();
            }
        }
        public void IsNormal()
        {
            foreach (Student st in studentList)
            {
                if (st.AverageMark() < 7.0 && st.AverageMark() >= 5.0)
                {
                    normals.Add(st);
                }
            }
            foreach (Student st1 in normals)
            {
                st1.Display();
            }
        }
        public void IsBad()
        {
            foreach (Student st in studentList)
            {
                if (st.AverageMark() < 5.0)
                {
                    bads.Add(st);
                }
            }
            foreach (Student st1 in bads)
            {
                st1.Display();
            }
        }
    }
}
