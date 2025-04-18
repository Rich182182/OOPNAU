using System;

namespace Lab2_2
{
    public class Circle : Figure
    {
        private double _radius;
        private double _centerX, _centerY;

        public double Radius { get { return _radius; } }
        public double CenterX { get { return _centerX; } }
        public double CenterY { get { return _centerY; } }

        public Circle() : base("Circle")
        {
            _centerX = 0;
            _centerY = 0;
            _radius = 1;
        }

        public Circle(double centerX, double centerY, double radius) : base("Circle")
        {
            _centerX = centerX;
            _centerY = centerY;
            _radius = radius > 0 ? radius : 1;
        }

        public Circle(Circle other) : base("Circle")
        {
            _centerX = other._centerX;
            _centerY = other._centerY;
            _radius = other._radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * _radius;
        }

        public override string ToString()
        {
            return $"Circle: Center at ({_centerX},{_centerY}), Radius = {_radius}";
        }
    }
}
