using System;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int magicNumberInt = rand.Next(1,101);

        int guessInt = 0;
        int guessesMade = 0;
        string playAgain = "yes";
        while (playAgain == "yes")
        {
            Console.Write("Do you want to play again?");
            playAgain =  Console.ReadLine(); 
            while (guessInt != magicNumberInt)
                {
                    guessesMade++;
                    Console.Write("Guess the magic Number ");
                    string guess = Console.ReadLine();
                    guessInt = int.Parse(guess);
                    if (guessInt < magicNumberInt)
                    {
                        Console.Write("Higher\n");
                    }
                    else if (guessInt > magicNumberInt)
                    {
                        Console.Write("Lower\n");
                    }
                    else
                    {
                        Console.Write("You guessed the number!\n");
                        Console.Write($"You made {guessesMade} guesses");
                    }
                }   
        }

    }
}