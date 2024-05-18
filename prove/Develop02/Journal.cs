using System;

public class Journal
{
    public List<Entry> entries;


    public Journal()
    {
        entries = new List<Entry>();
    }
    public void AddEntry(string prompt)
    {
        Console.Write(prompt + " ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("MM/dd/yyyy");
        entries.Add(new Entry(date, prompt, response));
    }
    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }
    public void SaveEntryToFile(string filePath)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Entry entry in entries)
                {
                    writer.WriteLine(entry.ToString());
                }
            }
            Console.WriteLine("Entries saved to file successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving entries to file: {ex.Message}");
        }
    }

    public void LoadEntriesFromFile(string loadfilePath)
    {
        // Console.Write("Enter the file path to load entries from: ");
        // string filePath = Console.ReadLine();   

        if (File.Exists(loadfilePath))
        {
            using (StreamReader reader = new StreamReader(loadfilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string date = line.Split('-')[0].Trim().Split(' ')[1];
                    string prompt = line.Split('-')[1].Trim();
                    string response = reader.ReadLine();
                    entries.Add(new Entry(prompt, response, date));
                    reader.ReadLine(); // Skip the empty line
                }
            }
        }
    }

}


