using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Video
{   
    // Attributes
    private string _author;
    private string _title;
    private int _length;

    private List<Comment> _comments = new List<Comment>();

    // Constructors
    public Video(string author, string title, int length)
    {
        _author = author;
        _title = title;
        _length = length;
    }
    
    // Methods
    public string GetString()
    {
        return $"Author: {_author}\nTitle: {_title}\nLength: {_length} seconds\nNumber of Comments: {GetCommentNumber()}";
    }

    public void AddComment(string name, string text)
    {
        Comment comment = new Comment(name,text);
        _comments.Add(comment);
    }

    public int GetCommentNumber()
    {
        return _comments.Count;
    }

    public string GetCommentString()
    {
        StringBuilder s = new StringBuilder();
        foreach (Comment comment in _comments)
        {
            s.AppendLine($"{comment.GetString()}");
        }

        return s.ToString();
    }
}
