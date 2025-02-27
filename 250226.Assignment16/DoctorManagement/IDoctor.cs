using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorManagement
{
    interface IDoctor
    {
        int ID {  get; }
        string Name { get; set; }
        DateTime Birthday { get; set; }
        string Speciality { get; set; }
        string Email { get; set; }
        int Rank { get; set; }
        string this[int index] { get; set; }
        void ShowInfo();
    }
}
