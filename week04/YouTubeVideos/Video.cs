class Video
{
    public string _title;
    public string _author;
    public int _duration;

    public Video(string Title, string Author, int Duration)
    {
        _title = Title;
        _author = Author;
        _duration = Duration;
    }

    public string GetFullVideo()
    {
        return $"{_title} by: {_author} - {_duration} seconds";
    }
}