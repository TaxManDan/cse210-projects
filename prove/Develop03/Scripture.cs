using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public class Scripture{
    private List<Word> _words = new List<Word>();
    private List<int> _visibleIndex = new List<int>();
    private bool _scriptureHidden;
    private string _reference;
    

    public Scripture(string text, string reference){
        string[] words = text.Split(' ');
        for(int x =0; x < words.Length; x++){
            var verse = new Word(words[x]); 
            _words.Add(verse);
            _visibleIndex.Add(x);

        }
        string[] referenceSplit = reference.Split(' ');
        string book = referenceSplit[0];
        string[] referenceInt = referenceSplit[1].Split(':');
        int chapter = int.Parse(referenceInt[0]);
        char dash = '-';
        if (referenceInt[0].Contains(dash)){
            string[] verseInt = referenceInt[0].Split("-");
            int startVerse = int.Parse(verseInt[0]);
            int endVerse = int.Parse(verseInt[1]);
            Reference reference1 = new Reference(book, chapter, startVerse, endVerse);
            _reference = reference1.DisplayReference();
        }
        else{
            int startVerse = int.Parse(referenceInt[1]);
            Reference reference1 = new Reference(book, chapter, startVerse);
            _reference = reference1.DisplayReference();
        } 
        
        
            
                   
    }
    public string DisplayScripture(){
        string text = "";
        foreach(Word word in _words){
            text += word.GetWord();
        }
        string scripture = _reference + "" + text;
        return scripture;
    }
    public void HideScripture(){
        Random rand = new Random();
        int randomAmount = rand.Next(1,_visibleIndex.Count/2+1);
        for (int i = 0; i < randomAmount; i++){
            int randomIndex = rand.Next(_visibleIndex.Count);
            _words[_visibleIndex[randomIndex]].HideWord();
            _visibleIndex.Remove(_visibleIndex[randomIndex]);

        }
        
    }
    public bool CheckHidden(){
        if (_visibleIndex.Count == 0){
            _scriptureHidden = true;
        }
        else{
            _scriptureHidden = false;
        }
        return _scriptureHidden;
    }
}