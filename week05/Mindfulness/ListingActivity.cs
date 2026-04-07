
public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who do you appreciate?",
        "What are your strengths?"
    };

    public ListingActivity()
        : base("Listing Activity",
        "List as many positive things as you can.")
    {
    }

    public void Run()
    {
        StartMessage();

        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);

        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items!");
        EndMessage();
    }
}