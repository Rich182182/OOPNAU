using System;

namespace Lab2
{
    public class Vector
    {
        private readonly double _x;
        private readonly double _y;

        public Vector() : this(0, 0) { }

        public Vector(double x, double y)
        {
            _x = x;
            _y = y;
        }
        ~Vector()
        {
            Console.WriteLine("Vector object is being deleted");
        }
        public double Length()
        {
            return Math.Sqrt(_x * _x + _y * _y);
        }
        public (double Radius, double Angle) GetPolarCoordinates()
        {
            double radius = Length();
            double angle = Math.Atan2(_y, _x);
            return (radius, angle);
        }

        public override string ToString()
        {
            return $"({_x}, {_y})";
        }
    }
}