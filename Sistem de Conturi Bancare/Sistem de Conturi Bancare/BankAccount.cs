using System;

public abstract class BankAccount
{
    public string AccountNumber;
    public decimal Balance;

    public BankAccount(string accountNumber, decimal balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public abstract void Deposit(decimal amount);
    public abstract void Withdraw(decimal amount);
}