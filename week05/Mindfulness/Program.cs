using System;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Denis" , "123");
        string name = student.GetName();
        string number = student.GetNumber();
        Console.WriteLine(name);
        Console.WriteLine(number);

    }
    
}