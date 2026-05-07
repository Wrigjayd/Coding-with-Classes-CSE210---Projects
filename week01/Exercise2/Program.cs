using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the grade you got.");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        if (number >= 90)
        {
            Console.WriteLine("You got an A");
        }
        else if (number >= 80)
        {
            Console.WriteLine("You got a B");
        }
        else if (number >= 70)
        {
            Console.WriteLine("You got a C");
        }
        else if (number >= 60)
        {
            Console.WriteLine("You got a D");
        }
        else
        {
            Console.WriteLine("You got an F");
        }
    }
}