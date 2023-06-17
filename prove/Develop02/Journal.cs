using System.IO; 

// We add public to the general class of the Journal 
// to may be accessible to the other programs
public class Journal
{

    public List<Entry> entries;

    public Journal()
    {
        // We made a new list to insert the input of the user
        // and used in the other program 
        entries = new List<Entry>(); 
    }
    public void AddEntry(Entry newEntry)
    {
        // To the entries me add that input of the user 
        // which is adapted in Entry
        entries.Add(newEntry);
    }

    public void DisplayAll()
    {

        foreach(Entry entry in entries)
        {
            // Is displey the adapted entry from Entry 
            entry.Display();
            Console.WriteLine();  
        }
    }

    public void SaveFile(string file)
    {
        // Is made a list to save the input of the user 
        List<string> records = new List<string>();

        // We call foreach to save in separete forms the info insert
        foreach(Entry entry in entries)
        {
            string entryCSV = $"{entry.date}|{entry.promptText}|{entry.entryText} ";
            records.Add(entryCSV);

        }
  
        File.WriteAllLines(file, records);
    }

    public void LoadFromFile(string file)
    {
        // Is made a list to load and output the isert before 
        List<string> records = File.ReadAllLines(file).ToList();
        
        // We call foreach to record in separete forms the info saved
        foreach(string record in records)
        {
            // Is split for the referense beforo made it with the "|"
            string[] split = record.Split("|");
            Entry entry = new Entry(split[0], split[1], split[2]);
            entries.Add(entry);

        }

        // We use File to open the file Journal with the varieble of the recors
        File.WriteAllLines(file, records);
    }

}