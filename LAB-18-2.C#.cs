using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("You entered: " + num);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Error: Please enter a valid integer.");
        }
        catch (Exception e)
        {
            Console.WriteLine("General Error: " + e.Message);
        }
        finally
        {
            Console.WriteLine("This block always executes.");
        }

        Console.WriteLine("Program ended.");
    }
}