using System;
using System.ComponentModel.Design;
using System.Xml.Serialization;

class Program
{
    // Class-level field (accessible throughout the class)
    static List<JournalEntry> journalEntries = new List<JournalEntry>();

    static void Main(string[] args)
    {
        // creating instances
        JournalMenu menu = new JournalMenu();
        DisplayJournal display = new DisplayJournal();
        SaveJournal saving = new SaveJournal();
        LoadJournal loading = new LoadJournal();

        // menu start
        int userChoice = 0;
        //menu cycle
        while (userChoice != 5)
        {
            userChoice = menu.GetChoice();

            if (userChoice == 1)//create entry
            {
                JournalEntry newEntry = new JournalEntry();
                newEntry.CreateNewEntry();
                journalEntries.Add(newEntry);
            }

            else if (userChoice == 2)// Display
            {
                display.ShowJournal(journalEntries);
            }

            else if (userChoice == 3) //Load Entries 
            {
                Console.WriteLine("What is the Filename?");
                string filename = Console.ReadLine();
                journalEntries = loading.Load(filename);
            }
            else if (userChoice == 4)//Save Journal
            {
                Console.WriteLine("What is the Filename?");
                string filename = Console.ReadLine();
                saving.Save(filename, journalEntries);
            }


        }
    }
}