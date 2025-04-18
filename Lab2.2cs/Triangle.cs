using System;

namespace Lab2_2
{
    public class Triangle : Figure
    {
        private double _x1, _y1, _x2, _y2, _x3, _y3;

        public double X1 { get { return _x1; } }
        public double Y1 { get { return _y1; } }
        public double X2 { get { return _x2; } }
        public double Y2 { get { return _y2; } }
        public double X3 { get { return _x3; } }
        public double Y3 { get { return _y3; } }

        public Triangle() : base("Triangle")
        {
            _x1 = 1; _y1 = 1;
            _x2 = 4; _y2 = 1;
            _x3 = 2; _y3 = 5;
        }

        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
            : base("Triangle")
        {
            _x1 = x1; _y1 = y1;
            _x2 = x2; _y2 = y2;
            _x3 = x3; _y3 = y3;
        }

        public Triangle(Triangle other) : base("Triangle")
        {
            _x1 = other._x1; _y1 = other._y1;
            _x2 = other._x2; _y2 = other._y2;
            _x3 = other._x3; _y3 = other._y3;
        }

        private double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public override double CalculateArea()
        {
            double a = Distance(_x1, _y1, _x2, _y2);
            double b = Distance(_x2, _y2, _x3, _y3);
            double c = Distance(_x3, _y3, _x1, _y1);

            double s = (a + b + c) / 2;

            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public override double CalculatePerimeter()
        {
            double a = Distance(_x1, _y1, _x2, _y2);
            double b = Distance(_x2, _y2, _x3, _y3);
            double c = Distance(_x3, _y3, _x1, _y1);

            return a + b + c;
        }

        public override string ToString()
        {
            return $"Triangle: Vertices at ({_x1},{_y1}), ({_x2},{_y2}), ({_x3},{_y3})";
        }
    }
}
