using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int originalNumber = number;
        int reversedNumber = 0;

        while (number > 0)
        {
            int digit = number % 10;
            reversedNumber = reversedNumber * 10 + digit;
            number = number / 10;
        }

        if (originalNumber == reversedNumber)
        {
            Console.WriteLine("The number is a Palindrome.");
        }
        else
        {
            Console.WriteLine("The number is NOT a Palindrome.");
        }
    }
}