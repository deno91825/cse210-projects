using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int newNumber = 1;
        int total = 0;
        int items = 0;
        int largest = 0;
        int average;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (newNumber != 0)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            newNumber = int.Parse(input);

            if (newNumber != 0)
            {
                numbers.Add(newNumber);
                total = total + newNumber;
                items++;
                if (newNumber > largest)
                {
                    largest = newNumber;
                }

            }
        }
        average = total / items;
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is:{largest}");
        

    }
}
