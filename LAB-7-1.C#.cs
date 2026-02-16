using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        long factorial = 1;

        if (number < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
        }
        else
        {
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("Factorial of " + number + " is: " + factorial);
        }

        Console.ReadLine();
    }
}
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        long factorial = 1;

        if (number < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
        }
        else
        {
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("Factorial of " + number + " is: " + factorial);
        }

        Console.ReadLine();
    }
}
