using System;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
    
        Video videoBattleOfCulloden = new Video("Battle of Culloden", "Brad Smith", 600);
        Video videoLochNessMonster = new Video("Loch Ness Monster", "Travis MacDougall", 400);
        Video videoIsleOfSkye = new Video("Isle of Skye", "Anna MacPhee", 1200);

        Comment commentBattleOfCulloden = new Comment("Drew Sullivan", "Very informative");
        Comment commentLochNessMonster = new Comment("Allan Munro", "Still don't know if the monster is real.");
        Comment commentIsleOfSkye = new Comment("Queen Merida", "Who is in charge?");

        string[] videos = {"'Loch Ness Monster'"};
        string[] comments = {"'Wow'", "'Waste of time'", "'Old news'", "'Nothing new here'"};

        Console.WriteLine($"Name of the video: {videos[0]}");

        Console.WriteLine($"Comments: {string.Join(", ", comments.Take(4))}");
        Console.WriteLine($"Number of comments: {comments.Length}");
    
    }
}