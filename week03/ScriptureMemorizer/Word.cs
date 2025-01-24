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
        public void Hide()
        {
            _isHidden = true;
        }
        public void Show()
        {
            _isHidden = false;
        }
        public bool IsHidden()
        {
            return _isHidden;
        }
        public string GetDisplayText()
        {
            return _isHidden ? "__": _text;
        }
    }