using System;
public class Reference
{
    private string _book ;
    private int _chapter;
    private int _verse;
    private int _finalVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _finalVerse = verse;
        
        
    }
    public Reference(string book, int chapter, int verse, int finalVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _finalVerse = finalVerse;

    }
    public string GetDisplayText()
    {
        if (_verse == _finalVerse){
            return $"{_book} {_chapter}:{_verse}";
        }
        else{
            return $"{_book} {_chapter}:{_verse}-{_finalVerse}";
        }

    }
}