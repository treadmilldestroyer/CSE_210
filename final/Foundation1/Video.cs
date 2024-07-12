public class Video
{
    public string _title;
    public string _author;
    public int _videoLength;
    public List<Comment> _commentsList;

    public Video(string title, string author, int videoLength) 
    {
        _title = title;
        _author = author;
        _videoLength = videoLength;
        _commentsList = new List<Comment>();

    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title} Author: {_author} Video Lenth: {_videoLength} Number of Comments: {NumberOfComments()}");
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