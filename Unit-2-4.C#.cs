using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Principal Amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate of Interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time (in years): ");
        double year = Convert.ToDouble(Console.ReadLine());

        double amount = principal * Math.Pow((1 + rate / 100), year);
        double compoundInterest = amount - principal;

        Console.WriteLine("Compound Interest = " + compoundInterest);
    }
}

