using System;
namespace StudentManagement
{
    public class Student
    {
        private static int Count=0;
        private int _ID;
        private string _Name;
        private string _ClassName;
        private float _MathMark;
        private float _PhysicMark;
        private float _ChemistryMark;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string ClassName
        {
            get { return _ClassName; }
            set { _ClassName = value; }
        }
        public float MathMark
        {
            get { return _MathMark; }
            set { _MathMark = value; }
        }
        public float PhysicMark
        {
            get { return _PhysicMark; }
            set { _PhysicMark = value; }
        } 
        public float ChemistryMark
        {
            get { return _ChemistryMark; }
            set { _ChemistryMark = value; }
        }

        public Student(string name, string className, float math, float physic, float chemistry)
        {
            Count++;
            ID = Count;
            Name = name;
            ClassName = className;
            MathMark = math;
            PhysicMark = physic;
            ChemistryMark = chemistry;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Class: {ClassName}, Math mark: {MathMark}, Physic mark: {PhysicMark}, Chemistry mark: {ChemistryMark}, Average mark: {AverageMark()}");
        }

        public float AverageMark()
        {
            return (MathMark + ChemistryMark + PhysicMark) / 3;
        }
    }
}