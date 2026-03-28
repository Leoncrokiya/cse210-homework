using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("I Tried HIDDEN Backyard Restaurants", "FaZe Rug", 2097);
        Comment comment1 = new Comment("The first restaurant absolutely deserved that #1 spot, the energy and vibes were great and the hospitality! ❤", "@bandmakers");

        Video video2 = new Video("FaZe Rug - Goin' Live (Official Music Video)", "FaZe Rug", 151);
        Comment comment2 = new Comment("see you all in 3 years when this randomly gets recommend.", "@teej4776");

        Video video3 = new Video("7 Things You Should NEVER Do At Night..", "FaZe Rug", 1745);
        Comment comment3 = new Comment("Lord keep these evil spirits that could pass through the video away from me amen!", "@ChawkseeArt");

        // 1st Video
        Console.WriteLine(video1.GetFullVideo());
        Console.WriteLine();

        Console.WriteLine(comment1.GetComment());

        Console.WriteLine();
        Console.WriteLine(new string('=', 120));
        Console.WriteLine();

        // 2nd Video
        Console.WriteLine(video2.GetFullVideo());
        Console.WriteLine();

        Console.WriteLine(comment2.GetComment());
        
        Console.WriteLine();
        Console.WriteLine(new string('=', 120));
        Console.WriteLine();

        // 3rd Video 
        Console.WriteLine(video3.GetFullVideo());
        Console.WriteLine();

        Console.WriteLine(comment3.GetComment());
        
        Console.WriteLine();
        Console.WriteLine(new string('=', 120));
        Console.WriteLine();
    }
}