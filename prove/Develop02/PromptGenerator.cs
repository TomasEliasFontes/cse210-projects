using System;
using System.Collections.Generic;


// We add public to the general class of the Entry 
// to may be accessible to the other programs
public class PromptGenerator
{

    // Add a list with the questions to generete in 
    // the opcion 1 in Program
    public List<string> _prompts = new List<string>
    {
    "Who was the most interesting person I interacted with today?"
    ,"What was the best part of my day?"
    ,"How did I see the hand of the Lord in my life today?"
    ,"What was the strongest emotion I felt today?"
    ,"If I had one thing I could do over today, what would it be?"
    };

    public string GetRandomPrompt()
    {
        // Call a program that make randmon a varieble
        // and random the next prompt of the list and returns
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];

    }
}