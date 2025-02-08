using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>
        {
            new Video("How to Cook Pasta", "Chef John", 300),
            new Video("Top 10 Coding Tips", "Tech Guru", 600),
            new Video("Best Travel Destinations", "Wanderlust", 450)
        };

        videos[0].AddComment("Alice", "Great recipe! Tried it and loved it.");
        videos[0].AddComment("Bob", "Can you make one with a creamy sauce?");
        videos[0].AddComment("Charlie", "Simple and delicious!");

        videos[1].AddComment("David", "Awesome tips, really helped me improve.");
        videos[1].AddComment("Eva", "Can you make a video on debugging?");
        videos[1].AddComment("Frank", "Loved the part about clean code!");

        videos[2].AddComment("Grace", "Adding these to my bucket list!");
        videos[2].AddComment("Hank", "Do a part 2 with more destinations.");
        videos[2].AddComment("Ivy", "Been to some of these, and they’re amazing!");

        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}