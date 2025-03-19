using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250319.Doctor2
{
    class Doctor : Idoctor
    {
        private static int _Count = 0;
        private int _ID;
        private string _Name;
        private DateTime _Birthday;
        private string _Speciality;
        private string _Email;
        public int _Rank;
        private string[] PhoneList = new string[3];

        public int ID 
        {
            get { return _ID; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public DateTime Birthday
        {
            get { return _Birthday; }
            set { _Birthday = value; }
        }
        public string Speciality
        {
            get { return _Speciality; }
            set { _Speciality = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public int Rank
        {
            set { _Rank = value; }
        }
        public string this[int index]
        {
            get 
            { 
                if (index >=0 && index < PhoneList.Length)
                {
                    return PhoneList[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (index >= 0 && index < PhoneList.Length)
                {
                    PhoneList[index] = value;
                }
                else 
                {  
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public Doctor(string name, DateTime birthday, string speciality, string email, int rank)
        {
            _Count++;
            _ID = _Count;
            _Name = name;
            _Birthday = birthday;
            _Speciality = speciality;
            _Email = email;
            _Rank = rank;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ID: {_ID}\tName: {_Name}\tBirthday: {_Birthday}\tSpeciality: {_Speciality}\tEmail: {_Email}\tRank: {_Rank}");
        }
    }
}
