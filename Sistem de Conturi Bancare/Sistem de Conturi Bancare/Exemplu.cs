using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        SavingsAccount savings = new SavingsAccount("SA456", 1000.00m, 0.05m);
        savings.Deposit(300.00m);
        savings.Withdraw(500.00m);

        CheckingAccount checking = new CheckingAccount("CA456", 2000.00m, 1000.00m);
        checking.Deposit(500.00m);
        checking.Withdraw(2500.00m);
    }
} 
