public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        void Hide()
        {
            _isHidden = true;
        }

        void Show()
        {
            _isHidden = false;
        }

        bool IsHidden()
        {
            return _isHidden;
        }

        string GetDisplayText()
        {
            return _text;
        }
    }
}