using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Mindfulness Project.");

        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Activities:");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activiy");
            Console.WriteLine("4. Yoga Activity");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu:");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;

                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;

                case "4":
                    YogaActivity yoga = new YogaActivity();
                    yoga.Run();
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("\nInvalid option, please try again.");
                    Thread.Sleep(1500);
                    break;
            }
        }
    }

    /*
    "Menu Options:
        1. Start breathing activity
        2. Start reflecting activity
        3. Start listing activity
        4. Quit
    Select a choice from the menu:"
    */
}