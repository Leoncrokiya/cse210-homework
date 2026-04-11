using System;

namespace EternalQuest
{
    public abstract class Goal
    {
        protected string _shortName = "";
        protected string _description = "";
        protected string _points = "";

        public Goal(string name, string description, string points)
        {
            _shortName = name;
            _description = description;
            _points = points;
        }

        public abstract int RecordEvent();
        // {
        //     return;
        // }

        public abstract bool IsComplete();
        // {
        //     return false;
        // }

        public virtual string GetDetailsString()
        {
            string statusSymbol = IsComplete() ? "[X]" : "[ ]";
            return $"{statusSymbol} {_shortName} - {_description}";
        }

        public abstract string GetStringRepresentation();
        // {
        //     return $"{_shortName} - {_description} - {_points}";
        // }
    }
}