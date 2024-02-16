using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private List<int> _visibleIndex = new List<int>();
    private bool _scriptureHidden;
    private Reference _reference;


    public Scripture(string text, string reference)
    {
        // Split the text into individual words by spaces
        string[] words = text.Split(' ');
        for (int x = 0; x < words.Length; x++)
        {
            // Add each word to the list of words and store the index of the word in _visibleIndex
            var verse = new Word(words[x]);
            _words.Add(verse);
            _visibleIndex.Add(x);

        }
        // Split the reference into book and chapter
        string[] referenceSplit = reference.Split('+');
        string book = referenceSplit[0];
        string[] referenceInt = referenceSplit[1].Split(':');
        string chapter = referenceInt[0];

        // Check if the end verse is included
        char dash = '-';
        if (referenceInt[1].Contains(dash))
        {
            //Split into Start and End verses
            string[] verseInt = referenceInt[1].Split("-");
            string startVerse = verseInt[0];
            string endVerse = verseInt[1];
            Reference reference1 = new Reference(book, chapter, startVerse, endVerse);
            _reference = reference1;
        }
        else
        {
            //Add Verse into reference
            string startVerse = referenceInt[1];
            Reference reference1 = new Reference(book, chapter, startVerse);
            _reference = reference1;
        }




    }
    public string DisplayScripture()
    {
        string text = "";
        foreach (Word word in _words)
        {
            // Add the words from the list into text string
            text += word.GetWord();
        }
        // Add the reference to the text
        return _reference.DisplayReference() + " " + text;
    }
    public void HideScripture()
    {
        Random rand = new Random();
        // Pick a random number of words to hide that is at least 1 and at most half the number of words plus 1
        int randomAmount = rand.Next(1, _visibleIndex.Count / 2 + 1);
        for (int i = 0; i < randomAmount; i++)
        {
            // Pick a random Index from _visibleIndex to hide corresponding word
            int randomIndex = rand.Next(_visibleIndex.Count);
            _words[_visibleIndex[randomIndex]].HideWord();
            // Remove the random index from _visibleIndex
            _visibleIndex.Remove(_visibleIndex[randomIndex]);

        }

    }
    public bool CheckHidden()
    {
        // Check if _visibleIndex is empty
        if (_visibleIndex.Count == 0)
        {
            _scriptureHidden = true;
        }
        else
        {
            _scriptureHidden = false;
        }
        return _scriptureHidden;
    }
    public string ShowReference()
    {
        return _reference.DisplayReference();
    }
}