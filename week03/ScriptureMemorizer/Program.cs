using System;

class Program
{
    static void Main(string[] args)
    {
        Reference scriptureReference = new Reference("Proverbs", 3, 5, 6);

        string scriptureText = "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture scripture = new Scripture(scriptureReference, scriptureText);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())//if the scripture is completly hidden this will break the loop
            {
                Console.WriteLine("You have Memorized this scripture.");
                break;
            }

            Console.WriteLine("Press enter to hide more word, or type 'quit' to exit:");
            string intput = Console.ReadLine();

            if (intput.Trim().ToLower() == "quit")//if user enters quit it will break the loop
            {
                break;
            }
            scripture.HideRandomWords(2);
        }
        Console.WriteLine("Program has ended. Goodbye!");
    }
}