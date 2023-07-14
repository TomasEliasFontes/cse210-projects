using System;
using System.Collections.Generic;
using System.Text;
using System.IO; 

// We add public to the general class of the Journal 
// to may be accessible to the other programs
public class Video
{
    public string _title,_author;
    public double _length;
    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, double length)
    {
        _title= title;
        _author = author;
        _length = length;
    }


    public void DisplayAll()
    {
        Console.WriteLine("_______________________________________");
        Console.WriteLine($"Video Title: {_title}, Author: {_author} length: {_length} sec");
        Console.WriteLine($"Number of Comments: {_comments.Count}");
        Console.WriteLine("Comments: ");
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
        Console.WriteLine("_______________________________________");
    }


}