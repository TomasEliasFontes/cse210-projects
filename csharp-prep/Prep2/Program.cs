using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade: ");
        string grades = Console.ReadLine();
        int number = int.Parse(grades);

        string letter = "";
        string sign ="";
        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if ( (number >= 87 || number >= 77 || number >= 67) && letter != "A")
        {
            sign = "+";
        }
        else if ((number < 63 || number < 73 || number < 83 ) && letter != "F")
        {
            sign = "-";
        }
        else 
        {
            sign = "";
        }
        Console.WriteLine($"Your grade is: {letter}{sign}");
        
        if (number >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }

}