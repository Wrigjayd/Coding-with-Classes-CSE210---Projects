public class LoadJournal()
{
    public List<JournalEntry> Load(string filename)
    {
        List<JournalEntry> loadedEntries = new List<JournalEntry>();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            JournalEntry newEntry = new JournalEntry();
            newEntry._prompt = parts[0];
            newEntry._entry = parts[1];

            loadedEntries.Add(newEntry);
        }
        return loadedEntries;

    }

    

        
    

}