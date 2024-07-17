using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CheckingAccount : BankAccount
{
    public decimal OverdraftLimit { get; set; }

    public CheckingAccount(string accountNumber, decimal initialBalance, decimal overdraftLimit)
        : base(accountNumber, initialBalance)
    {
        OverdraftLimit = overdraftLimit;
    }

    public override void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Depozitata suma: {amount} in CheckingAccount. New Balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Suma depozitata trebuie sa fie mai mare decat zero");
        }
    }

    public override void Withdraw(decimal amount)
    {
        if (amount <= Balance + OverdraftLimit)
        {
            Balance -= amount;
            Console.WriteLine($"Retrasa suma: {amount} din CheckingAccount. New Balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Limita de Overdraft depasita");
        }
    }
}
