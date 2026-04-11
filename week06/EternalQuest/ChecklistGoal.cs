// using System.Runtime.InteropServices.ComTypes;
using System;

namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int _amountCompleted = 0;
        private int _target = 0;
        private int _bonus = 0;

        public ChecklistGoal(string name, string description, int points, int target, int bonus)  : base(name, description, points.ToString())
        {
            _target = target;
            _bonus = bonus;
        }

        public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : this(name, description, points, target, bonus)
        {
            _amountCompleted = amountCompleted;
        }

        public override int RecordEvent()
        {
            _amountCompleted++;

            int totalPoints = int.Parse(_points);
            if (_amountCompleted == _target)
            {
                totalPoints += _bonus;
                Console.WriteLine($"Congratulations! You earned a bonus of {_bonus} points!");
            }

            return totalPoints;
        }

        public override bool IsComplete()
        {
            return _amountCompleted >= _target;
        }

        public override string GetDetailsString()
        {
            return $"{_shortName} - {_description} - Completed: {_amountCompleted}/{_target}";
        }

        public override string GetStringRepresentation()
        {
            return $"{_shortName} ~ {_description} ~ {_points} ~ {_amountCompleted}/{_target} ~ {_bonus}";
        }
    }
}