/*
EXCEEDING REQUIREMENTS
Random Word Selection Improvement
The program attempts to hide only words that are not already hidden.
This prevents the program from repeatedly selecting the same hidden word
and makes the memorization process more efficient.


Randomized Hiding of Words
The program hides multiple random words at a time which increases the
difficulty gradually and helps improve memorization practice.
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        Scripture scripture = new Scripture(reference,
        "Trust in the Lord with all thine heart and lean not unto thine own understanding");

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish.");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Program ended.");
    }
}