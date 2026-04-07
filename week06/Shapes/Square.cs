using System;

namespace Shapes
{
    public class Square : Shape
    {
        private double _side = 0;

        public void SetSide(double side)
        {
            _side = side;
        }

        public double GetArea()
        {
            return _side * _side;
        }
    }
}