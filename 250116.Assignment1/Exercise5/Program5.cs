using System;
namespace DateTimeEg
{
    class Program5
    {
        static void ShowDateTimeDetails()
        {
            DateTime currentDateTime = DateTime.Now;

            Console.WriteLine($"Date: {currentDateTime: dd/MM/yyyy}");
            Console.WriteLine($"Time: {currentDateTime: HH:mm:ss}");
        }

        static void Main(string[] args)
        {
            ShowDateTimeDetails();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
    
}