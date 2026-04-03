using System;

class Account
{
    public int accountNumber;
    public string holderName;
    public double balance;

    public Account(int accNo, string name, double bal)
    {
        accountNumber = accNo;
        holderName = name;
        balance = bal;
    }

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("Deposited: " + amount);
    }

    public virtual void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdrawn: " + amount);
        }
        else
        {
            Console.WriteLine("Insufficient balance!");
        }
    }

    public void Display()
    {
        Console.WriteLine("Account No: " + accountNumber);
        Console.WriteLine("Name: " + holderName);
        Console.WriteLine("Balance: " + balance);
    }
}

class SavingsAccount : Account
{
    double minBalance = 500;

    public SavingsAccount(int accNo, string name, double bal)
        : base(accNo, name, bal) { }

    public override void Withdraw(double amount)
    {
        if (balance - amount >= minBalance)
        {
            balance -= amount;
            Console.WriteLine("Savings Withdrawn: " + amount);
        }
        else
        {
            Console.WriteLine("Cannot withdraw! Minimum balance must be maintained.");
        }
    }
}

class CurrentAccount : Account
{
    double overdraftLimit = 1000;

    public CurrentAccount(int accNo, string name, double bal)
        : base(accNo, name, bal) { }

    public override void Withdraw(double amount)
    {
        if (balance + overdraftLimit >= amount)
        {
            balance -= amount;
            Console.WriteLine("Current Withdrawn: " + amount);
        }
        else
        {
            Console.WriteLine("Overdraft limit exceeded!");
        }
    }
}


class Program
{
    static void Main()
    {
        SavingsAccount sa = new SavingsAccount(101, "Alice", 2000);
        CurrentAccount ca = new CurrentAccount(102, "Bob", 500);

        Console.WriteLine("=== Savings Account ===");
        sa.Deposit(500);
        sa.Withdraw(1800);
        sa.Display();

        Console.WriteLine("\n=== Current Account ===");
        ca.Deposit(300);
        ca.Withdraw(1200);
        ca.Display();
    }
}