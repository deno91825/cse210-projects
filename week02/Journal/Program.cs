// EXTRA FEATURE:
// This program includes a journal summary feature that displays
// the total number of entries, the first entry date, and the most recent entry.
// This helps users quickly understand their journaling activity.

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Write new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Load journal from file");
            Console.WriteLine("4. Save journal to file");
            Console.WriteLine("5. Quit");
            Console.WriteLine("6. Show journal summary");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": // Write new entry
                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    Entry entry = new Entry();
                    entry._date = DateTime.Now.ToShortDateString();
                    entry._promptText = prompt;
                    entry._entryText = response;

                    journal.AddEntry(entry);
                    Console.WriteLine("Entry added!\n");
                    break;

                case "2": // Display journal
                    journal.DisplayAll();
                    break;

                case "3": // Load journal
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    Console.WriteLine("Journal loaded!\n");
                    break;

                case "4": // Save journal
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    Console.WriteLine("Journal saved!\n");
                    break;

                case "5": // Quit
                    running = false;
                    break;

                case "6":
                    journal.ShowSummary();
                    break;

                default:
                    Console.WriteLine("Invalid choice, try again.\n");
                    break;
            }
        }
    }
}