using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System;

public class Resumes

{
    public string _name;
    public List<Job> _job = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"{_name}{_job}");
        foreach (Job j in _job)
        {
            j.Display();
        }
    }

}