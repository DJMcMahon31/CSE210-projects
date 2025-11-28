using System;

public class ListingActivity : Activity
{
    private string _placeholderLA;

    public ListingActivity(string placeHolder, string placeholderLA)
        : base(placeHolder)
    {
        _placeholderLA = placeholderLA;
    }

    //Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
}