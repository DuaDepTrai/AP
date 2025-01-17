using System;
namespace AngleTriangle
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());

            if (a > 0 && b > 0 && c > 0 && a + b + c == 180) {
                Console.WriteLine("Is Triangle");
            } else
            {
                Console.WriteLine("Is Not Triangle");
            }
        }
    }
}