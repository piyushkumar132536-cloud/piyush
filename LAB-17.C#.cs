using System;


interface IResult
{
    bool Pass(int mark);
}


interface IDivision
{
    string Division(int average);
}


class Student : IResult, IDivision
{
   
    public bool Pass(int mark)
    {
        if (mark >= 50)
            return true;
        else
            return false;
    }


    public string Division(int average)
    {
        if (average >= 75)
            return "Distinction";
        else if (average >= 60)
            return "First Class";
        else if (average >= 50)
            return "Second Class";
        else
            return "Fail";
    }

    
    static void Main(string[] args)
    {
        Student s = new Student();

        int mark = 55;
        int average = 67;

        Console.WriteLine("Pass Status: " + s.Pass(mark));
        Console.WriteLine("Division: " + s.Division(average));
    }
}
