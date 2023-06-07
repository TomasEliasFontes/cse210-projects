using System;

class Program
{
    static void Main(string[] args)
    {
    // Stretch Challenge 2
    string loop = "yes";
    while (loop == "yes")
    {

    // Core Requirements 1 and 2
    // Console.Write("What is the magic number? ");
    // int response = int.Parse(Console.ReadLine());
    
    // Core Requirement 3
    Random randomGenerator = new Random();
    int response = randomGenerator.Next(1, 101);

    int answer = -1;

    while (answer != response)
    {
    Console.Write("What is your guess? ");
    answer = int.Parse(Console.ReadLine());

        if (response > answer)
        {
            Console.WriteLine("Higher");
        }
        else if (response < answer)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
    }

    // Stretch Challenge 2
    Console.Write("Do you want to continue? ");
    loop = Console.ReadLine();
    }    
    }
}