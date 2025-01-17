using System;
namespace checkTrungTuyen
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap diem chuan: ");
            float dc = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem toan: ");
            float dt = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem ly: ");
            float dl = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem hoa: ");
            float dh = float.Parse(Console.ReadLine());

            if ((dt > 1) && (dl > 1) && (dh > 1) && (dt + dl + dh > dc))
            {
                Console.WriteLine("Trung tuyen");
            } else
            {
                Console.WriteLine("Truot");
            }

            Console.ReadKey();
        }
    }
}