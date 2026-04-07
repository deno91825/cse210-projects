
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\nStarting {_name} Activity!");
        Console.WriteLine(_description);
        Console.WriteLine($"Duration: {_duration} seconds");
        ShowCountDown(3); // short countdown before starting
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nGood job! You completed {_name} for {_duration} seconds.");
        ShowSpinner(3); // short spinner at the end
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write(spinner[i % 4]);
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
        }
        Console.WriteLine();
    }
}