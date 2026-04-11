using System;

namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        private bool _isComplete = false;

        public SimpleGoal(string name, string description, int points) : base(name, description, points.ToString())
        {
        }

        public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points.ToString())
        {
            _isComplete = isComplete;
        }

        public override int RecordEvent()
        {
            _isComplete = true;
            return int.Parse(_points);
        }

        public override bool IsComplete()
        {
            return _isComplete;
        }

        public override string GetStringRepresentation()
        {
            return $"{_shortName} ~ {_description} ~ {_points} ~ {_isComplete}";
        }
    }
}