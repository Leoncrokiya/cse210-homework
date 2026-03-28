public class Comment
{
    public string _comment;

    public string _sender;

    public Comment(string comment, string sender)
    {
        _comment = comment;
        _sender = sender;
    }

    public string GetComment()
    {
        return $"{_sender}: {_comment}";
    }
}