using System.IO; 
public class GoalManager
{
    private int _score;
    List<Goal> _goals = new List<Goal>();
    public GoalManager()
    {

    }
    public string filename = "Goals.txt";
    public void Start()
    {
        Console.WriteLine();
        DisplayPlayerInfo();
        Console.WriteLine("\nMenu Options:");
        Console.WriteLine("(1) Create new Goal");
        Console.WriteLine("(2) List Goals");
        Console.WriteLine("(3) Save Goals");
        Console.WriteLine("(4) Load Goals");
        Console.WriteLine("(5) Record Event");
        Console.WriteLine("(6) Quit");
        Console.Write("Please select a choice from the menu: ");
        string entry = Console.ReadLine();

        if (entry == "1")
        {
            CreateGoal();
            Start();
        }
        else if (entry == "2")
        {
            Console.WriteLine("\nYour goals are:");
            int i = 1;
            foreach (Goal goal in _goals)
            {
                string line = goal.GetStringRepresentation();
                string[] part = line.Split("//");
                string id = part[0];
                string goalName = part[1];
                string description = part[2];
                string points = part[3];
                Console.Write($"({i}) ");
                if (id == "SG")
                {

                    SimpleGoal simpleGoal = new SimpleGoal(goalName, description, points);
                    bool check = simpleGoal.IsComplete();
                    Console.WriteLine(simpleGoal.GetDetailsString(check));
                }
                if (id == "EG")
                {
                    EternalGoal eternalGoal = new EternalGoal(goalName,description,points);
                    bool check = eternalGoal.IsComplete();
                    Console.WriteLine(eternalGoal.GetDetailsString(check));
                }
                if (id == "CG")
                {
                    int target = int.Parse(part[5]);
                    int bonus = int.Parse(part[6]);
                    ChecklistGoal checklistGoal = new ChecklistGoal(goalName, description, points, target, bonus);
                    bool check = checklistGoal.IsComplete();
                    Console.WriteLine(checklistGoal.GetDetailsString(check));
                }
                i++;
            }

            Start();
        }
        else if (entry == "3")
        {
            SaveGoals();
            Console.WriteLine("Your Goals are saved");
            Start();
        }
        else if (entry == "4")
        {
            LoadGoals();
            Start();
        }
        else if (entry == "5")
        {
            Console.WriteLine($"Your number is {entry}");
            Start();
        }
        else
        {
            Console.Write("BYE!");
        }

    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your score is: {_score}");
    }
    public void ListGoalNames()
    {
        Console.WriteLine("Name");
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("Details");
        
    }
    public void CreateGoal()
    {
        Console.WriteLine("\nTypes of Goals:");
        Console.WriteLine("(1) Simple Goal");
        Console.WriteLine("(2) Eternal Goal");
        Console.WriteLine("(3) Checklist Goal");
        Console.Write("What kind of Goal would you like to create? ");
        string entry = Console.ReadLine();

        if (entry == "1")
        {

            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the ammount of points associated with this goal? ");
            string points = Console.ReadLine();

            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            // simpleGoal.RecordEvent();
            _goals.Add(simpleGoal);
            // SaveGoals();
        }
        else if (entry == "2")
        {

            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the ammount of points associated with this goal? ");
            string points = Console.ReadLine();

            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
            // SaveGoals();
        }
        else if (entry == "3")
        {

            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the ammount of points associated with this goal? ");
            string points = Console.ReadLine();
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string t = Console.ReadLine();
            int target = int.Parse(t);
            Console.Write("What is the bonus for accomplishing it that many times? ");
            string bp = Console.ReadLine();
            int bonus = int.Parse(bp);

            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
            // SaveGoals();
        }
    }
    public void RecordEvent()
    {

    }

    // public void SaveGoals(output)
    public void SaveGoals()
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
            
    }
    public void LoadGoals()
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        string score = lines[0];
        _score = int.Parse(score);
        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];

            string[] parts = line.Split("//");

            string id = parts[0];
            string goalName = parts[1];
            string description = parts[2];
            string points = parts[3];
            if (id == "SG")
            {
                SimpleGoal simpleGoal = new SimpleGoal(goalName, description, points);
                // Console.WriteLine(simpleGoal.GetStringRepresentation());
                _goals.Add(simpleGoal);
            }
            if (id == "EG")
            {
                EternalGoal eternalGoal = new EternalGoal(goalName, description, points);
                // Console.WriteLine(eternalGoal.GetStringRepresentation());
                _goals.Add(eternalGoal);
            }
            if (id == "CG")
            {
                // string completion = parts[4];
                string target = parts[5];
                string bonus = parts[6];

                int t = int.Parse(target);
                int b = int.Parse(bonus);
                ChecklistGoal checklistGoal = new ChecklistGoal(goalName, description, points, t, b);
                // Console.WriteLine(checklistGoal.GetStringRepresentation());
                _goals.Add(checklistGoal);

            }

        }
        Console.WriteLine("\nYour goals have successfully loaded");
    }
}