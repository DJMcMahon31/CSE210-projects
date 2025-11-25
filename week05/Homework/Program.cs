using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Homework Project.");
    
        Assignment a1 = new("Albert Albert", "Physics");
        MathAssignment m1 = new("Albert Albert", "Physics 101", "10", "5-9");    
        Console.WriteLine(a1);
        Console.WriteLine(m1.GetSummary()); // from the Assignment class
        Console.WriteLine(m1.GetHomeworkList());  //from the MathAssignment class
    }

    //Student student = new Student("Brigham", "234");
/*string name = student.GetName();
string number = student.GetNumber();
Console.WriteLine(name);
Console.WriteLine(number);
*/
}