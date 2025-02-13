using System.Xml.Linq;
using BankAccountManagement;

namespace SavingsLibrary;
public class Savings : BankAccount
{
    public float InterestRate { get; set; }

    public Savings(string accountName, float balance, float interestRate)
        : base(accountName, balance)
    {
        InterestRate = interestRate;
    }

    public void CalculateInterest(int months)
    {
        float interestBalance = Balance;
        for (int i = 0; i < months; i++)
        {
            interestBalance = (interestBalance * InterestRate) / 100 + interestBalance;
        }
        Console.WriteLine($"Account: {Name} | After {months} months, new balance with interest: {interestBalance}");
    }
}
