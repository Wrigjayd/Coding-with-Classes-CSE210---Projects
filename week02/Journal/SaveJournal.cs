using System.IO; 
public class SaveJournal()
{

    string filename = "journalFile.txt";
    public void Save(string filename, List<JournalEntry> entries)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in entries)
            {
                outputFile.WriteLine($"{entry._prompt}|{entry._entry}|{entry._date}");
            }
          
        }
    }
}
