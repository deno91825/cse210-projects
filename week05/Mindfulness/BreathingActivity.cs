public class BreathingActivity : Activity
{
    public BreathingActivity(int duration)
        : base("Breathing", "This activity helps you relax by walking you through breathing in and out slowly.", duration)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        int cycles = _duration / 4; // 4 seconds per breathe in + out
        for (int i = 0; i < cycles; i++)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(2);
            Console.Write("Breathe out... ");
            ShowCountDown(2);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}