using System;
namespace checkTriangle
{
    class Program3
    {
        static void Main(string[] args) {
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            int c = int.Parse(Console.ReadLine());

            if (a + b < c || a + c < b || b + c < a)
            {
                Console.WriteLine("Not a triangle");
            }
            else 
            {
                if (a == b && a == c)
                {
                    Console.WriteLine("Equilateral triangle"); //deu
                }
                else
                {
                    if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                    {
                        if (a == b || a == c || b == c)
                        {
                            Console.WriteLine("Isosceles right triangle"); //vuong can
                        }
                        else
                        {
                            Console.WriteLine("Right triangle"); //vuong
                        }
                    }
                    else
                    {
                        if (a == b || a == c || b == c)
                        {
                            Console.WriteLine("Isosceles triangle"); //can
                        }
                        else
                        {
                            Console.WriteLine("Scalene triangle"); //thuong
                        }
                    }
                }
            }            

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}