using System;

class TryCatchDemo
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");

        try
        {
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 / num2;

            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter numeric values.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Execution completed.");
        }
    }
}