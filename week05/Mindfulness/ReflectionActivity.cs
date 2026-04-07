
public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you helped someone.",
        "Think of a time you did something difficult."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this meaningful?",
        "What did you learn?"
    };

    public ReflectionActivity()
        : base("Reflection Activity",
        "Reflect on times you showed strength.")
    {
    }

    public void Run()
    {
        StartMessage();

        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);

        int time = GetDuration();
        int elapsed = 0;

        while (elapsed < time)
        {
            Console.WriteLine(_questions[rand.Next(_questions.Count)]);
            ShowSpinner(3);
            elapsed += 3;
        }

        EndMessage();
    }
}