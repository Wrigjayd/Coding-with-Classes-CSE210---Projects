using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
public class Scripture
{
    private Reference _reference;
    private List<Word>_words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] splitWords = text.Split(' ');
        foreach (string wordText in splitWords)
        {
            _words.Add(new Word(wordText));
        }
    }
    public void HideRandomWords(int hideNum)
    {
        Random random = new Random();

        List<Word> unhiddenWords = _words.Where(w => !w.isHidden()).ToList();//Making a list of unhidden words to prevent picking already hidden words

        int numberToHide = Math.Min(hideNum, unhiddenWords.Count);//If there are less unhidden words then hidden ones it will hide the rest

        for (int i =0; i < numberToHide; i++)
        {
            int randomIndex = random.Next(unhiddenWords.Count);
            unhiddenWords[randomIndex].Hide();
            unhiddenWords.RemoveAt(randomIndex);//prevents picking the same word to hide
        }
    }
    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }
        return $"{_reference.GetDisplayText()} - {string.Join(" ", displayWords)}";
    }
    public bool IsCompletelyHidden()
    {
        //returns tru if EVERY word returns true for the IsHidden Method
        return _words.All(w => w.isHidden());   
    }
}