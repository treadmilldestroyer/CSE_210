public class Comment
{
    public string _commentName;
    public string _commentText;

    public Comment(string name, string text)
    {
        _commentName = name;
        _commentText = text;
    }

    public override string ToString()
    {
        return $"{_commentName} - {_commentText}";
    }
}