using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>(new string[] { "prompt-1", "prompt-2", "prompt-3" });
    private List<string> _questions = new List<string>(new string[] { "biology-1", "biology-2", "biology-3" });
    Random R = new Random();
    public ReflectingActivity()    
    {
        this.SetActivityName("Reflecting Activity");
        this.SetDescription("This activity will help you reflect on times in your life when you have show strenght and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

    }


    public void Run()
    {
        DisplayStartingMessage();
        int interval = GetDuration() / 6;
        for (int i = 0; i<= 0; i++)
        {
            Console.WriteLine();
            Console.WriteLine("Consider the following prompt: ");
            Console.WriteLine();
            Console.WriteLine("---" + GetRandomPrompt());
            Console.WriteLine();
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadKey();
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");
            ShowCountDown(interval);

            Console.Clear();
            string questions1 = GetRandomQuestion();
            
            Console.Write(">>> " + questions1 + " ");
            ShowSpinner(1000);
            Console.WriteLine();
            string questions2 = GetRandomQuestion();
            if (questions2 == questions1)
            {
                string questions3 = GetRandomQuestion();
                Console.Write(">>> " + questions3 + " ");    
                ShowSpinner(1000);
            }
            else
            {
                Console.Write(">>> " + questions2 + " ");
                ShowSpinner(1000);

            }
            
    
        }
        Console.WriteLine();
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        var random = new Random();
        var list = new List<string>{ "Think in your day ","Yhink in the family", "think in your griends", "I don't know just think"};
        int index = random.Next(list.Count);

        return list[index];
    }

    public string GetRandomQuestion()
    {
        var random = new Random();
        var list = new List<string>{ "How was this week?","You coud made all?", "How was the day for you?","It was ok today?"};
        int index = random.Next(list.Count);
        string question = list[index];
        return question;
    }
   

    public void DisplayPrompt()
    {
    
		Console.WriteLine(GetRandomPrompt());

    }

    public void DisplayQuestions()
    {
   
    }

}