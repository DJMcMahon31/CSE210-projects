using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        Resume resume = new Resume();

        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2020;
        job1._endYear = 2023;

        Job job2 = new Job();

        job2._jobTitle = "Software Engineer";
        job2._company = "Apple";
        job2._startYear = 2023;
        job2._endYear = 2025;

        resume._name = "Dianne's Resume";
        resume._job.Add(job1);
        resume._job.Add(job2);

        //public void Display()

        //Console.WriteLine($"{_jobTitle}");
        //job1.Display();
        //job2.Display();

        resume.Display();



        
        
        
    
    }
}