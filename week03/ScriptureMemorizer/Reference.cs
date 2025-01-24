using System;

public class Reference
    {
        public string _book;
        public int _chapter;
        public int _verse;
        public int _endVerse;

        public Reference(string book, int chapter, int verse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
        }

        public string GetDisplayText()
        {
            //If the verse is singular the verse ends. If the passage contains more than one verse it will return multiple verses
            if (_verse == _endVerse)
                return($"{_book}, {_chapter}, {_verse}");
            else
                return($"{_book} {_chapter}: {_verse} -- {_endVerse}");
        }

    }