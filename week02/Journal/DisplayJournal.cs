public class DisplayJournal()
{
    public void ShowJournal(List<JournalEntry> entries)
    {
        foreach (JournalEntry entry in entries)
        {
            Console.WriteLine($"{entry._prompt}");
            Console.WriteLine($"{entry._entry}");
        }
    }
}