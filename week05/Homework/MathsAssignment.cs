using System;

namespace Homework
{
    public class MathsAssignment : Assignment
    {
        private string _textbookSection;
        private string _problems;

        public string GetTextbookSection()
        {
            return _textbookSection;
        }

        public void SetTextbookSection(string textbookSection)
        {
            _textbookSection = textbookSection;
        }

        public string GetHomeworkList()
        {
            return _problems;
        }

        public void SetHomeworkList(string problems)
        {
            _problems = problems;
        }
        
        public string GetMathsSummary()
        {
            return $"{_studentName} - {_topic} - {_textbookSection} - {_problems}";
        }
    }
}