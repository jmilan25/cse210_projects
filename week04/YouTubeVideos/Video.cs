// using System;
// using System.IO;
public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comment = new List<Comment>();
    // public Video(string title, string author, int length)
    // {
    //     _title = title;
    //     _author = author;
    //     _length = length;
    // }

    // public static void Write()
    // {
        
    // }
    public void Display()
    {
        int listLength = _comment.Count;
        // string length = _length;
        // string text = $"{_title} - {_author}\n{_length} minutes";
        Console.WriteLine($"{_title} - {_length} minutes");
        Console.WriteLine($"{_author}\n");
        Console.WriteLine($"Comments: {listLength}");

        foreach (Comment comment in _comment)
        {

            comment.Display();
        }
        

    }
}