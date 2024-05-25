using System;
using System.Collections.Generic;
using System.IO;

//class GoalManager
public class GoalManager
{
    //Declare field variables
    private List<Goal> _goals;
    private int _score;

    //GoalManager initialization constructor, no parameters
    public GoalManager()
    {
        //Initializes an empty list of goals
        //sets the player's score to 0.

        _goals = new();
        _score = 0;
    }

    //Start method, no parameters, no return
    //main function, called by program cs, runs the menu loop, 
    public void Start()
    {
        //While loop, condition: true
        //Dislays user's points and menu options, 
        //reads and parses user response,
        //calls needed methods for option chosen
        while (true)
        {
            DisplayPlayerInfo();
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Goal");
            Console.WriteLine("   6. Quit");

            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Switch statements for menu options.
            //Each case calls the appropriate activity's run method.
            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6: // Quit program and quit message.
                    Console.WriteLine("Come back again, soon!");
                    return;
                default: //default: if invalid number is typed, goes back to menu.
                    Console.WriteLine("Please type 1, 2, 3, or 4.\nPress enter to return to the menu. ");
                    Console.ReadLine();
                    break;
            }
        }
    }

    //DisplayPlayerInfo method, no parameter, no return
    //Displays user's score
    //if score is above 5000 points, special message
    //if score is above 10000 points, special message and reset score to 0.
    public void DisplayPlayerInfo()
    {
        //Displays the players current score.
        Console.WriteLine($"You have {_score} points.");
        
        //if loop, condition: score >+ 10,000
        if (_score >= 10000)
        {
            //user message
            Console.WriteLine($"You have accumulated 10000 points!");
            Console.WriteLine("You are remarkable!\nCelebrate your successes and growth! What goal will you set next?\nYour score is resetting to 0.");

            _score = 0; 
        }
        else if (_score >= 5000) //else if, condition: score >= 5000
            {
                //user message
                Console.WriteLine($"You have accumulated 5000 or more points!");
                Console.WriteLine("You are a superstar!\nKeep setting and achieving goals!!!");
            }

        Console.WriteLine();
    }

    //CreateGoal method, no parameters, no return
    //Displays the goal type menu, reads and parses user choice
    //creates user's goals 
    public void CreateGoal()
    {
        Console.WriteLine();
        Console.WriteLine("Goal Options:");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");

        Console.Write("Which type of goal do you wish to complete? ");
        int goalChoice = int.Parse(Console.ReadLine());
        Console.WriteLine();

        //if loop, condition: goal choice is 1, 2 or 3
        if (goalChoice > 0 && goalChoice < 4)
        {
            //Get user goal name, description, and points (parsed)
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();

            Console.Write("What is a short description of your goal? ");
            string goalDescription = Console.ReadLine();

            Console.Write("How many points do you want for completing this goal? ");
            int goalPoints = int.Parse(Console.ReadLine());

            //Switch statements for creating user goal by type
            //initialize new goal type, add new goal to _goals list
            switch (goalChoice)
            {
                case 1: //type SimpleGoal
                    SimpleGoal simple = new(goalName, goalDescription, goalPoints);
                    _goals.Add(simple); 
                    break;
                case 2: //type EternalGoal 
                    EternalGoal eternal = new(goalName, goalDescription, goalPoints);
                    _goals.Add(eternal);
                    break;
                case 3: //type CheckListGoal
                    //Get and read user input on goal target and bonus
                    Console.Write("How many times does this goal need to be done to achieve a bonus? "); 
                    int target = int.Parse(Console.ReadLine());

                    Console.Write("How many bonus points do you want for completing your target number of times? ");   
                    int bonus = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    ChecklistGoal checklist = new(goalName, goalDescription, goalPoints, target, bonus);
                    _goals.Add(checklist);
                    break;
            }
        }
    }

    //ListGoalDetails method, no parameters, no return
    //Displays the list of the user's goals including checkbox
    public void ListGoalDetails()
    {
        Console.WriteLine("Here are your goals.");

        //Initialize goal counter
        int counter = 1;

        //foreach loop, condition: foreach goal in goals
        foreach (Goal goal in _goals)
        {
            //Dislay the goal counter and GetDetailsString 
            Console.WriteLine($"{counter}. {goal.GetDetailsString()}");

            //increase counter by 1 in each loop
            counter++;
        }
    }

    //RecordEvent method, no parameters, no return
    //Gets, reads, and parses user's completed goal to record 
    //Calls the RecordEvent method on that goal
    public void RecordEvent()
    {
        //Initialize goal counter
        int counter = 1;

        //foreach loop, condition: foreach goal in goals
        foreach(Goal goal in _goals)
        {
            //Display the goal counter and name
            Console.WriteLine($"{counter}. {goal.GetName()}");

            //increase counter by 1 in each loop
            counter++; 
        }

        Console.Write("Which goal have you completed? ");
        int accomplishedGoal = int.Parse(Console.ReadLine());

        //if loop, condition: goal list is not empty and accomplished goal is >0 and less than goal list count
        if (_goals.Count != 0 && accomplishedGoal > 0 && accomplishedGoal <= _goals.Count)
        {
            //if loop, condition: goal at accomplished goal -1 index isComplete
            if (!_goals[accomplishedGoal - 1].IsComplete())

                //score = for goal at accomplished goal index,
                //call that goals recordEvent method
                _score += _goals[accomplishedGoal - 1].RecordEvent();

            //else, display guard,  goal is already completed
            else
                Console.WriteLine("Goal is already completed. Set a new goal!");
        }
        //else, display guard, invalid input or empty list
        else
            Console.WriteLine("Invalid input or empty list");
    }

    //SaveGoals method, no parameters, no return
    //Gets and readsfile txt name from user,
    //saves score and goal list to that file
    public void SaveGoals()
    {
        Console.Write("What is the file name of the goal file? example(goals.txt) ");
        string fileName = Console.ReadLine();
        Console.WriteLine();

        //Uses StreamWriter and a foreach loop to iterate through the list
        //Save each goal's GetStringRepresentation string to the txt file. 

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        //Message for user, goals are saved.
        Console.WriteLine("Goals are saved.");
    }

    //LoadGoals method, no parameters, no return
    //Clears _goals list
    //Gets and reads file txt name from user
    //Reads, splits back into parts, and parses the list of goals' details from a file.
    //Loads goal file back to _goal list
    public void LoadGoals()
    {
        _goals.Clear();

        Console.Write("What is the file name of the goal file? example(goals.txt) ");
        string fileName = Console.ReadLine();

        string[] lines = File.ReadAllLines(fileName);

        //Get and parse the score at index 0
        string[] parts = lines[0].Split("|");
        _score = int.Parse(parts[0]);

        //For loop, condition: start at line index 1, i<length of the line, increment i by 1 each loop
        for (int i = 1; i < lines.Length; i++)
        {
            parts = lines[i].Split("|");
            string goalType = parts[0];
            string goalName = parts[1];
            string goalDescription = parts[2];
            int goalPoints = int.Parse(parts[3]);

            //switch statements for each goaltype
            //get the rest of details' parts
            //initialize new goaltype
            //add goal back to _goals list
            switch (goalType)
            {
                case "SimpleGoal":
                    bool goalIsComplete = bool.Parse(parts[4]);
                    SimpleGoal simple = new(goalName, goalDescription, goalPoints, goalIsComplete);
                    _goals.Add(simple);
                    break;
                case "ChecklistGoal":
                    goalIsComplete = bool.Parse(parts[4]);
                    int goalBonus = int.Parse(parts[5]);
                    int goalAmountCompleted = int.Parse(parts[6]);
                    int goalTarget = int.Parse(parts[7]);
                    ChecklistGoal checklist = new(goalName, goalDescription, goalPoints, goalIsComplete, goalBonus, goalAmountCompleted, goalTarget);
                    _goals.Add(checklist);
                    break;
                default:
                    EternalGoal eternal = new(goalName, goalDescription, goalPoints);
                    _goals.Add(eternal);
                    break;
            }
        }
        //User message, goals are loaded
        Console.WriteLine("Goals are loaded.");
    }
}