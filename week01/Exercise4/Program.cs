using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a List of numbers, type 0 when finished.");
        Console.WriteLine("Enter a number");
        string userInput = Console.ReadLine();
        int userNumber = int.Parse(userInput);
        List<int> numbers = new List<int>();
        int greatestNumber = 0;
        int sum = 0;
        int count = 0;
        int average = 0;
        do
        {
            Console.WriteLine("Enter a number:");
            userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);
            numbers.Add(userNumber);

        } while (userNumber != 0);

        foreach (int number in numbers)
        {
            sum = sum + number;
            count = count + 1;
            average = sum / count;

            if (number > greatestNumber)
            {
                greatestNumber = number;
            }
        }
        Console.WriteLine($"The largest number is {greatestNumber}");

        Console.WriteLine($"The sum of the numbers is {sum}");
        
        Console.WriteLine($"The average is {average}");

    }
    }