public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Comment(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<comment>();
    }

    public Comment()
    {
        Console.WriteLine("What is the title of the video: ")
        _title = Console.ReadLine();
        Console.WriteLine("Who is the Author: ")
        _author = Console.ReadLine();
        Console.WriteLine("How long is the video (Seconds): ")
        _length = Console.ReadLine();
        _comments = new List<comment>();
    }

    public void AddComment(string name, string text)
    {
        Comment comment = new Comment(name, text)
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public void SetLenght(int length)
    {
        _length = length;
    }

    public int getLength()
    {
        return _length;
    }

    public void ShowComments()
    {
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }

    public void GetInformation()
    {
        Console.WriteLine($"{_title}\nAuthor: {_author} Duration: {_length} seconds\n");
        ShowComments();
    }
}





// Your program should have a class for a Video that has the responsibility to track the title, author, 
// and length (in seconds) of the video. Each video also has responsibility to store a list of comments, and should 
// have a method to return the number of comments. A comment should be defined by the Comment class which has the responsibility 
// for tracking both the name of the person who made the comment and the text of the comment.
// // Once you have the classes in place, write a program that creates 3-4 videos, sets the appropriate values, 
// and for each one add a list of 3-4 comments (with the commenter's name and text). Put each of these videos in a list.
// // Then, have your program iterate through the list of videos and for each one, display the title, author, length, 
// number of comments (from the method) and then list out all of the comments for that video. Repeat this display for each video in the list.