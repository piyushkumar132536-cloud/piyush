using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double area = 3.14 * radius * radius;

        Console.WriteLine("Area of the circle = " + area);
    }
}
