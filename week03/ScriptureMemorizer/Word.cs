using System;

public class Word
    {
        public string _text;
        public bool _isHidden;

        Word(string text)
        {
            _text = text;
            _isHidden = false;
        
        }
        public void hide()
        {
            _isHidden = true;
        }
        
    }