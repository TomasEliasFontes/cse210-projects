using System;
using System.Collections.Generic;
using System.Text;

// We add public to the general class of the Entry 
// to may be accessible to the other programs
public class Comment
{

    // This are the name that are called in public 
    // in others programs and are designated another format for the program
    public string _name, _comment;
    public Comment (string name, string comment)
    {
        _name= name;
        _comment = comment;
    }

    // THis is how is gonna we displey the comment input from the user 
    public void Display()
    {
        Console.WriteLine($"User: {_name} - Comment: {_comment} ");
        Console.WriteLine();    
    }
}