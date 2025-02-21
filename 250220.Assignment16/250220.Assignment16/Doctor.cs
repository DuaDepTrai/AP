using System;

namespace _250220.Assignment16
{
    public class Doctor:IDoctor
    {
        private static int Count = 0;
        private int rank;
        private string[] PhoneList = new string[3];

        public int ID {  get; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Speciality { get; set; }
        public string Email { get; set; }

        public int _Rank;
        public int Rank { set {  _Rank = value; } }

        public Doctor(string name, DateTime birthday, string speciality, string email, int rank)
        {
            Count++;
            ID = Count;
            Name = name;
            Birthday = birthday;
            Speciality = speciality;
            Email = email;
            this.rank = rank;
        }

        public int getRank() 
        {
            return rank;
        }

        public string this[int index]
        {
            get { return PhoneList[index]; }
            set { PhoneList[index] = value; }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Birthday: {Birthday.ToShortDateString()}, Speciality: {Speciality}, Email: {Email}, Rank: {rank}");
        }
    }
}
