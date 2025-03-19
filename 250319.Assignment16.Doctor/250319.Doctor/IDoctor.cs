using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250319.Doctor
{
    interface IDoctor
    {
        int ID { get; }
        string Name { get; set; }
        DateTime Birthday { get; set; }
        string Speciality { get; set; }
        string Email { get; set; }
        int Rank { set; }
        string this[int index] { get; set; }
        void ShowInfo();
    }
}
