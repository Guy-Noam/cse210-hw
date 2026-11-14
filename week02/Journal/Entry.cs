public class Entry
{
    private string _date = "";
    private string _promptText = "";
    private string _entryText = "";

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public string GetEntryText()
    {
        return _entryText;
    }
    public string GetPrompt()
    {
        return _promptText;
    }

    public string GetDate()
    {
        
        return _date;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }
}