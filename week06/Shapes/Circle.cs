using System;

namespace Shapes
{
    public class Circle : Shape
    {

        private double _radius = 0;

        public void SetRadius(double radius)
        {
            _radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}