public class Comment
{
    public string _commenterName;
    public string _commentText;

    /// <summary>
    /// Construct a new Comment with the given commenter name and comment text.
    /// </summary>
    /// <param name="commenterName">The name of the commenter.</param>
    /// <param name="commentText">The text of the comment.</param>
    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    public string getCommenterName()
    {
        return _commenterName;
    }

    public string getCommentText()
    {
        return _commentText;
    }

    public void setCommenterName(string commenterName)
    {
        _commenterName = commenterName;
    }

    public void setCommentText(string commentText)
    {
        _commentText = commentText;
    }
}