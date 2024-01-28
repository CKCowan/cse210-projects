
using System.Runtime.CompilerServices;

public class Scripture 
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    static Random random = new Random();

    private bool everyWordHidden;

    

    public Scripture(Reference reference, string text){
        // Set _reference to equal reference passed into constructor
        _reference = reference;

        // Create list of words by splitting up the text passed in
        string[] splitText = text.Split(" ");
        for(int i = 0; i<splitText.Length; i++){
            Word word = new Word(splitText[i]);
            _words.Add(word);
            // Console.WriteLine(word._text);
        }
        
    }

    public void HideRandomWords(int numberToHide){
        // Use for loop with numberToHide as how many times loop runs to change an index from a word to underscores
        int _wordsLength = _words.Count();
        
        for(int i = 0; i<numberToHide; i++){
            int index = random.Next(_wordsLength);
            _words[index].Hide();
        }


    }
    public string GetDisplayText(){
        // Show scripture with some words shown and others with underscores
        string displayText = "";
        foreach(Word w in _words){

            displayText = displayText + w.GetDisplayText() + " ";
        }
        return displayText;
        
    }
    public bool IsCompletelyHidden(){
        everyWordHidden = true;
        foreach(Word word in _words){
            // Console.WriteLine(word.isHidden());
            if(word.isHidden() == false){
                everyWordHidden = false;
            }
        }
        if(everyWordHidden){
            return true;
        }
        else{
            return false;
        }
    }

}