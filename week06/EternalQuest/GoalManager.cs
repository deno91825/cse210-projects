
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void DisplayScore()
    {
        Console.WriteLine($"Score: {_score}");
    }

    public void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int index)
    {
        Goal goal = _goals[index];
        goal.RecordEvent();

        _score += goal.GetPoints();

        if (goal is ChecklistGoal cg)
        {
            if (cg.IsComplete())
            {
                _score += cg.GetBonus();
            }
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);

            foreach (Goal g in _goals)
            {
                writer.WriteLine(g.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        string[] lines = File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string type = parts[0];
            string data = parts[1];

            string[] d = data.Split(",");

            if (type == "SimpleGoal")
            {
                SimpleGoal g = new SimpleGoal(d[0], d[1], int.Parse(d[2]));
                _goals.Add(g);
            }
            else if (type == "EternalGoal")
            {
                EternalGoal g = new EternalGoal(d[0], d[1], int.Parse(d[2]));
                _goals.Add(g);
            }
            else if (type == "ChecklistGoal")
            {
                ChecklistGoal g = new ChecklistGoal(
                    d[0], d[1],
                    int.Parse(d[2]),
                    int.Parse(d[3]),
                    int.Parse(d[4])
                );
                _goals.Add(g);
            }
        }
    }
}