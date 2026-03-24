using System;

class Student
{
  
    private int rollNo;
    private string name;
    private double marks;

    
    public Student()
    {
        rollNo = 0;
        name = "Unknown";
        marks = 0;
    }

   
    public Student(int r, string n, double m)
    {
        rollNo = r;
        name = n;
        marks = m;
    }

    
    public string CalculateGrade()
    {
        if (marks >= 90)
            return "A";
        else if (marks >= 75)
            return "B";
        else if (marks >= 60)
            return "C";
        else if (marks >= 50)
            return "D";
        else
            return "F";
    }

    public void Display()
    {
        Console.WriteLine("Roll No: " + rollNo);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Marks: " + marks);
        Console.WriteLine("Grade: " + CalculateGrade());
    }
}

class Program
{
    static void Main(string[] args)
    {
      
        Student s1 = new Student();
        Console.WriteLine("Student 1 (Default Constructor):");
        s1.Display();

        Console.WriteLine();

      
        Student s2 = new Student(101, "Rahul", 82.5);
        Console.WriteLine("Student 2 (Parameterized Constructor):");
        s2.Display();
    }
}