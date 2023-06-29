public class ListingActivity : Activity
{
    private int _count;
    private List<string> responses = new List<string>();

    // Notice the syntax here that the WritingAssignment constructor has 3 parameters and then
    // it passes 2 of them directly to the "base" constructor, which is the "Assignment" class constructor.
    public ListingActivity()
    {
 
      this.SetActivityName("Listing Activity");
      this.SetDescription("This activity will help you reflect on the goos things in your life by having you list as many things as you can in a certain area.");

    
    }
    public void Run()
    {
        DisplayStartingMessage();
        int interval = GetDuration() / 6;
        for (int i = 0; i<= 0; i++)
        {
            Console.WriteLine();
            Console.WriteLine("List as many responses you can to the following prompt: ");
            Console.WriteLine();
            Console.WriteLine("---" + GetRandomPrompt());
            Console.WriteLine();
            Console.Write("You may begin in: ");
            ShowCountDown(interval);
            Console.WriteLine();

            GetListFromUser();
            Console.Write("You listed 4 items: ");

        }
        DisplayEndingMessage();
    }
    public  string GetRandomPrompt()
    {
        var random = new Random();
        var list = new List<string>{ "How did you feel?","Whats is the favority thhing?","It was a good experience?", "You feel good or wrong?", "What else you want to do  from this ?", "Think ?"};
        int index = random.Next(list.Count);

        return list[index];
    }

    

    public void GetListFromUser()
    {       
       
        do 
        {
            Console.Write(" > ");
            string response = Console.ReadLine();
            responses.Add(response);

        }
        while (responses.Count < 4);
    }
       


}
