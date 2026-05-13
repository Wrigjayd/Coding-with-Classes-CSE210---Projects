public class JournalMenu()
{
    public int GetChoice()
    {
        Console.WriteLine("Enter number of corrosponding entry: 1. Create Entry/ 2. Display/ 3. Load/ 4. Save/ 5. Quit");
        return int.Parse(Console.ReadLine());
    }
}