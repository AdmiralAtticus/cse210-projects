public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        int choice = -1;
        while (choice != 6)
        {
            Console.WriteLine();
            Console.WriteLine($"Score: {_score}");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option: ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1: CreateGoal(); break;
                case 2: ListGoals(); break;
                case 3: SaveGoals(); break;
                case 4: LoadGoals(); break;
                case 5: RecordEvent(); break;
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Option: ");
        int type = int.Parse(Console.ReadLine());

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == 1)
        {
            _goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (type == 2)
        {
            _goals.Add(new EternalGoal(name, desc, points));
        }
        else
        {
            Console.Write("Target Count: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    private void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
            return;
        }

        int index = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{index}. {g.GetDetailsString()}");
            index++;
        }
    }

    private void RecordEvent()
    {
        ListGoals();
        Console.Write("Which goal did you complete? ");
        int i = int.Parse(Console.ReadLine()) - 1;

        int earned = _goals[i].RecordEvent();
        _score += earned;

        Console.WriteLine($"You earned {earned} points!");
    }

    private void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                writer.WriteLine(g.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved!");
    }

    private void LoadGoals()
    {
        _goals.Clear();
        string[] lines = File.ReadAllLines("goals.txt");

        _score = int.Parse(lines[0]);


        // Used ChatGPT for this part 
        // Beginning Here: //

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");
            string type = parts[0];

            if (type == "SimpleGoal")
            {
                var goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                if (bool.Parse(parts[4]))
                {
                    typeof(Goal).GetField("_isComplete", System.Reflection.BindingFlags.NonPublic |
                                                          System.Reflection.BindingFlags.Instance)
                                .SetValue(goal, true);
                }
                _goals.Add(goal);
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (type == "ChecklistGoal")
            {
                var goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),
                                             int.Parse(parts[4]), int.Parse(parts[5]));

                typeof(ChecklistGoal).GetField("_currentCount",
                    System.Reflection.BindingFlags.NonPublic |
                    System.Reflection.BindingFlags.Instance)
                    .SetValue(goal, int.Parse(parts[6]));

                typeof(Goal).GetField("_isComplete",
                    System.Reflection.BindingFlags.NonPublic |
                    System.Reflection.BindingFlags.Instance)
                    .SetValue(goal, bool.Parse(parts[7]));

                _goals.Add(goal);
            }
        }

        // Ending here. //

        Console.WriteLine("Goals loaded!");
    }
}
