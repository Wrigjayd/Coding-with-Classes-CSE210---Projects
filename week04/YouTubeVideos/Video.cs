using System.Runtime.InteropServices;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _videoLength;
    public List<Comment> Comments;

    public Video()
    {
        Comments = new List<Comment>();
    }

    public void SetTitle(string title)
    {
        _title = title;
    }
    public void SetAuthor(string author)
    {
        _author = author;
    }
    public void SetVideoLength(int length)
    {
        _videoLength = length;
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public int GetVideoLength()
    {
        return _videoLength;
    }
    public int GetTotalComments()
    {
        return Comments?.Count ?? 0;
    }
    
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

}