
public class Word 
{
    private string _text;
    private bool wordHidden;

    public Word(string text){
        // text passed in is single word from list - word set as visible by default
        _text = text;
        wordHidden = false;
    }

    public void Hide(){
        // Set word to hidden
        wordHidden = true;
    }
    public void Show(){
        wordHidden = false;
    }
    public bool isHidden(){
        if(wordHidden){
            return true;
        }
        else{
            return false;
        }
    }

    public string GetDisplayText(){
        if(wordHidden){
            return "_____";
        }
        else{
            return _text;
        }
        
    }
    
}