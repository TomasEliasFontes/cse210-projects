public class Activity
{

    private string _name;
    private string _description;
    static int _duration, _spinnerCounter;

//public Activity(string name, string description, int duration)
//  {
//     _name = name;
//     _description = description;
//     _duration = duration;
//  }

    // We will provide Getters for our private member variables so they can be accessed
    // later both outside the class as well is in derived classes.
    public Activity()
    {
       _spinnerCounter = _duration = 0;
    }
    public void SetActivityName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }
    public void DisplayStartingMessage()
    {
        
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        ShowSpinner(2000);
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {

        List<string> animationStrings = new List<string>();
        animationStrings.Add("+");
        animationStrings.Add("-");
        animationStrings.Add("+");
        animationStrings.Add("-");
        animationStrings.Add("+");
        animationStrings.Add("-");
        animationStrings.Add("+");
        animationStrings.Add("-");

        foreach ( string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(seconds);
            Console.Write("\b \b"); // Erase the + character

        }

    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write(string.Format("{0}", i));
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(1000);

        }
        Console.Write("");

    }

}