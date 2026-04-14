using System.Diagnostics;
using System;

namespace ExerciseTracking
{
    class Activity
    {
        private int _laps = 0;
        private int _minutes = 0;

        protected float _distance = 0;
        protected float _speed = 0;
        protected float _pace = 0;
        public string _date  = "";

        public Activity()
        {
            _distance = _laps * 50f / 1000f * 0.62f;
            _speed = (_distance / _minutes) * 60;
            _pace = _minutes / _distance;
        }

        public void DisplayActivity()
        {
            
        }
    }
}