using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string original = input;
        string reversed = "";

        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }

        if (original.Equals(reversed, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("The string is a Palindrome.");
        }
        else
        {
            Console.WriteLine("The string is NOT a Palindrome.");
        }
    }
}