using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> _entries = new List<Entry>();
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    private HashSet<string> _usedPromptsToday = new HashSet<string>();

    public void WriteEntry()
    {
        string today = DateTime.Now.ToString("yyyy-MM-dd");
        if (_usedPromptsToday.Count == _prompts.Count)
        {
            _usedPromptsToday.Clear();
        }

        Random random = new Random();
        string prompt;
        do
        {
            prompt = _prompts[random.Next(_prompts.Count)];
        } while (_usedPromptsToday.Contains(prompt));

        _usedPromptsToday.Add(prompt);

        Console.WriteLine("\nPrompt: " + prompt);
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        _entries.Add(new Entry(today, prompt, response));
        Console.WriteLine("Entry saved!");
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
            return;
        }
        foreach (var entry in _entries)
        {
            Console.WriteLine("\nDate: " + entry.Date);
            Console.WriteLine("Prompt: " + entry.Prompt);
            Console.WriteLine("Response: " + entry.Response);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    _entries.Add(new Entry(parts[0], parts[1], parts[2]));
                }
            }
        }
        Console.WriteLine("Journal loaded successfully.");
    }
}
