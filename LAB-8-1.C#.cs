using System;

class PrimeNumbersBetweenRange
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int end = Convert.ToInt32(Console.ReadLine());

        if (start > end)
        {
            int temp = start;
            start = end;
            end = temp;
        }

        Console.WriteLine("\nPrime numbers between {start} and {end} are:");

        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine();
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}
