using System;

class LoanEligibility
{
    static void Main()
    {
        int age;
        double income;
        int creditScore;

        Console.Write("Enter your age: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your monthly income: ");
        income = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your credit score: ");
        creditScore = Convert.ToInt32(Console.ReadLine());

        
        if (age >= 21 && age <= 60)
        {
            if (income >= 25000)
            {
                if (creditScore >= 700)
                {
                    Console.WriteLine("\nLoan Approved ✅");
                }
                else
                {
                    Console.WriteLine("\nLoan Rejected ❌ (Low Credit Score)");
                }
            }
            else
            {
                Console.WriteLine("\nLoan Rejected ❌ (Insufficient Income)");
            }
        }
        else
        {
            Console.WriteLine("\nLoan Rejected ❌ (Age not eligible)");
        }
    }
}