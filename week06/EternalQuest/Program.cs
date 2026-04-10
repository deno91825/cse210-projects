/*
EXCEEDS REQUIREMENTS:
- Added score persistence (saved and loaded with goals)
- Checklist bonus system implemented
- Eternal goals use infinity symbol display
- Clean polymorphic design using abstract base class
- Supports multiple goal types using inheritance
*/
using System;

class Program
{
    static void Main(string[] args)
    {
     
        while (running)
        {
            Console.WriteLine("\n--- Eternal Quest ---");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save");
            Console.WriteLine("6. Load");
            Console.WriteLine("7. Quit");

            Console.Write("Choose: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("1.Simple 2.Eternal 3.Checklist");
                string type = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Description: ");
                string desc = Console.ReadLine();

                Console.Write("Points: ");
                int points = int.Parse(Console.ReadLine());

                if (type == "1")
                    manager.CreateGoal(new SimpleGoal(name, desc, points));

                else if (type == "2")
                    manager.CreateGoal(new EternalGoal(name, desc, points));

                else
                {
                    Console.Write("Target: ");
                    int target = int.Parse(Console.ReadLine());

                    Console.Write("Bonus: ");
                    int bonus = int.Parse(Console.ReadLine());

                    manager.CreateGoal(new ChecklistGoal(name, desc, points, target, bonus));
                }
            }

            else if (choice == "2")
                manager.ListGoals();

            else if (choice == "3")
            {
                Console.Write("Goal number: ");
                int index = int.Parse(Console.ReadLine()) - 1;
                manager.RecordEvent(index);
            }

            else if (choice == "4")
                manager.DisplayScore();

            else if (choice == "5")
                manager.SaveGoals("goals.txt");

            else if (choice == "6")
                manager.LoadGoals("goals.txt");

            else if (choice == "7")
                running = false;
        }
    }
}
