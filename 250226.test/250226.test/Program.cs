using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookShop
{
    internal class Program
    {
        static void Main(String[] args)
        {
            OnlineBookShop bookShop = new OnlineBookShop();
            int pick, adPick, cusPick;

            do
            {
                Console.WriteLine("=====\nBOOK STORE");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. Customer");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");
                pick = int.Parse(Console.ReadLine());

                switch (pick)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("=====\nADMIN MENU");
                            Console.WriteLine("1. Import Books To Store");
                            Console.WriteLine("2. Show The Store In Detail");
                            Console.WriteLine("3. Change A Book's Selling Price");
                            Console.WriteLine("4. Show Profit");
                            Console.WriteLine("5. Back");
                            Console.Write("Choose an option: ");
                            adPick = int.Parse(Console.ReadLine());

                            switch (adPick)
                            {
                                case 1:
                                    bookShop.ImportBook();
                                    break;

                                case 2:
                                    bookShop.ShowDetail();
                                    break;

                                case 3:
                                    bookShop.ChangeSellingPrice();
                                    break;

                                case 4:
                                    bookShop.ShowProfits();
                                    break;

                                case 5:
                                    Console.WriteLine("Back To Menu");
                                    break;

                                default:
                                    Console.WriteLine("Invalid input, please try again");
                                    break;
                            }
                        } while (adPick != 5);
                        break;

                    case 2:
                        do
                        {
                            Console.WriteLine("=====\nCUSTOMER MENU");
                            Console.WriteLine("1. Show All Books Of Store");
                            Console.WriteLine("2. Buy A Book");
                            Console.WriteLine("3. Back");
                            Console.Write("Choose an option: ");
                            cusPick = int.Parse(Console.ReadLine());

                            switch (cusPick)
                            {
                                case 1:
                                    bookShop.Show();
                                    break;

                                case 2:
                                    bookShop.SellABook();
                                    break;

                                case 3:
                                    Console.WriteLine("Back To Menu");
                                    break;

                                default:
                                    Console.WriteLine("Invalid input, please try again");
                                    break;
                            }
                        } while (cusPick != 3);
                        break;

                    case 3:
                        Console.WriteLine("Exiting program... Thank you!");
                        return;

                    default:
                        Console.WriteLine("Invalid input, please try again");
                        break;
                }
            } while (pick != 3);

            Console.ReadKey();
        }
    }
}
