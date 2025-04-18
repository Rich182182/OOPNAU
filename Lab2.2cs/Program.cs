using System;
using System.Collections.Generic;

namespace Lab2_2
{
    class Program
    {
        static void DisplayFigureInfo(Figure figure)
        {
            Console.WriteLine("\n--- Figure Information ---");
            Console.WriteLine(figure.ToString());
            Console.WriteLine($"Area: {figure.CalculateArea():F2}");
            Console.WriteLine($"Perimeter: {figure.CalculatePerimeter():F2}");
            Console.WriteLine("-------------------------\n");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Creating a triangle...");
            Console.Write("Enter triangle coordinates (x1 y1 x2 y2 x3 y3): ");
            string[] input = Console.ReadLine().Split();

            double x1 = double.Parse(input[0]);
            double y1 = double.Parse(input[1]);
            double x2 = double.Parse(input[2]);
            double y2 = double.Parse(input[3]);
            double x3 = double.Parse(input[4]);
            double y3 = double.Parse(input[5]);

            Triangle triangle = new Triangle(x1, y1, x2, y2, x3, y3);

            Console.WriteLine("\nCreating a circle...");
            Console.Write("Enter circle center and radius (centerX centerY radius): ");
            input = Console.ReadLine().Split();

            double centerX = double.Parse(input[0]);
            double centerY = double.Parse(input[1]);
            double radius = double.Parse(input[2]);

            Circle circle = new Circle(centerX, centerY, radius);

            DisplayFigureInfo(triangle);
            DisplayFigureInfo(circle);
        }
    }
}
