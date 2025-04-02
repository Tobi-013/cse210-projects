using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();


    public Video (string title, string author ,int length )
    {
        _title = title;
        _author = author;
        _length = length;
        
    }

    public string GetTitle()
    {
        return _title;
    }
     public string GetAuthor()
    {
        return _author;
    }
     public int GetLength()
    {
        return _length;
    }
     public List<Comment> GetComments()
    {
        return _comments;
    }
     public void SetTitle(string title)
    {
         _title = title;
    }
     public void SetAuthor(string author)
    {
         _author = author;
    }
     public void SetLength(int length)
    {
          if (length > 0) // Ensuring length is positive
        {
            _length = length;
        }
        else
        {
            Console.WriteLine("Error: Length must be positive.");
        }
    }
     
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int GetCommentCount()
    {
        return _comments.Count;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: " + GetTitle());
        Console.WriteLine($"Author: " + GetAuthor());
        Console.WriteLine($"Length: " + GetLength() + " Seconds");
        Console.WriteLine($"Number Of Comments: " + GetCommentCount());
        Console.WriteLine($"Comments: ");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine();
    }
    
}