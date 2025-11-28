using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Sandbox Project.");
    }
}
/*
PAUSING
Thread.Sleep()

Console.WriteLine ("Going to sleep for a bit...");
Thread.Sleep(1000);  //this is for on second
Console.WriteLine ("I'm back!");
..........................
using System:
class Program
{
    static void Min(string() args)
    {
        Console.WriteLine("Hello Sandbox World");
        Console.WriteLine(5);
        Thread.Sleep(1000);
        Console.WriteLine(4);
        Thread.Sleep(1000);
        Console.WriteLine(3);
        Thread.Sleep(1000;)
        Console.WriteLine(2);
        Thread.Sleep(1000);
        Console.WriteLine(1);
        Console.WriteLine("Done.");

        //can also be shortened like this:
        Console.WriteLine("Welcome to Sandbox World");
        for (int 1 = 5; 1 > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
        Console.WriteLine("Done.");
    }
}
//if we want it to count down on the same line just change Console.WriteLine(i) to Console.Write(i)

*/

/*
DISPLAY ANIMATIONS - computer pauses, replace previous character with an new one - backspaces over a character
"\b \b"

Console.Write("+");
Thread.Sleep(500);  //this is for a half of a second
Console.Write("\b \b");  //Erase the + character
Console.Write("-");  // Replace it with the - character
.................
OVERWRITE CHARACTER
Console.WriteLine("Welcome to Sandbox World");
        for (int 1 = 5; 1 > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000); 
            Console.Write("\b \b");  //this snippet of code is taken from above but using the "\b" to overwrite the character
        }
        Console.WriteLine("Done.");
...........................
USING DOTS AS COUNTERS
for (int i = 5; i > 0, i--);
{
    Console.Write(".");
    Thread.Sleep(1000);
}
...........................
SPINNERS
//     |/-\|/-\
List<string>
animationStrings.Add("|");
animationStrings.Add("/");
animationStrings.Add("-");
animationStrings.Add("\\");
animationStrings.Add("|");
animationStrings.Add("/");
animationStrings.Add("-");
animationStrings.Add("\\");
animationStrings.Add("|");
foreach (string s in animationStrings)
{
    Console.Write(s);
    Thread.Sleep(1000);
    Console.Write("\b \b");
}
Console.WriteLine("Done.");
// this will only run for about 8 seconds  - which takes us to the DateTime class - see below
..................................

*/

/*
WORKING WITH TIME
DateTime / DateTime.Now / .AddSeconds(numberOfSeconds)

DateTime startTime = DateTime.Now;
DateTime futureTime = startTime.AddSeconds(5);
Thread.Sleep(3000);
DateTime currentTime = DateTime.Now;
if (currentTime < futureTime)
{
    Console.WriteLine("We have not arrived at our future time yet...");

}
..........................

List<string>
animationStrings.Add("|");
animationStrings.Add("/");
animationStrings.Add("-");
animationStrings.Add("\\");
animationStrings.Add("|");
animationStrings.Add("/");
animationStrings.Add("-");
animationStrings.Add("\\");
animationStrings.Add("|");

DateTime startTime = DateTime.Now;
DateTime endTime = startTime.AddSeconds(10);
int i = 0;
while (dateTime.Now < endTime)
{
    string s = animationStrings[i];
    Console.Write("s");
    Thread.Sleep(1000);
    Console.Write("\b \b");
    i++;
    if (i >= animationStrings.Count)
    {
        i = 0;
    }
}
Console.WriteLine("Done.");
*/

