public class Word
{
    private string _word;

    public Word(string word)
    {
        _word = word;
    }
    public string GetWord()
    {
        return " " + _word;
    }
    public void HideWord()
    {
        string hiddenWord = "";
        // Replace all characters with underscores
        for (int i = 0; i < _word.Length; i++)
        {
            hiddenWord += "_";
        }
        _word = hiddenWord;
    }

}