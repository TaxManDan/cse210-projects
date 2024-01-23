public class Entry{
    public string _prompt;
    public string _date;

    public string _userEntry;

    public string MergeEntry(){
        string entry = $"{_date} {_prompt} {_userEntry}";
        return entry;
    }
}