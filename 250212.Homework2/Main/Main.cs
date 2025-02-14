using BankAccountManagement;
using Microsoft.VisualBasic;
using SavingsLibrary;

class Program
{
    static void Main()
    {
        BankAccount[] accounts = new BankAccount[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter account name: ");
            string name = Console.ReadLine();
            Console.Write("Enter initial balance: ");
            float balance = float.Parse(Console.ReadLine());

            accounts[i] = new BankAccount(name, balance);
        }

        Console.WriteLine("\nAll Accounts:");
        foreach (var acc in accounts) acc.Display();

        Savings[] savingsAccounts = new Savings[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter savings account name: ");
            string name = Console.ReadLine();
            Console.Write("Enter initial balance: ");
            float balance = float.Parse(Console.ReadLine());
            Console.Write("Enter interest rate: ");
            float interestRate = float.Parse(Console.ReadLine());

            savingsAccounts[i] = new Savings(name, balance, interestRate);
        }

        Console.WriteLine("\nAll Savings Accounts:");
        foreach (var sav in savingsAccounts) sav.Display();

        Console.Write("\nEnter number of months for interest calculation: ");
        int months = int.Parse(Console.ReadLine());

        foreach (var sav in savingsAccounts) sav.CalculateInterest(months);
    }
}
