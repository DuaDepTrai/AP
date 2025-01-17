using System;
namespace TongPhanSo
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            double sum=0;
            for (int i = 0; i < n; i++) {
                sum += Math.Pow(-1, i) * Math.Pow(x, 2 * i) / gt(2 * i);
            }
            Console.WriteLine("Result = " + sum);
            Console.ReadKey();
        }

        static int gt(int x)
        {
            int gt=1;
            if (x == 0) { return 1; }
            else
            {
                for (int i = 1; i <= x; i++) { 
                    gt *= i;
                }
                return gt;
            }
        }
    }
}