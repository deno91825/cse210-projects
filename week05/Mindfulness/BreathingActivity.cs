
public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity",
        "This helps you relax by breathing slowly.")
    {
    }

    public void Run()
    {
        StartMessage();

        int time = GetDuration();
        int elapsed = 0;

        while (elapsed < time)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(3000);

            Console.WriteLine("Breathe out...");
            Thread.Sleep(3000);

            elapsed += 6;
        }

        EndMessage();
    }
}