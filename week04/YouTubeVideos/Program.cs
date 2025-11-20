using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
    
        Video videoOne = new Video("Battle of Culloden", "Inspiring History", 600);

        Comment commentOne = new Comment("Loch Ness Monster", "Great video!");
        string[] videos = {"'Loch Ness Monster'"};
        string[] comments = {"'Wow'", "'Waste of time'", "'Old news'", "'Nothing new here'"};

        Console.WriteLine($"Name of the video: {videos[0]}");

        Console.WriteLine($"Comments: {string.Join(", ", comments.Take(4))}");
        Console.WriteLine($"Number of comments: {comments.Length}");
    
    }
}