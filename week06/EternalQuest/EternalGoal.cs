using System;

namespace EternalQuest // If eternal goal is to be with Heavenly Father, then it's eternal on Earth but has a cosmic finality.
{
    public class EternalGoal : Goal // When they "Make the gospel fun", this  program couldn't be more literal.
    {
        public EternalGoal(string name, string description, int points) : base(name, description, points.ToString())
        {
            // _shortName = name;
            // _description = description;
            // _points = points.ToString();
        }

        public override int RecordEvent()
        {
            return int.Parse(_points); // Can't be recorded on Earth as humans currently can't live forever.
        }

        public override bool IsComplete()
        {
            return false; // This goal can't be completed on Earth, but can be completed cosmically.
        }

        public override string GetStringRepresentation()
        {
            return $"{_shortName} ~ {_description} ~ {_points}";
        }
    }
}