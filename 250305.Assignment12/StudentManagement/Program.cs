using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class Program
    {
        public static void Main(string[] args) 
        {
            StudentManagement sm = new StudentManagement();
            int pick;

            do
            {
                Console.Write("=====\nMENU:\n1. Add a student\n2. List students\n3. Classify students\n4. Exit\nChoose an option: ");
                pick = int.Parse(Console.ReadLine());

                switch (pick) 
                { 
                    case 1:
                        sm.AddStudent();
                        break;
                    case 2:
                        sm.ShowAll();
                        break;
                    case 3:
                        sm.Classify();
                        break;
                    case 4:
                        Console.WriteLine("Exit....");
                        break;
                    default:
                        Console.WriteLine("Invalid input, please try again");
                        break;
                }
            } while (pick != 4);
            Console.ReadKey();
        }
    }
}
