using System;
using System.Collections.Generic;
using System.Linq;
public class ScriptureMemorizer
{
    private Reference _references;
    private List<Word> _words;

    public ScriptureMemorizer(Reference reference, string text)
    {
        _references = reference;
        _words = text.Split(" ").Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberOfWordsToHide)
    {
        Random random = new Random();
        List<Word> visibleWords = _words.Where(word => !word.IsHidden()).ToList();

        for (int i = 0; i < numberOfWordsToHide && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string text = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_references.GetDisplayText()}\n{text}";
    }

    public bool IsCompletelyHidden() => _words.All(word => word.IsHidden());
}