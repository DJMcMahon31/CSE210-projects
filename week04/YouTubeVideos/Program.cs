using System;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
    
        Video videoBattleOfCulloden = new Video("'Battle of Culloden'", "Brad Smith", 600);
        Video videoLochNessMonster = new Video("'Loch Ness Monster'", "Travis MacDougall", 400);
        Video videoIsleOfSkye = new Video("'Isle of Skye'", "Anna MacPhee", 1200);

        Comment BoC1 = new Comment("Drew Sullivan", "'Tragic.'");
        Comment BoC2 = new Comment("Abe Corey", "'So long ago.'");
        Comment BoC3 = new Comment("Sam Story", "'Fascinating.'");
    
        Comment LnM1 = new Comment("Allan Munro", "'Still don't know if the monster is real.'");
        Comment LnM2 = new Comment("Doulas MacDougall", "'Old news.'");
        Comment LnM3 = new Comment("Alexander MacDonald", "'Still a mystery.'");

        Comment IoS1 = new Comment("Queen Merida", "'Who is in charge?'");
        Comment IoS2 = new Comment("King Sinclair", "'Spectacular!'");
        Comment IoS3 = new Comment("Prince Charming", "'I am looking for a fair maiden.'");


        string[] commentCulloden = {"'Tragic.'", "'So long ago.'", "'Fascinating.'"};

        string[] commentMonster = {"'Still don't know if the monster is real.'", "'Old news.'", "'Still a mystery.'"};
        string[] commentSkye = {"'Who is in charge?'", "'Spectacular.''", "'I am looking for a fair maiden.'"};

     
        Console.WriteLine($"Video: {videoBattleOfCulloden.GetDisplayText()}"); //output is "Video: Battle of Culloden by Brad Smith (600 seconds)"
        Console.WriteLine($"Number of comments: {commentCulloden.Length}"); //output is "Number of comments: 3"
        Console.WriteLine($"Comment 1: {BoC1.GetDisplayText()}");  //ouput is "Comments: Name:Drew Sullivan; comment:'Tragic.'
        Console.WriteLine($"Comment 2: {BoC2.GetDisplayText()}");
        Console.WriteLine($"Comment 3: {BoC3.GetDisplayText()}");
        
        //Console.WriteLine($"Comments: {string.Join(", ", commentCulloden.Take(4))}");  //output is Comments: 'Tragic', 'So long ago', 'Fascinating'"
        Console.WriteLine(); //adds a line between the separate videos.S
       

        Console.WriteLine($"Video: {videoLochNessMonster.GetDisplayText()}");
        Console.WriteLine($"Number of comments: {commentMonster.Length}");
        Console.WriteLine($"Comment 1: {LnM1.GetDisplayText()}");
        Console.WriteLine($"Comment 2: {LnM2.GetDisplayText()}");
        Console.WriteLine($"Comment 3: {LnM3.GetDisplayText()}");
     
        //Console.WriteLine($"Comments: {string.Join(", ", commentMonster.Take(4))}");
        Console.WriteLine();


        Console.WriteLine($"Video: {videoIsleOfSkye.GetDisplayText()}");
        Console.WriteLine($"Number of comments: {commentSkye.Length}");
        Console.WriteLine($"Comment 1: {IoS1.GetDisplayText()}");
        Console.WriteLine($"Comment 2: {IoS2.GetDisplayText()}");
        Console.WriteLine($"Comment 3: {IoS3.GetDisplayText()}");

        //Console.WriteLine($"Comments: {string.Join(", ", commentSkye.Take(4))}");
        Console.WriteLine();

    
    }
} 