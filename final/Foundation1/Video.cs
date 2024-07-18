public class Video
{
    public string _title;
    public string _author;
    public double _videoLength;
    public List<Comment> _commentsList;

    public Video(string title, string author, double videoLength) 
    {
        _title = title;
        _author = author;
        _videoLength = videoLength;
        _commentsList = new List<Comment>();

    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nVideo Lenth: {_videoLength} seconds\nNumber of Comments: {NumberOfComments()}");
        Console.WriteLine();
        Console.WriteLine("Comments:");
        foreach (Comment comment in _commentsList)
        {
            Console.WriteLine($"{comment}");
        }
    }

    public void AddComments(Comment comment)
    {
        _commentsList.Add(comment);
    }

    public int NumberOfComments()
    {
        return _commentsList.Count;
    }
}