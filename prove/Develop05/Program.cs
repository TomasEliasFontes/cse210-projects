using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // variables
        int userMenuInput = 0;
        int totalPoints = 0;

        string typeOfGoal = null;
        string goalName;
        string description;
        int points;
    
        int i = 0;
        List<Goal> goals = new List<Goal>();

        bool achieved = false;
        int goalAccomplished = 0;
        int pointsEarned = 0;

        while (userMenuInput != 6)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {totalPoints} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from a menu: ");
            userMenuInput = int.Parse(Console.ReadLine());

            switch (userMenuInput)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist Goal");
                    Console.Write("Which type of goal would you like to creat? ");
                    typeOfGoal = Console.ReadLine();

                    switch (typeOfGoal)
                    {
                        // Simple Goal
                        case "1":
                            Console.WriteLine();
                            Console.Write("What is the name of goal? ");
                            goalName = Console.ReadLine();

                            Console.Write("What is a short description of it? ");
                            description = Console.ReadLine();

                            Console.Write("What is the amount of points associated with this goal? ");
                            points = int.Parse(Console.ReadLine());

                            Simple simple = new Simple(goalName, description, points, false);
                            simple.DisplayGoal(); 
                            goals.Add(simple);
                            break;
                        // Eternal Goal
                        case "2":
                            Console.WriteLine();
                            Console.Write("What is the name of goal? ");
                            goalName = Console.ReadLine();

                            Console.Write("What is a short description of it? ");
                            description = Console.ReadLine();

                            Console.Write("What is the amount of points associated with this goal? ");
                            points = int.Parse(Console.ReadLine());

                            Eternal eternal = new Eternal(goalName, description, points);
                            eternal.DisplayGoal();
                            goals.Add(eternal);
                            break;
                        case "3":
                            // Checklist Goal
                            Console.WriteLine();
                            Console.Write("What is the name of goal? ");
                            goalName = Console.ReadLine();

                            Console.Write("What is a short description of it? ");
                            description = Console.ReadLine();

                            Console.Write("What is the amount of points associated with this goal? ");
                            points = int.Parse(Console.ReadLine());

                            Checklist checklist = new Checklist(goalName, description, points);
                            checklist.DisplayGoal();
                            goals.Add(checklist);
                            break;

                    }
                    break;
                case 2:
                    // List goals
                    i = 1;
                    foreach (Goal goal in goals)
                    {
                        Console.Write($"{i}. ");
                        goal.DisplayGoal();

                        i++;
                    }
                    break;
                case 3:
                    // Save goals
                    Console.WriteLine();
                    Console.Write("What is the filename for the goal file? ");
                    string filename = Console.ReadLine() + ".txt";

                    using (StreamWriter outputFile = new StreamWriter(filename))
                    {
                        outputFile.WriteLine($"Points:{totalPoints}");

                        foreach (Goal goal in goals)
                        {
                            outputFile.WriteLine(goal.WriteInFile());
                        }
                    }
                    break;
                case 4:
                    // Load goals
                    Console.WriteLine();
                    Console.WriteLine("What is the file name for the goal file.");
                    filename = Console.ReadLine() + ".txt";

                    string[] allGoals = System.IO.File.ReadAllLines(filename);

                    foreach (string goal in allGoals)
                    {
                        string[] parts = goal.Split(":");

                        string goalType = parts[0];
                        string details = parts[1];
                        string[] data = details.Split(',');

                        switch (goalType)
                        {
                            case "SimpleGoal":
                                goalName = data[0];
                                description = data[1];
                                points = int.Parse(data[2]);
                                achieved = (data[3] == "True");

                                Simple simple = new Simple(goalName, description, points, achieved);
                                goals.Add(simple);

                                break;
                            case "EternalGoal":
                                goalName = data[0];
                                description = data[1];
                                points = int.Parse(data[2]);

                                Eternal eternal = new Eternal(goalName, description, points);
                                goals.Add(eternal);

                                break;
                            case "ChecklistGoal":
                                goalName = data[0];
                                description = data[1];
                                points = int.Parse(data[2]);
                                Checklist loadChecklist = new Checklist(goalName, description, points);
                                goals.Add(loadChecklist);
                                break;
                                
                            case "Points":
                                totalPoints = int.Parse(data[0]);
                                break;
                        }
                    }
                    break;
                case 5:
                    Console.WriteLine();

                    i = 1;
                    foreach (Goal goal in goals)
                    {
                        Console.Write($"{i}. ");
                        goal.DisplayGoal();

                        i++;
                    }
                    Console.WriteLine("Which goal did you accomplish? ");
                    goalAccomplished = int.Parse(Console.ReadLine()) - 1;
                    pointsEarned = goals[goalAccomplished].RecordEvent();
                    Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");

                    totalPoints += pointsEarned;

                    Console.WriteLine($"You now have {totalPoints} points.");
                    // Record Event
                    break;
                case 6:
                    // Quit
                    break;
            }
        }
    }
}