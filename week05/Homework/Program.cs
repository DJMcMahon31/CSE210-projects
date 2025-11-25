using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Homework Project.");
    
        Assignment a1 = new("Albert Albert", "Physics");
        MathAssignment m1 = new("Al Albert", "Physics 101", "10", "5-9");    
        WritingAssignment w1 = new("A. Albert", "Physics 101", "10", "6-9", "How Things Move");
       
        Console.WriteLine(a1.GetSummary()); // from the Assignment class 
        Console.WriteLine(m1.GetHomeworkList());  //from the MathAssignment class
        Console.WriteLine(w1.GetWritingInformation());  //from the WritingAssignment class
    }

    
}