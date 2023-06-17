using System;

// We add public to the general class of the Program 
// to may be accessible to the other programs
public class Program
{
    static void Main(string[] args)
    {
    
    // We call the other program with the funcion of generete random 
    // question for ono of the opcion general in Program
    PromptGenerator promptGenerator = new PromptGenerator();
    
    // We call the other program with the funcions of generete  
    // the output of the choices in Program
    Journal journal = new Journal();

    // This list is divide to know the number value of that opcion in the menu
    int menuUserInout = 0;
    List<string> menu = new List<string>
    {
        "Please select one of the following choice:",
        "1. Write",
        "2. Display",
        "3. Load",
        "4. Save",
        "5. Quit",
        "What would you like to do?: "        
    };
        
    Console.WriteLine("Welcome to the Journal Program:");

    // While the insert of the user is diferent of 5 
    // it countinig the Program    
    while (menuUserInout != 5)
    {
        // Separet the opcion to displey each one as request
        foreach(string menuItem in menu)
        {
            Console.WriteLine(menuItem);
        }
        // The input variable is converted to a int to use it in the diferent if
        menuUserInout = int.Parse(Console.ReadLine());

        if (menuUserInout == 1)
        {
            // The variable prompt is called from the prompGeneretaor
            // to generete a random prompt to the user response
            string prompt =promptGenerator.GetRandomPrompt();
            Console.WriteLine(prompt);
            Console.Write(">");
            string response = Console.ReadLine();
            
            // Call a program to know the date and then made 
            // more short to only generete the day/month/year
            DateTime theCurrentTime = DateTime.Now;
            string date = theCurrentTime.ToShortDateString();
    
            // Then the program Entry used all that variebles and unites them 
            Entry entry = new Entry(date, response, prompt);
            // And is added to the journal
            journal.AddEntry(entry);
        }   

        else if (menuUserInout == 2)
        {
            //we call the program Journal with the displey
            // to show the insert resent
            journal.DisplayAll();
        }

        else if (menuUserInout == 3)
        {
            // is call the program Journal to displey ALL the journal 
            // that was saved wuth the name of the file
            Console.Write("What is the filename to load: ");
            string filename = Console.ReadLine();
            journal.LoadFromFile(filename);

        }

        else if (menuUserInout == 4)
        {
            // is call the program Journal to save the journal 
            // insert KNOW during the opcion 1
            Console.Write("What is name of the filename to save: ");
            string filename = Console.ReadLine();
            journal.SaveFile(filename);
        }

        else
        {
            // Other output if not any of the other options
            Console.WriteLine("You have to insert a number to 1 a 5:");
        }
    }
    
    Console.WriteLine("Good Bye");

    // This sometingh else that i try to do:
    //int number = -1;
    //int answer = 5;
    //while (answer != number)
    //{
      //  Console.WriteLine("Please select one of the following choice:");
        //Console.WriteLine("1. Write");
        //Console.WriteLine("2. Display");
        //Console.WriteLine("3. Load");
        //Console.WriteLine("4. Save");
        //Console.WriteLine("5. Quit");
        //Console.Write("What would you like to do?: ");
        //number = int.Parse(Console.ReadLine());
        
    }
}