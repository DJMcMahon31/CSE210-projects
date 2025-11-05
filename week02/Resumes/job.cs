/*using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
*/
using System;

public class Job
{
    /*public string _jobTitle;
    _jobTitle:string
    _company:string_
    _startYear:int
    _endYear:int
    Display():void
    */
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle}");
        Console.WriteLine($"{_company}");
        Console.WriteLine($"{_startYear}");
        Console.WriteLine($"{_endYear}");
      

    }
}


