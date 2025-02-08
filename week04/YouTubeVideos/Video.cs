class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }  // Video length in seconds
    private List<Comment> Comments { get; set; } = new List<Comment>();

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    public void AddComment(string name, string text)
    {
        Comments.Add(new Comment(name, text));
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            Console.WriteLine($" - {comment.Name}: {comment.Text}");
        }
        Console.WriteLine(new string('-', 40)); // Separator line
    }
}
