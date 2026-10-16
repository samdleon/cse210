public class Journal
{
    public string _fileName;
    public List<Entry> _entry = new List<Entry>();

    public void AddEntry()
    {

        Prompts p = new Prompts();
        Entry entry1 = new Entry();
        // move below to entry class, due to it being more relevant to entry than journal    
        DateTime theCurrentTime = DateTime.Now;
        entry1._date = theCurrentTime.ToShortDateString();

        entry1._prompt = p.RandomizePrompt();
        entry1._response = entry1.GetResponse(entry1._prompt);

        // need to make a new Entry instance
        // how to do that to make a new one that's got a unique name ever time?
        // count length of list of entries, add one?

        


        // [list random prompt] \n > *enter response*
    }

    public void DisplayAll()
    {


        foreach (Entry e in _entry)
        {
            e.ShowResponse();
        }
        
        // Date: [date] - Prompt: [prompt] \n [response]
        // *display ALL entries in journal


        // Console.WriteLine($"Name: {_name}\nJobs:");
        // foreach (Job j in _jobs)
        // {
        //     j.Display();
        // }
    }


    public void LoadFromFile()
    {
        // What is the filename? [userinput]

        // read in every line; make a new entry
        // clear every pre-existing entry to ensure no overlap between journals?
    }

    public void SaveToFile()
    {
        // What is the filename? [userinput]
    }




}