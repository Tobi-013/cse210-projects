public class Journal
{
    public string _name;
    public List<Entry> _entries = new List<Entry>();

    public void DisplayJournal()
    {
       
        foreach(Entry ent in _entries)
        {
            ent.DisplayEntry();
        }
    }
}