using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _energyLevel;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} | Energy Level: {_energyLevel}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
        Console.WriteLine("----------------------------------------");
    }
}