using System;

public class Comment
{
    public string _authorName;
    public string _text;

    public Comment(string authorName, string text)
    {
        _authorName = authorName;
        _text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"  - {_authorName}: {_text}");
    }
}