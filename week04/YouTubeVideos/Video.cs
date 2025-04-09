using System;
using System.Collections.Generic;

public class Video
{
    public string _title;
    public string _author;
    public int _lengthInSeconds;

    private List<Comment> _comments = new List<Comment>();

    /// <summary>
    /// Construct a new Video with the given title, author, and length in seconds.
    /// </summary>
    /// <param name="title">The title of the video.</param>
    /// <param name="author">The author of the video.</param>
    /// <param name="lengthInSeconds">The length of the video in seconds.</param>
    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }

    
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int getCommentCount()
    {
        return _comments.Count;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }

    public string getTitle()
    {
        return _title;
    }

    public string getAuthor()
    {
        return _author;
    }

    public int getLength()
    {
        return _lengthInSeconds;
    }
}