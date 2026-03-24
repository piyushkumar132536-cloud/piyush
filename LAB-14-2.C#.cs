using System;

class Employee
{
   
    private int employeeId;
    private string name;
    private double salary;

   
    public Employee()
    {
        employeeId = 0;
        name = "Unknown";
        salary = 0;
    }

   
    public Employee(int id, string n, double s)
    {
        employeeId = id;
        name = n;
        salary = s;
    }

  
    public double CalculateAnnualSalary()
    {
        return salary * 12;
    }

  
    public void Display()
    {
        Console.WriteLine("Employee ID: " + employeeId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Monthly Salary: " + salary);
        Console.WriteLine("Annual Salary: " + CalculateAnnualSalary());
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        Employee e1 = new Employee();
        Console.WriteLine("Employee 1 (Default Constructor):");
        e1.Display();

        Console.WriteLine();

      
        Employee e2 = new Employee(201, "Amit", 30000);
        Console.WriteLine("Employee 2 (Parameterized Constructor):");
        e2.Display();
    }
}