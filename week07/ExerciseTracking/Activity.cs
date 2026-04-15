using System.Diagnostics;
using System;

namespace ExerciseTracking
{
    public abstract class Activity
    {
        private string _date  = "";
        protected int _minutes = 0;

        public Activity(string date, int minutes)
        {
            _date = date;
            _minutes = minutes;
        }

        public abstract float GetDistance();
        public abstract float GetSpeed();
        public abstract float GetPace();

        public virtual string GetSummary()
        {
            return $"{_date} {GetType().Name} ({_minutes} min): Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
        }
    }
}