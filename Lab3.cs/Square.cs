using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Square
    {
        public readonly double x;
        public readonly double y;
        public readonly double side;

        public Square() : this(0, 0, 1) { }

        public Square(double x, double y, double side)
        {
            this.x = x;
            this.y = y;
            this.side = side;
        }

        public Square(Square other)
        {
            x = other.x;
            y = other.y;
            side = other.side;
        }

        ~Square()
        {
            Console.WriteLine("Square object is being deleted");
        }

        public double GetArea()
        {
            return side * side;
        }

        public double GetPerimeter()
        {
            return 4 * side;
        }

        public static Square operator +(Square a, Square b)
        {
            return new Square(a.x, a.y, a.side + b.side);
        }

        public static Square operator /(Square a, double value)
        {
            return new Square(a.x, a.y, a.side / value);
        }

        public override string ToString()
        {
            return $"Square: Origin ({x}, {y}), Side = {side}";
        }

    }
}
