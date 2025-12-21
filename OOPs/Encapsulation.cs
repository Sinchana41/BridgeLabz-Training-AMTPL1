using System;

class BankAccount
{
    private double balance;   // Data hidden

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public double GetBalance()
    {
        return balance;
    }
}

class Program1
{
    static void Main()
    {
        BankAccount acc = new BankAccount();
        acc.Deposit(5000);

        Console.WriteLine("Balance: " + acc.GetBalance());
    }
}

