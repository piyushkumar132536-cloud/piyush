using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Principal Amount: ");
        double principal = double.Parse(Console.ReadLine());

        Console.Write("Enter Rate of Interest: ");
        double rate = double.Parse(Console.ReadLine());

        Console.Write("Enter Time (in years): ");
        double time = double.Parse(Console.ReadLine());

        double amount = principal * Math.Pow((1 + rate / 100), time);
        double compoundInterest = amount - principal;

        Console.WriteLine("\nTotal Amount = " + amount);
        Console.WriteLine("Compound Interest = " + compoundInterest);
    }
}