using System;

class SumOfNumbers
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int count = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i <= count; i++)
        {
            Console.Write("Enter number " + i + ": ");
            int num = Convert.ToInt32(Console.ReadLine());
            sum += num;
        }

        Console.WriteLine("Total Sum = " + sum);
    }
}
