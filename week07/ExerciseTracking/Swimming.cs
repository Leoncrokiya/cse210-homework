using System;

namespace ExerciseTracking
{
    class Swimming : Activity
    {
        public Swimming(float distance, float speed, float pace, string date)
        {
            // distance = laps * 50 / 1000 * 0.62;
            // speed = (distance / minutes) * 60;
            // pace = minutes / distance;

            _distance =distance;
            _speed = speed;
            _pace = pace;
            _date = date;
        }

        public string DisplaySwimmingActivity()
        {
            return $"{_date} Swimming- Distance {_distance} miles, Speed {_speed} mph, Pace: {_pace} min per mile";
        }
    }
}