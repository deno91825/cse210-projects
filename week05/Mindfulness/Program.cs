// EXCEEDING REQUIREMENTS:
// - Added random prompts
// - Added counting feature in ListingActivity
// - Added spinner animation
using System;

class Program
{
    static void Main(string[] args)
    {
               while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Quit");

            Console.Write("Choose: ");
            string choice = Console.ReadLine();

            Console.Write("Enter duration in seconds: ");
            int duration = int.Parse(Console.ReadLine());

            if (choice == "1")
                new BreathingActivity(duration).Run();
            else if (choice == "2")
                new ReflectingActivity(duration).Run();
            else if (choice == "3")
                new ListingActivity(duration).Run();
            else if (choice == "4")
                break;
        }
    }
}