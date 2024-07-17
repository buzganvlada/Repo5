using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SavingsAccount : BankAccount
{
    public decimal InterestRate { get; set; }

    public SavingsAccount(string accountNumber, decimal initialBalance, decimal interestRate)
        : base(accountNumber, initialBalance)
    {
        InterestRate = interestRate;
    }

    public override void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Depozitata suma: {amount} in SavingsAccount. New Balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Suma depozitata trebuie sa fie mai mare decat zero");
        }
    }

    public override void Withdraw(decimal amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Retrasa suma:  {amount} din SavingsAccount. New Balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Fonduri insuficiente");
        }
    }
}