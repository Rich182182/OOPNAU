using System;
using System.Text;
using System.Threading.Tasks;

namespace Lab1cs
{
    internal class Vector
    {
        private readonly double x, y;
        public Vector(double x = 0, double y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public string PrintCoordinates()
        {
            return $"Coordinates: ({x}, {y})";
        }

        private double Magnitude()
        {
            return Math.Sqrt(x * x + y * y);
        }

        private double Angle()
        {
            return Math.Atan2(y, x);
        }

        public string PrintPolarCoordinates()
        {
            return $"Polar Coordinates: ({Magnitude()}, {Angle()})";
        }
    }
}
