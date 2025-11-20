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

        Comment commentBattleOfCulloden = new Comment("Drew Sullivan", "'Tragic'");
    
        Comment commentLochNessMonster = new Comment("Allan Munro", "'Still don't know if the monster is real.'");
        Comment commentIsleOfSkye = new Comment("Queen Merida", "Who is in charge?");

        string[] videoCulloden = {"'Battle of Culloden'"};  
        string[] videoMonster = {"'Loch Ness Monster'"};     
        string[] videoSkye = {"'Isle of Skye'"};

        string[] commentCulloden = {"'Tragic'", "'So long ago'", "'Fascinating'"};
        string[] commentMonster = {"'Wow'", "'Waste of time'", "'Old news'", "'Nothing new here'"};
        string[] commentSkye = {"'I have really wanted to go there, nice to see so much in this video'", "'Beautiful'"};

     
        Console.WriteLine($"Video: {videoBattleOfCulloden.GetDisplayText()}"); //output is "Video: Battle of Culloden by Brad Smith (600 seconds)"
        Console.WriteLine($"Number of comments: {commentCulloden.Length}"); //output is "Number of comments: 3"
        Console.WriteLine($"Comments: {commentBattleOfCulloden.GetDisplayText()}");
        Console.WriteLine($"Comments: {string.Join(", ", commentCulloden.Take(4))}");  //output is Comments: 'Tragic', 'So long ago', 'Fascinating'"
        Console.WriteLine(); //adds a line between the separate videos.S
       

        Console.WriteLine($"Video: {videoLochNessMonster.GetDisplayText()}");
        Console.WriteLine($"Number of comments: {commentMonster.Length}");
        Console.WriteLine($"Comments: {commentLochNessMonster.GetDisplayText()}");

     
        Console.WriteLine($"Comments: {string.Join(", ", commentMonster.Take(4))}");
        Console.WriteLine();

        Console.WriteLine($"Video: {videoIsleOfSkye.GetDisplayText()}");
        Console.WriteLine($"Number of comments: {commentSkye.Length}");
        Console.WriteLine($"Comments: {commentIsleOfSkye.GetDisplayText()}");

        //Console.WriteLine("{videoSkye[0]}");
        Console.WriteLine($"Comments: {string.Join(", ", commentSkye.Take(4))}");
        Console.WriteLine();

    
    }
} 