using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int first = 0, second = 1;

        Console.WriteLine("Fibonacci Series up to " + number + " :");

        if (number >= 0)
            Console.Write(first + " ");

        if (number >= 1)
            Console.Write(second + " ");

        int next = first + second;

        while (next <= number)
        {
            Console.Write(next + " ");
            first = second;
            second = next;
            next = first + second;
        }

        Console.ReadLine();
    }
}
