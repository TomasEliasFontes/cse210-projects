using System;
using System.Collections.Generic;
class Program

{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        string text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Scripture Scripture = new Scripture(reference, text);

        
        Scripture.ShowScripture();

        
        Console.WriteLine("Press Enter to continue or type 'quit' to finish: ");
        string input = Console.ReadLine();

        while (input != "quit")
        {
            
            Scripture.HideWords();
            Scripture.ShowScripture();
            
            if (Scripture.AllWordsHidden())
            {
                break;
            }
            
            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");
            input = Console.ReadLine();
            
        }
        
        Console.ReadLine();

    }
}