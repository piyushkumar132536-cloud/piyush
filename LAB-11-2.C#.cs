using System;

class Program
{
    static void Main()
    {
        int min;

        Console.Write("Enter number 1: ");
        min = Convert.ToInt32(Console.ReadLine());

        for (int i = 2; i <= 5; i++)
        {
            Console.Write("Enter number " + i + ": ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < min)
            {
                min = num;
            }
        }

        Console.WriteLine("Minimum number is: " + min);
    }
}