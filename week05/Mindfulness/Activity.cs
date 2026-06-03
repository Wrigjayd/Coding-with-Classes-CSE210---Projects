using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;

    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for you session");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(3);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWellDone!");
        ShowSpinner(3);
        Console.WriteLine($"You Have Completed another{_duration} seconds of the {_name}.");
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };
    
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
        
            // Print the character without a new line
            Console.Write(s);
        
            Thread.Sleep(250);
        
            // Use the backspace character (\b) to move the cursor back one space
            Console.Write("\b");

            i++;
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }   
    
        // Clean up the final frame character by replacing it with a blank space
        Console.Write(" \b");
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            // Print the current number
            Console.Write(i);
            
            Thread.Sleep(1000);
            
            // Handle backspacing based on how many digits the number has
            if (i >= 10)
            {
                // Backspace twice, overwrite with spaces, backspace twice again for two digit numbers
                Console.Write("\b\b  \b\b");
            }
            else
            {
                // Backspace once, overwrite with a space, backspace once again for one digit numbers
                Console.Write("\b \b");
            }
        }
    }
}