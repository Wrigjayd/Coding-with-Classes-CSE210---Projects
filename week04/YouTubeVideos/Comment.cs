public class Comment{
    private string _commentersName;
    private string _commentText;

    public void SetCommentersName(string name)
    {
        _commentersName = name;
    }
    public void SetCommentText(string text)
    {
        _commentText = text;
    }
    public string GetCommentersName()
    {
        return _commentersName;
    }

    public string GetCommentText()
    {
        return _commentText;
    }
}