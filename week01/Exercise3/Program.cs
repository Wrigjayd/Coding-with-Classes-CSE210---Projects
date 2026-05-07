using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        Console.WriteLine("Please guess the magic number.");
        string userInput = Console.ReadLine();
        int userNumber = int.Parse(userInput);
        do
        {
            if (userNumber == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }
            else
            {
                if (userNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                    Console.WriteLine("Please guess the magic number.");
                    userInput = Console.ReadLine();
                    userNumber = int.Parse(userInput);

                }
                else
                {
                    Console.WriteLine("Higher");
                    Console.WriteLine("Please guess the magic number.");
                    userInput = Console.ReadLine();
                    userNumber = int.Parse(userInput);
                }
                }
            } while (userNumber != magicNumber);
            Console.WriteLine("You Guessed it");
        }
        
    }
