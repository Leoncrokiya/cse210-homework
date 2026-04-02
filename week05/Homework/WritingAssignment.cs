using System;

namespace Homework
{
    public class WritingAssignment : Assignment
    {
        private string _title = "";

        public string GetTitle()
        {
            return _title;
        }

        public void SetTitle(string title)
        {
            _title = title ;
        }

        public string GetWritingInformation()
        {
            return $"{_studentName} - {_topic} - {_title}";
        }
    }
}