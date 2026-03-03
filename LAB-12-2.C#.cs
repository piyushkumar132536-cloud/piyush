using System;

class Program
{
    static void Main()
    {
        int[] marks = new int[5];
        int total = 0;
        double average;

        
        Console.WriteLine("Enter marks of 5 students:");

        for (int i = 0; i < marks.Length; i++)
        {
            Console.Write("Student " + (i + 1) + ": ");
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < marks.Length; i++)
        {
            total += marks[i];
        }

       
        average = (double)total / marks.Length;

       
        Console.WriteLine("Total Marks = " + total);
        Console.WriteLine("Average Marks = " + average);
    }
}