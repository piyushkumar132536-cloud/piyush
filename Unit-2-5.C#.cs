using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double area = Math.PI * radius * radius;

        Console.WriteLine("Area of the circle = " + area);
    }
}
