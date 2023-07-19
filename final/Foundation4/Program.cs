using System;

class Program
{
    static void Main(string[] args)
    {
        // We call the classes requires from the activitis
        Running running = new Running("June 26, 2023", 30, 5);

        Bicycles bicycles = new Bicycles("April 3, 2023", 60, 20);

        Swimming swimming = new Swimming("Dec 10, 2023", 30, 15);

        // Create a list to put activitis in
        List<Activity> activities = new List<Activity>{
            running,
            bicycles,
            swimming
        };

        // It display the info input fromm the system and call the funcion to see all the activitis
        // Each one for separte
        Console.WriteLine("Activities:");
        Console.WriteLine();
        foreach (Activity activity in activities) 
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine(new string('_',100) + "\n");

        }
    }
}