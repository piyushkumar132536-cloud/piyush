using System;

class ElectricityBill
{
    static void Main()
    {
        double amount, discount = 0;
        string category;

        Console.Write("Enter total bill amount: ");
        amount = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter customer category (Senior / Regular / Industrial): ");
        category = Console.ReadLine().ToLower();

        
        switch (category)
        {
            case "senior":
                discount = amount * 0.20;   
                break;

            case "regular":
                discount = amount * 0.10;   
                break;

            case "industrial":
                discount = amount * 0.05;   
                break;

            default:
                Console.WriteLine("Invalid customer category!");
                return;
        }

        double finalAmount = amount - discount;

        Console.WriteLine("\n------ BILL DETAILS ------");
        Console.WriteLine("Original Amount : " + amount);
        Console.WriteLine("Discount Amount : " + discount);
        Console.WriteLine("Final Amount    : " + finalAmount);
    }
}