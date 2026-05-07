using System;

class Program
{
    static void Main(string[] args)
    {
        static void displayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string promptUserName()
        {
            Console.WriteLine("What is your name");
            string userName= Console.ReadLine();
            return userName;    
        }

        static int promptUserNumber()
        {
            Console.WriteLine("Enter your Favorite Number.");
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);
            return userNumber;
        }

        static int squareNumber(int userNumber)
        {
            int squaredNumber = userNumber * userNumber;
            return squaredNumber;
        }
        static void displayResult(string userName, int squaredNumber)
        {
            Console.WriteLine($"{userName}, the sqyare of your number is {squaredNumber}");
        }
        displayWelcome();
        string userName = promptUserName();
        int userNumber = promptUserNumber();
        int squaredNumber = squareNumber(userNumber);
        displayResult(userName, squaredNumber);
    }
}