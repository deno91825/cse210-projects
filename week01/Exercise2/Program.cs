using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int gradePercentageInt = int.Parse(gradePercentage);

        string letter = "";

        string sign = "";
        int lastDigit = gradePercentageInt % 10;
        if (lastDigit >= 7) sign = "+";
        else if (lastDigit <= 2) sign = "-";

        if (gradePercentageInt >= 90)
        {
            letter = "A";
        }
        else if (gradePercentageInt >= 80)
        {
            letter = "B";
        }
        else if (gradePercentageInt >= 70)
        {
            letter = "C";
        }
        else if(gradePercentageInt >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"{letter}{sign}");

        if (gradePercentageInt >= 70)
        {
            Console.WriteLine("You passed the class, Congratulations!!!");
        }
        else
        {
            Console.WriteLine("You failed the class!!");
        }


    } 
}



