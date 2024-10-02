public class Entry
{

    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry (string date, string promtText, string entryText)
    {
        _date = date;
        _promptText = promtText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"Date: {_date}");   
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine();
    }
}