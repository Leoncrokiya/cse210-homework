public class ScriptureMemorizer
{
    private List<Reference> _references;

    public ScriptureMemorizer(Reference reference, string text)
    {
        _references = new List<Reference>();
        _references.Add(reference);
    }

    public void HideRandomWords(int numberOfWordsToHide)
    {
        
    }

    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}