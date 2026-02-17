using System;

class MinimumOfThree
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number: ");
        int c = Convert.ToInt32(Console.ReadLine());

        int min = (a < b) 
                    ? (a < c ? a : c) 
                    : (b < c ? b : c);

        Console.WriteLine("Minimum number is: " + min);
    }
}
